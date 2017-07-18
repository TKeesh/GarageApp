using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using garageModel;
using garageController;
using Xunit;
using garageUtility;

namespace garageTests
{
    public class LoanTests
    {
        [Fact]
        public void Construct()
        {
            DateTime stamp = DateTime.Now;
            Loan loan = new Loan("Car", stamp, "tomi", "");
            Assert.Equal("Car", loan.VehicleType);
            Assert.Equal(stamp, loan.TimeStamp);
            Assert.Equal("tomi", loan.CustomerName);
            Assert.Equal("", loan.CustomerIDCardNo);
            loan = new Loan("Car", stamp, "tomi", "456346");
            Assert.Equal("456346", loan.CustomerIDCardNo);
        }
        [Fact]
        public void SetComment()
        {
            DateTime stamp = DateTime.Now;
            Loan loan = new Loan("Car", stamp, "tomi", "");
            loan.Comment = "SetComment sscom451 sd_ sad";
            Assert.Equal("SetComment sscom451 sd_ sad", loan.Comment);
        }
    }
}
