using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageModel
{
    public class Loan
    {
        private string vehicleType;        
        private DateTime timeStamp;
        private string comment;
        private string customerName;
        private string customerIDCardNo;
        
        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerIDCardNo
        {
            get { return customerIDCardNo; }
            set { customerIDCardNo = value; }
        }

        public Loan(string inType, DateTime inTimeStamp, string inCustomer, string inCustomerIDCardNo)
        {
            vehicleType = inType;
            timeStamp = inTimeStamp;
            customerName = inCustomer;
            customerIDCardNo = inCustomerIDCardNo;
        }
    }
}
