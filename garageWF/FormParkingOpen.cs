using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using garageUtility;
using garageModel;

namespace garageWF
{
    public partial class FormParkingOpen : Form
    {
        private static IControllerGarageOpen _controller;
        private bool owner;
        private readonly Garage garage;
        private readonly UserRepository _userRepository = UserRepository.GetInstance();

        public FormParkingOpen(IControllerGarageOpen inController, bool inOwner, Garage inGarage)
        {
            InitializeComponent();
            _controller = inController;
            owner = inOwner;
            garage = inGarage;

            labelOwner.Text += garage.Owner;
            labelAddress.Text += garage.Address;
            labelOpenClosed.Font = new Font(labelOpenClosed.Font.FontFamily, 18);
            InitializeLabelsTotal();
            if (owner) InitializeOwnerButtons();
            UpdateOpenClosed();            
            UpdateLabelsTotal();
            UpdateLabelsAvailable();                        
        }

        private void InitializeOwnerButtons() 
        {
            buttonOpenClose.Enabled = true;
            buttonOpenClose.Visible = true;
            buttonEdit.Enabled = true;
            buttonEdit.Visible = true;
            buttonSave.Visible = true;
            buttonDiscard.Visible = true;
            foreach (Button but in gbAvailable.Controls.OfType<Button>())
            {
                but.Enabled = true;
                but.Visible = true;
            }
        }

        private void InitializeLabelsTotal()
        {                        
            labelName.Text = "Name: ";
            labelBicycles.Text = "Bicycles: ";
            labelMopeds.Text = "Mopeds: ";
            labelMotorcycles.Text = "Motorcycles: ";
            labelCars.Text = "Cars: ";
            labelCaddies.Text = "Caddies: ";
            labelVans.Text = "Vans: ";
            labelBuses.Text = "Buses: ";
            labelTrucks.Text = "Trucks: ";
            labelTrucksWTrailer.Text = "Trucks with trailer: ";
        }

        private void UpdateOpenClosed() 
        {
            if (garage.Open)
            {
                labelOpenClosed.ForeColor = System.Drawing.Color.Green;
                labelOpenClosed.Text = "OPEN";
            }
            else
            {
                labelOpenClosed.ForeColor = System.Drawing.Color.Red;
                labelOpenClosed.Text = "CLOSED";
            }
        }

        private void UpdateLabelsTotal() 
        {
            labelName.Text += garage.Name;
            labelBicycles.Text += garage.BicycleAmountTotal.ToString();
            labelMopeds.Text += garage.MopedAmountTotal.ToString();
            labelMotorcycles.Text += garage.MotorcycleAmountTotal.ToString();
            labelCars.Text += garage.CarAmountTotal.ToString();
            labelCaddies.Text += garage.CaddyAmountTotal.ToString();
            labelVans.Text += garage.VanAmountTotal.ToString();
            labelBuses.Text += garage.BusAmountTotal.ToString();
            labelTrucks.Text += garage.TruckAmountTotal.ToString();
            labelTrucksWTrailer.Text += garage.TruckWithTrailerAmountTotal.ToString();
        }
        private void UpdateLabelsAvailable()
        {
            labelBicyclesAv.Text = "Bicycles: " + (garage.BicycleAmountTotal - garage.BicycleAmountUsed).ToString();
            labelMopedsAv.Text = "Mopeds: " + (garage.MopedAmountTotal - garage.MopedAmountUsed).ToString();
            labelMotorcyclesAv.Text = "Motorcycles: " + (garage.MotorcycleAmountTotal - garage.MotorcycleAmountUsed).ToString();
            labelCarsAv.Text = "Cars: " + (garage.CarAmountTotal - garage.CarAmountUsed).ToString();
            labelCaddiesAv.Text = "Caddies: " + (garage.CaddyAmountTotal - garage.CaddyAmountUsed).ToString();
            labelVansAv.Text = "Vans: " + (garage.VanAmountTotal - garage.VanAmountUsed).ToString();
            labelBusesAv.Text = "Buses: " + (garage.BusAmountTotal - garage.BusAmountUsed).ToString();
            labelTrucksAv.Text = "Trucks: " + (garage.TruckAmountTotal - garage.TruckAmountUsed).ToString();
            labelTrucksWTrailerAv.Text = "Trucks with trailer: " + (garage.TruckWithTrailerAmountTotal - garage.TruckWithTrailerAmountUsed).ToString();
        }
        
        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            _controller.SetOpen(!garage.Open);            
            UpdateOpenClosed();
        }

        #region +/- buttons
        private void bBicM_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Bicycle");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Bicycle");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Moped");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Moped");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Motorcycle");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Motorcycle");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Car");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Car");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Caddy");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Caddy");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Van");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Van");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Bus");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Bus");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Truck");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Truck");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.IncreaseUsed("Truck with trailer");
                UpdateLabelsAvailable();
            }
            catch (GarageIsFull) { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.DecreaseUsed("Truck with trailer");
                UpdateLabelsAvailable();
            }
            catch (GarageIsEmpty) { }
        }
        #endregion

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            buttonDiscard.Enabled = true;
            ShowTextBoxes(true);
        }

        private void ShowTextBoxes(bool inState) 
        {
            InitializeLabelsTotal();
            tbGName.Text = garage.Name;
            tbGName.Enabled = inState;
            tbGName.Visible = inState;
            foreach (TextBox tb in gbTotal.Controls.OfType<TextBox>())
            {
                tb.Enabled = inState;
                tb.Visible = inState;
            }
            tbBicycles.Text = garage.BicycleAmountTotal.ToString();
            tbMopeds.Text = garage.MopedAmountTotal.ToString();
            tbMotorcycles.Text = garage.MotorcycleAmountTotal.ToString();
            tbCars.Text = garage.CarAmountTotal.ToString();
            tbCaddies.Text = garage.CaddyAmountTotal.ToString();
            tbVans.Text = garage.VanAmountTotal.ToString();
            tbBuses.Text = garage.BusAmountTotal.ToString();
            tbTrucks.Text = garage.TruckAmountTotal.ToString();
            tbTrucksWTrailer.Text = garage.TruckWithTrailerAmountTotal.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>();
            values.Add((tbBicycles.Text.Length > 0) ? Int32.Parse(tbBicycles.Text) : 0);
            values.Add((tbMopeds.Text.Length > 0) ? Int32.Parse(tbMopeds.Text) : 0);
            values.Add((tbMotorcycles.Text.Length > 0) ? Int32.Parse(tbMotorcycles.Text) : 0);
            values.Add((tbCars.Text.Length > 0) ? Int32.Parse(tbCars.Text) : 0);
            values.Add((tbCaddies.Text.Length > 0) ? Int32.Parse(tbCaddies.Text) : 0);
            values.Add((tbVans.Text.Length > 0) ? Int32.Parse(tbVans.Text) : 0);
            values.Add((tbBuses.Text.Length > 0) ? Int32.Parse(tbBuses.Text) : 0);
            values.Add((tbTrucks.Text.Length > 0) ? Int32.Parse(tbTrucks.Text) : 0);
            values.Add((tbTrucksWTrailer.Text.Length > 0) ? Int32.Parse(tbTrucksWTrailer.Text) : 0);
            try
            {
                _controller.UpdateGarage(tbGName.Text, values);
            }
            catch (TotalAmountLowerThenUsed)
            {
                MessageBox.Show("Some of new total values are lesser then currently used.\n" + 
                                "New maximum total amount is equal to (Total-Available).");
            }
            ShowTextBoxes(false);
            UpdateLabelsTotal();
            UpdateLabelsAvailable();
            buttonSave.Enabled = false;
            buttonDiscard.Enabled = false;
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            ShowTextBoxes(false);
            UpdateLabelsTotal();
            buttonSave.Enabled = false;
            buttonDiscard.Enabled = false;
        }
    }
}
