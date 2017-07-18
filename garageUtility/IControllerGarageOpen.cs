using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageUtility
{
    public interface IControllerGarageOpen
    {
        void SetOpen(bool inOpen);
        void IncreaseUsed(string inVehicle);
        void DecreaseUsed(string inVehicle);
        void UpdateGarage(string inName, List<int> values);
        void AddLoan(string vehicleType, DateTime inTimeStamp, string customerName, string customerIDCardNo, string comments);
        void RemoveLoan(int inIndex);
    }
}
