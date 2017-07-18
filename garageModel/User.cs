using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace garageModel
{
    public class User
    {
        private string name;
        private string passwordHashed;
        private string passwordUnHashed;        

        public User() 
        {
        }
        public User(string inName)
        {
            name = inName;
        }
        public User(string inName, string inPassword) 
        {
            name = inName;
            passwordUnHashed = inPassword;
            passwordHashed = HashPassword(inPassword);
        } 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PasswordUnHashed
        {
            get { return passwordUnHashed; }
            set { passwordUnHashed = value; }
        }

        public string PasswordHashed
        {
            get { return passwordHashed; }
            set { passwordHashed = HashPassword(value); }
        }
        
        public static string HashPassword(string inPassword)
        {

            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(GetBytes(inPassword));
            return GetString(md5data);            
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
