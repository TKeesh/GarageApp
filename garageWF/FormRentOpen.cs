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
    public partial class FormRentOpen : Form
    {
        private static IControllerGarageOpen _controller;
        private bool owner;
        private readonly Garage garage;
        private readonly UserRepository _userRepository = UserRepository.GetInstance();

        public FormRentOpen(IControllerGarageOpen inController, bool inOwner, Garage inGarage)
        {
            InitializeComponent();
            _controller = inController;
            owner = inOwner;
            garage = inGarage;
            this.Height = 420;
            listViewLoan.View = View.Details;
            labelOwner.Text += garage.Owner;
            labelAddress.Text += garage.Address;
            labelOpenClosed.Font = new Font(labelOpenClosed.Font.FontFamily, 18);
            InitializeLabelsTotal();
            if (owner) InitializeOwnerButtons();
            UpdateOpenClosed();
            UpdateLabelsTotal();
            UpdateLabelsAvailable();
            UpdateComboBox();
        }

        private void UpdateComboBox() 
        {
            if (garage.BicycleAmountTotal - garage.BicycleAmountUsed > 0) cbVehicle.Items.Add("Bicycle");
            if (garage.MopedAmountTotal - garage.MopedAmountUsed > 0) cbVehicle.Items.Add("Moped");
            if (garage.MotorcycleAmountTotal - garage.MotorcycleAmountUsed > 0) cbVehicle.Items.Add("Motorcycle");
            if (garage.CarAmountTotal - garage.CarAmountUsed > 0) cbVehicle.Items.Add("Car");
            if (garage.CaddyAmountTotal - garage.CaddyAmountUsed > 0) cbVehicle.Items.Add("Caddy");
            if (garage.VanAmountTotal - garage.VanAmountUsed > 0) cbVehicle.Items.Add("Van");
            if (garage.BusAmountTotal - garage.BusAmountUsed > 0) cbVehicle.Items.Add("Bus");
            if (garage.TruckAmountTotal - garage.TruckAmountUsed > 0) cbVehicle.Items.Add("Truck");
            if (garage.TruckWithTrailerAmountTotal - garage.TruckWithTrailerAmountUsed > 0) cbVehicle.Items.Add("Truck with trailer");
            cbVehicle.SelectedIndex = -1;
        }

        private void InitializeOwnerButtons() 
        {
            this.Height = 680;
            gbLoan.Visible = true;
            buttonAddLoan.Enabled = true;
            buttonAddLoan.Visible = true;
            buttonRemoveLoan.Enabled = true;
            buttonRemoveLoan.Visible = true;
            listViewLoan.Enabled = true;
            listViewLoan.Visible = true;
            cbVehicle.Enabled = true;
            cbVehicle.Visible = true;
            foreach (TextBox tb in gbLoan.Controls.OfType<TextBox>())
            {
                tb.Enabled = true;
                tb.Visible = true;
            }
            foreach (Label tb in gbLoan.Controls.OfType<Label>())
            {
                tb.Enabled = true;
                tb.Visible = true;
            }
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
            UpdateList();
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

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            _controller.SetOpen(!garage.Open);
            UpdateOpenClosed();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            buttonDiscard.Enabled = true;
            ShowTextBoxes(true);
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
            UpdateComboBox();
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

        private void UpdateList() 
        {
            listViewLoan.Clear();
            listViewLoan.Columns.Add("Date&Time");
            listViewLoan.Columns.Add("Vehicle");
            listViewLoan.Columns.Add("Customer");
            listViewLoan.Columns.Add("ID card");
            listViewLoan.Columns.Add("Comment");
            
            Loan loan;
            for (int i = 0; i < garage.LoanCount(); i++) 
            {
                loan = garage.GetLoanByIndex(i);
                ListViewItem listViewItem = new ListViewItem(new[] 
                    { loan.TimeStamp.ToString(), loan.VehicleType, loan.CustomerName, loan.CustomerIDCardNo, loan.Comment });
                listViewLoan.Items.Add(listViewItem);
            }
        }

        private void buttonAddLoan_Click(object sender, EventArgs e)
        {
            if (cbVehicle.Text.Length < 1) 
            {
                MessageBox.Show("You must choose vehicle for the loan.");
                return;
            }
            if (tbCustomer.Text.Length < 1 && tbCardNo.Text.Length < 1)
            {
                MessageBox.Show("You must write Customer name or ID card number.");
                return;
            }
            string tmpComments, tmpCustomer, tmpCardNo;
            tmpComments = (tbComments.Text.Length < 0) ? "" : tbComments.Text;
            tmpCustomer = (tbCustomer.Text.Length < 0) ? "" : tbCustomer.Text;
            tmpCardNo = (tbCardNo.Text.Length < 0) ? "" : tbCardNo.Text;
            _controller.AddLoan(cbVehicle.Text, DateTime.Now, tmpCustomer, tmpCardNo, tmpComments);
            _controller.IncreaseUsed(cbVehicle.Text);
            UpdateLabelsAvailable();
            UpdateComboBox();
            UpdateList();
        }

        private void tbCardNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCardNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbCardNo.Text = tbCardNo.Text.Substring(0, tbCardNo.Text.Length - 1);
            }
        }

        private void buttonRemoveLoan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listViewLoan.SelectedIndices[0];                
                switch (MessageBox.Show("This vehicle is returned to garage?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        return;
                    default:
                        break;
                }
                Loan loan = garage.GetLoanByIndex(index);
                _controller.RemoveLoan(index);
                _controller.DecreaseUsed(loan.VehicleType);
                listViewLoan.SelectedIndices.Clear();
                UpdateLabelsAvailable();
                UpdateComboBox();
                UpdateList();
            }
            catch { }
        }
    }
}
