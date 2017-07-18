using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageModel
{
    public enum Types 
    {
        Rent, Parking
    }

    public struct Amount
    {
        public int total, used;
        public Amount(int t, int u) 
        {
            total = t;
            used = u;
        }
    }

    public class Garage
    {
        private List<Loan> listLoan = new List<Loan>();
        private string owner;
        private string address;
        private Types type;
        private string name;
        private bool open;
        private Amount bicycleAmount;
        private Amount mopedAmount;
        private Amount motorcycleAmount;
        private Amount carAmount;
        private Amount caddyAmount;
        private Amount vanAmount;
        private Amount busAmount;
        private Amount truckAmount;
        private Amount truckWithTrailerAmount;

        #region Properties
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Types Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool Open
        {
            get { return open; }
            set { open = value; }
        }
        public int BicycleAmountTotal
        {
            get { return bicycleAmount.total; }
            set { bicycleAmount.total = value; }
        }
        public int BicycleAmountUsed
        {
            get { return bicycleAmount.used; }
            set { bicycleAmount.used = value; }
        }
        public int MopedAmountTotal
        {
            get { return mopedAmount.total; }
            set { mopedAmount.total = value; }
        }
        public int MopedAmountUsed
        {
            get { return mopedAmount.used; }
            set { mopedAmount.used = value; }
        }
        public int MotorcycleAmountTotal
        {
            get { return motorcycleAmount.total; }
            set { motorcycleAmount.total = value; }
        }
        public int MotorcycleAmountUsed
        {
            get { return motorcycleAmount.used; }
            set { motorcycleAmount.used = value; }
        }
        public int CarAmountTotal
        {
            get { return carAmount.total; }
            set { carAmount.total = value; }
        }
        public int CarAmountUsed
        {
            get { return carAmount.used; }
            set { carAmount.used = value; }
        }
        public int CaddyAmountTotal
        {
            get { return caddyAmount.total; }
            set { caddyAmount.total = value; }
        }
        public int CaddyAmountUsed
        {
            get { return caddyAmount.used; }
            set { caddyAmount.used = value; }
        }
        public int VanAmountTotal
        {
            get { return vanAmount.total; }
            set { vanAmount.total = value; }
        }
        public int VanAmountUsed
        {
            get { return vanAmount.used; }
            set { vanAmount.used = value; }
        }
        public int BusAmountTotal
        {
            get { return busAmount.total; }
            set { busAmount.total = value; }
        }
        public int BusAmountUsed
        {
            get { return busAmount.used; }
            set { busAmount.used = value; }
        }
        public int TruckAmountTotal
        {
            get { return truckAmount.total; }
            set { truckAmount.total = value; }
        }
        public int TruckAmountUsed
        {
            get { return truckAmount.used; }
            set { truckAmount.used = value; }
        }
        public int TruckWithTrailerAmountTotal
        {
            get { return truckWithTrailerAmount.total; }
            set { truckWithTrailerAmount.total = value; }
        }
        public int TruckWithTrailerAmountUsed
        {
            get { return truckWithTrailerAmount.used; }
            set { truckWithTrailerAmount.used = value; }
        }
        #endregion               

        public Garage(string inOwner, string inAddress, Types inType) 
        {
            if (inAddress.Length < 1) throw new GarageAddressNotSpecified();
            Owner = inOwner;
            Address = inAddress;
            Type = inType;
        } 

        public void AddLoan(Loan loan)
        {
            listLoan.Add(loan);
        }

        public Loan GetLoanByIndex(int inIndex)
        {
            return listLoan[inIndex];
        }

        public int LoanCount()
        {
            return listLoan.Count;
        }

        public void RemoveLoan(int inIndex)
        {
            Loan loan = GetLoanByIndex(inIndex);
            listLoan.Remove(loan);
        }
    }
}
