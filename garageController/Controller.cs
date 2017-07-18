using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using garageModel;
using garageUtility;
using garageWF;

namespace garageController
{
    public class Controller : IController
    {
        private readonly GarageRepository _garageRepository = GarageRepository.GetInstance();
        private UserRepository _userRepositroy = UserRepository.GetInstance();

        public Controller()
        {            
        }

        public void AddGarage() 
        {
            FormAddGarage formAddGarage = new FormAddGarage(this);
            formAddGarage.ShowDialog();
        }
        public void AddGarage(string user, string address, string type, string name, List<int> values) 
        {
            Types inType = (Types)Enum.Parse(typeof(Types), type);
            Garage garage = new Garage(user, address, inType);
            garage.Name = name;
            garage.Open = false;
            for (int i = 0; i < values.Count; i++) 
            {
                switch (i) 
                {
                    case 0: garage.BicycleAmountTotal = values[i]; break;
                    case 1: garage.MopedAmountTotal = values[i]; break;
                    case 2: garage.MotorcycleAmountTotal = values[i]; break;
                    case 3: garage.CarAmountTotal = values[i]; break;
                    case 4: garage.CaddyAmountTotal = values[i]; break;
                    case 5: garage.VanAmountTotal = values[i]; break;
                    case 6: garage.BusAmountTotal = values[i]; break;
                    case 7: garage.TruckAmountTotal = values[i]; break;
                    case 8: garage.TruckWithTrailerAmountTotal = values[i]; break;
                    default: throw new AddGarageValuesOutOfRange();
                }
            }
            _garageRepository.AddGarage(garage);
        }

        public void SignUp() 
        {
            FormSignLog formSignUp = new FormSignLog(this, 0);
            formSignUp.ShowDialog();
        }
        public void AddUser(string inName, string inPassword) 
        {             
            try 
            {
                _userRepositroy.AddUser(inName, inPassword);
            }
            catch
            {
                throw;
            }
        }

        public void LogIn() 
        {
            FormSignLog formSignUp = new FormSignLog(this, 1);
            formSignUp.ShowDialog();
        }
        public void GetUser(string inName, string inPassword) 
        {
            try
            {
                User user = _userRepositroy.GetUser(inName, inPassword);
                _userRepositroy.CurrentUser = user;
            }
            catch
            {
                throw;
            }
        }

        public void LogOut() 
        {
            _userRepositroy.CurrentUser = null;
        }

        public void ChangeUsername() 
        {
            FormChangeUsername formChangeUsername = new FormChangeUsername(this);
            formChangeUsername.ShowDialog();
        }

        public void ChangeUsername(string inUsername) 
        {
            _userRepositroy.CurrentUser.Name = inUsername;
            _userRepositroy.CurrentUser = _userRepositroy.CurrentUser; // Because of NotifyObervers();
        }

        public void DeleteUser() 
        {            
            Garage garage;
            for (int i = 0; i < _garageRepository.Count(); i++)
            {
                garage = _garageRepository.GetByIndex(i);
                if (garage.Owner == _userRepositroy.CurrentUser.Name) _garageRepository.RemoveGarage(garage);
            }
            _userRepositroy.RemoveUser(_userRepositroy.CurrentUser);
            _userRepositroy.CurrentUser = null;            
        }

        public void ChangePassword() 
        {
            FormChangePassword formChangePassword = new FormChangePassword(this);
            formChangePassword.ShowDialog();
        }

        public void ChangePassword(string inPassword)
        {
            _userRepositroy.CurrentUser.PasswordHashed = inPassword;
        }

        public void DeleteGarage(int inIndex) 
        {
            Garage garage = _garageRepository.GetByIndex(inIndex);
            _garageRepository.RemoveGarage(garage);
        }

        public void OpenGarage(int inIndex) 
        {
            Garage garage = _garageRepository.GetByIndex(inIndex);
            ControllerGarageOpen controllerOpen = new ControllerGarageOpen(garage);
            if (_userRepositroy.CurrentUser == null || _userRepositroy.CurrentUser.Name != garage.Owner)
            {
                if (garage.Type == Types.Parking) 
                {
                    FormParkingOpen formParkingOpen = new FormParkingOpen(controllerOpen, false, garage);
                    formParkingOpen.ShowDialog();
                }
                else
                {
                    FormRentOpen formRentOpen = new FormRentOpen(controllerOpen, false, garage);
                    formRentOpen.ShowDialog();
                }
            }
            else
            {
                if (garage.Type == Types.Parking)
                {
                    FormParkingOpen formParkingOpen = new FormParkingOpen(controllerOpen, true, garage);
                    formParkingOpen.ShowDialog();
                }
                else
                {
                    FormRentOpen formRentOpen = new FormRentOpen(controllerOpen, true, garage);
                    formRentOpen.ShowDialog();
                }
            }
        }
    }
}
