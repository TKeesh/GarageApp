using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using garageUtility;

namespace garageModel
{
    public class GarageRepository : Subject
    {
        private static GarageRepository _instance = null;
        private List<Garage> _listGarages = new List<Garage>();

        private GarageRepository() 
        {
        }

        public void LoadGarageRepositoryFromDataBase()
        {
            try
            {
                string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                StreamReader sr = new StreamReader(filePath + "\\data\\DatabaseGarageRepository.txt");
                String line;
                while ((line = sr.ReadLine()) != null) 
                { 
                    string[] tokens = line.Split('\t');
                    Types inType = (Types)Enum.Parse(typeof(Types), tokens[2]);
                    Garage garage = new Garage(tokens[0], tokens[1], inType);
                    if (tokens[3] != "#") garage.Name = tokens[3];
                    else garage.Name = "";
                    garage.Open = false;
                    garage.BicycleAmountTotal = Int32.Parse(tokens[4]);
                    garage.MopedAmountTotal = Int32.Parse(tokens[5]);
                    garage.MotorcycleAmountTotal = Int32.Parse(tokens[6]);
                    garage.CarAmountTotal = Int32.Parse(tokens[7]);
                    garage.CaddyAmountTotal = Int32.Parse(tokens[8]);
                    garage.VanAmountTotal = Int32.Parse(tokens[9]);
                    garage.BusAmountTotal = Int32.Parse(tokens[10]);
                    garage.TruckAmountTotal = Int32.Parse(tokens[11]);
                    garage.TruckWithTrailerAmountTotal = Int32.Parse(tokens[12]);
                    AddGarage(garage);
                }
                sr.Close();
            }
            catch
            {
                throw new DatabaseDoesNotExists();
            }
        }

        public void SaveGarageRepositoryToDatabase() 
        {
            try
            {
                string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                filePath += "\\data\\DatabaseGarageRepository.txt";
                File.WriteAllText(filePath, string.Empty);
                StreamWriter sr = new StreamWriter(filePath);
                
                String line;
                foreach (Garage garage in _listGarages) 
                {
                    line = "";
                    line += garage.Owner + "\t";
                    line += garage.Address + "\t";
                    line += garage.Type.ToString() + "\t";
                    if (garage.Name.Length < 1) line += "#" + "\t";
                    else line += garage.Name + "\t";
                    line += garage.BicycleAmountTotal.ToString() + "\t";
                    line += garage.MopedAmountTotal.ToString() + "\t";
                    line += garage.MotorcycleAmountTotal.ToString() + "\t";
                    line += garage.CarAmountTotal.ToString() + "\t";
                    line += garage.CaddyAmountTotal.ToString() + "\t";
                    line += garage.VanAmountTotal.ToString() + "\t";
                    line += garage.BusAmountTotal.ToString() + "\t";
                    line += garage.TruckAmountTotal.ToString() + "\t";
                    line += garage.TruckWithTrailerAmountTotal.ToString() + "\t";
                    sr.WriteLine(line);
                }
                sr.Close();
            }
            catch
            {
                throw new DatabaseDoesNotExists();
            }
        }

        public static GarageRepository GetInstance()
        {
            if (_instance == null) _instance = new GarageRepository();

            return _instance;
        }

        public Garage GetByIndex(int index) 
        {
            if (index > _listGarages.Count) throw new GarageRepositoryIndexOutOfRange();
            return _listGarages[index];
        }


        public int Count()
        {
            return _listGarages.Count;
        }

        public bool Contains(Garage inGarage)
        {
            for (int i = 0; i < _listGarages.Count; i++) 
            {
                if (inGarage.Address == _listGarages[i].Address && inGarage.Type == _listGarages[i].Type) return true;
            }
            return false;
        }

        public void AddGarage(Garage inGarage)
        {
            if (Contains(inGarage)) throw new GarageRepositoryContainsGarage();
            _listGarages.Add(inGarage);
            NotifyObservers();
        }

        public void RemoveGarage(Garage inGarage) 
        {
            if (!Contains(inGarage)) throw new GarageRepositoryDoesNotContainGarage();
            _listGarages.Remove(inGarage);
            NotifyObservers();
        }

        public void SetOpen(Garage garage, bool inOpen) 
        {
            garage.Open = inOpen;
            NotifyObservers();
        }
        public void UpdateName(Garage garage, string inName)
        {
            garage.Name = inName;
            NotifyObservers();
        }
    }
}
