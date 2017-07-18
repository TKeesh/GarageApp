using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageUtility
{
    public interface IController
    {
        void AddGarage();
        void AddGarage(string user, string address, string type, string name, List<int> values);
        void SignUp();
        void AddUser(string inName, string inPassword);
        void LogIn();
        void GetUser(string inName, string inPassword);
        void LogOut();
        void ChangeUsername();
        void ChangeUsername(string inUsername);
        void DeleteUser();
        void ChangePassword();
        void ChangePassword(string inPassword);
        void DeleteGarage(int inIndex);
        void OpenGarage(int inIndex);

    }
}
