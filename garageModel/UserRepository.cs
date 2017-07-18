using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using garageUtility;

namespace garageModel
{
    public class UserRepository : Subject
    {
        private static UserRepository _instance = null;
        List<User> _listUsers = new List<User>();
        User currentUser = null;

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; 
                    NotifyObservers(); }
        }
        private UserRepository() 
        {
        }

        public static UserRepository GetInstance()
        {
            if (_instance == null) _instance = new UserRepository();

            return _instance;
        }

        public bool Contains(string inName)
        {
            foreach (User user in _listUsers) 
            {
                if (user.Name == inName) return true;
            }
            return false;
        }

        public void AddUser(User user)
        {
            if (Contains(user.Name)) throw new UserRepositoryContainsUser();
            _listUsers.Add(user);
        }

        public void AddUser(string inName, string inPassword) 
        {
            if (Contains(inName)) throw new UserRepositoryContainsUser();
            User user = new User(inName, inPassword);
            _listUsers.Add(user);
        }

        public void RemoveUser(User inUser)
        {
            if (!Contains(inUser.Name)) throw new UserRepositoryDoesNotContainUser();
            _listUsers.Remove(inUser);
        }

        public User GetUser(string inName, string inPassword)
        {
            if (!Contains(inName)) throw new UserRepositoryDoesNotContainUser();
            string passwordHashed = User.HashPassword(inPassword);            
            foreach (User user in _listUsers) 
            {
                if (user.Name == inName && user.PasswordHashed == passwordHashed) return user;
            }
            throw new IncorrectPassword();         
        }

        public void LoadGarageRepositoryFromDataBase()
        {
            try
            {
                string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                StreamReader sr = new StreamReader(filePath + "\\data\\DatabaseUserRepository.txt");
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] tokens = line.Split('\t');
                    AddUser(tokens[0], tokens[1]);
                }
                sr.Close();
            }
            catch
            {
                throw new DatabaseDoesNotExists();
            }
        }
        public void SaveUserRepositoryToDatabase()
        {
            try
            {
                string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                filePath += "\\data\\DatabaseUserRepository.txt";
                File.WriteAllText(filePath, string.Empty);
                StreamWriter sr = new StreamWriter(filePath);

                String line;
                foreach (User user in _listUsers)
                {
                    line = "";
                    line += user.Name + "\t" + user.PasswordUnHashed;                    
                    sr.WriteLine(line);
                }
                sr.Close();
            }
            catch
            {
                throw new DatabaseDoesNotExists();
            }
        }
    }
}
