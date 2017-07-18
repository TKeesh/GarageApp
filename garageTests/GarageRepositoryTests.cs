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
    public class GarageRepositoryTests
    {
        [Fact]
        public void Contains()
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "Contains", Types.Rent);
            garageRepository.AddGarage(garage);
            Assert.Equal(true, garageRepository.Contains(garage));
            garageRepository.RemoveGarage(garage);
            Assert.Equal(false, garageRepository.Contains(garage));
        }
        [Fact]
        public void AddGarage() 
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "AddGarage", Types.Rent);
            garageRepository.AddGarage(garage);
            Assert.Equal(true, garageRepository.Contains(garage));
            garageRepository.RemoveGarage(garage);
        }
        [Fact]
        public void RemoveGarage() 
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "RemoveGarage", Types.Rent);
            garageRepository.AddGarage(garage);
            garageRepository.RemoveGarage(garage);
            Assert.Equal(false, garageRepository.Contains(garage));        
        }
        [Fact]
        public void SetOpen()
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "SetOpen", Types.Rent);
            garageRepository.AddGarage(garage);
            garageRepository.SetOpen(garage, true);
            garage = garageRepository.GetByIndex(0);
            Assert.Equal(true, garage.Open);
            garageRepository.RemoveGarage(garage);
        }
        [Fact]
        public void Count()
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "Count", Types.Rent);
            garageRepository.AddGarage(garage);
            Assert.Equal(1, garageRepository.Count());
            garageRepository.RemoveGarage(garage);
        }
        [Fact]
        public void GetByIndex()
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "GetByIndex", Types.Rent);
            garageRepository.AddGarage(garage);
            garage = garageRepository.GetByIndex(0);
            Assert.Equal("GetByIndex", garage.Address);
            garageRepository.RemoveGarage(garage);
        }
        [Fact]
        public void UpdateName()
        {
            GarageRepository garageRepository = GarageRepository.GetInstance();
            Garage garage = new Garage("tomi", "Count", Types.Rent);
            garageRepository.AddGarage(garage);
            garageRepository.UpdateName(garage, "newname");
            garage = garageRepository.GetByIndex(0);
            Assert.Equal("newname", garage.Name);
            garageRepository.RemoveGarage(garage);
        }
    }
}
