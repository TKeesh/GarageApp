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
    public class GarageTests
    {
        [Fact]
        public void Construct()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            Assert.Equal("tomi", garage.Owner);
            Assert.Equal("Construct", garage.Address);
            Assert.Equal(Types.Rent, garage.Type);
            Assert.Equal(null, garage.Name);
        }
        [Fact]
        public void SetName()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            garage.Name = "name";
            Assert.Equal("name", garage.Name);
        }
        [Fact]
        public void StructAmount()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            Assert.Equal(0, garage.MopedAmountTotal);
            Assert.Equal(0, garage.MopedAmountUsed);
        }
        [Fact]
        public void AddCountLoan()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            Loan loan = new Loan("Car", DateTime.Now, "tomi", "");
            garage.AddLoan(loan);
            Assert.Equal(1, garage.LoanCount());
        }
        [Fact]
        public void RemoveLoan()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            Loan loan = new Loan("Car", DateTime.Now, "tomi", "");
            garage.AddLoan(loan);
            garage.RemoveLoan(0);
            Assert.Equal(0, garage.LoanCount());
        }
        [Fact]
        public void GetLoanByIndex()
        {
            Garage garage = new Garage("tomi", "Construct", Types.Rent);
            Loan loan = new Loan("Car", DateTime.Now, "tomi", "");
            garage.AddLoan(loan);
            Assert.Equal(loan, garage.GetLoanByIndex(0));
        }
    }
}
