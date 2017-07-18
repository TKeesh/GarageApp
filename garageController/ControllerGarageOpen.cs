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
    public class ControllerGarageOpen : IControllerGarageOpen
    {
        private Garage garage;
        private readonly GarageRepository _garageRepository = GarageRepository.GetInstance();

        public ControllerGarageOpen(Garage inGarage)
        {
            garage = inGarage;
        }

        public void SetOpen(bool inOpen)
        {
            _garageRepository.SetOpen(garage, inOpen);
        }

        public void IncreaseUsed(string inVehicle) 
        {
            switch (inVehicle) 
            {
                case "Bicycle":
                    {
                        if (garage.BicycleAmountTotal == garage.BicycleAmountUsed) throw new GarageIsFull();
                        garage.BicycleAmountUsed++;
                        break;
                    }
                case "Moped":
                    {
                        if (garage.MopedAmountTotal == garage.MopedAmountUsed) throw new GarageIsFull();
                        garage.MopedAmountUsed++;
                        break;
                    }
                case "Motorcycle":
                    {
                        if (garage.MotorcycleAmountTotal == garage.MotorcycleAmountUsed) throw new GarageIsFull();
                        garage.MotorcycleAmountUsed++;
                        break;
                    }
                case "Car":
                    {
                        if (garage.CarAmountTotal == garage.CarAmountUsed) throw new GarageIsFull();
                        garage.CarAmountUsed++;
                        break;
                    }
                case "Caddy":
                    {
                        if (garage.CaddyAmountTotal == garage.CaddyAmountUsed) throw new GarageIsFull();
                        garage.CaddyAmountUsed++;
                        break;
                    }
                case "Van":
                    {
                        if (garage.VanAmountTotal == garage.VanAmountUsed) throw new GarageIsFull();
                        garage.VanAmountUsed++;
                        break;
                    }
                case "Bus":
                    {
                        if (garage.BusAmountTotal == garage.BusAmountUsed) throw new GarageIsFull();
                        garage.BusAmountUsed++;
                        break;
                    }
                case "Truck":
                    {
                        if (garage.TruckAmountTotal == garage.TruckAmountUsed) throw new GarageIsFull();
                        garage.TruckAmountUsed++;
                        break;
                    }
                case "Truck with trailer":
                    {
                        if (garage.TruckWithTrailerAmountTotal == garage.TruckWithTrailerAmountUsed) throw new GarageIsFull();
                        garage.TruckWithTrailerAmountUsed++;
                        break;
                    }
                default: throw new IndexVehicleOutOfRange();
            }
        }

        public void DecreaseUsed(string inVehicle)
        {
            switch (inVehicle)
            {
                case "Bicycle":
                    {
                        if (garage.BicycleAmountUsed == 0) throw new GarageIsEmpty();
                        garage.BicycleAmountUsed--;
                        break;
                    }
                case "Moped":
                    {
                        if (garage.MopedAmountUsed == 0) throw new GarageIsEmpty();
                        garage.MopedAmountUsed--;
                        break;
                    }
                case "Motorcycle":
                    {
                        if (garage.MotorcycleAmountUsed == 0) throw new GarageIsEmpty();
                        garage.MotorcycleAmountUsed--;
                        break;
                    }
                case "Car":
                    {
                        if (garage.CarAmountUsed == 0) throw new GarageIsEmpty();
                        garage.CarAmountUsed--;
                        break;
                    }
                case "Caddy":
                    {
                        if (garage.CaddyAmountUsed == 0) throw new GarageIsEmpty();
                        garage.CaddyAmountUsed--;
                        break;
                    }
                case "Van":
                    {
                        if (garage.VanAmountUsed == 0) throw new GarageIsEmpty();
                        garage.VanAmountUsed--;
                        break;
                    }
                case "Bus":
                    {
                        if (garage.BusAmountUsed == 0) throw new GarageIsEmpty();
                        garage.BusAmountUsed--;
                        break;
                    }
                case "Truck":
                    {
                        if (garage.TruckAmountUsed == 0) throw new GarageIsEmpty();
                        garage.TruckAmountUsed--;
                        break;
                    }
                case "Truck with trailer":
                    {
                        if (garage.TruckWithTrailerAmountUsed == 0) throw new GarageIsEmpty();
                        garage.TruckWithTrailerAmountUsed--;
                        break;
                    }
                default: throw new IndexVehicleOutOfRange();
            }
        }

        public void UpdateGarage(string inName, List<int> values) 
        {
            _garageRepository.UpdateName(garage, inName);
            for (int i = 0; i < values.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            if (values[i] < garage.BicycleAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.BicycleAmountTotal = values[i]; break;
                        }
                    case 1:
                        {
                            if (values[i] < garage.MopedAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.MopedAmountTotal = values[i]; break;
                        }
                    case 2:
                        {
                            if (values[i] < garage.MotorcycleAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.MotorcycleAmountTotal = values[i]; break;
                        }
                    case 3:
                        {
                            if (values[i] < garage.CarAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.CarAmountTotal = values[i]; break;
                        }
                    case 4:
                        {
                            if (values[i] < garage.CaddyAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.CaddyAmountTotal = values[i]; break;
                        }
                    case 5:
                        {
                            if (values[i] < garage.VanAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.VanAmountTotal = values[i]; break;
                        }
                    case 6:
                        {
                            if (values[i] < garage.BusAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.BusAmountTotal = values[i]; break;
                        }
                    case 7:
                        {
                            if (values[i] < garage.TruckAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.TruckAmountTotal = values[i]; break;
                        }
                    case 8:
                        {
                            if (values[i] < garage.TruckWithTrailerAmountUsed) throw new TotalAmountLowerThenUsed();
                            garage.TruckWithTrailerAmountTotal = values[i]; break;
                        }
                    default: throw new AddGarageValuesOutOfRange();
                }
            }
        }

        public void AddLoan(string vehicleType, DateTime inTimeStamp, string customerName, string customerIDCardNo, string comments) 
        {
            Loan loan = new Loan(vehicleType, inTimeStamp, customerName, customerIDCardNo);
            loan.Comment = comments;
            garage.AddLoan(loan);
        }

        public void RemoveLoan(int inIndex) 
        {
            garage.RemoveLoan(inIndex);
        }
    }
}
