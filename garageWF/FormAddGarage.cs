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
    public partial class FormAddGarage : Form
    {
        private static IController _controller;
        private readonly UserRepository _userRepository = UserRepository.GetInstance();

        public FormAddGarage(IController inController)
        {
            _controller = inController;
            InitializeComponent();
            Initialize();
            labelUserData.Text = _userRepository.CurrentUser.Name;
            this.AcceptButton = buttonAdd;
        }

        private void Initialize() 
        {
            labelUser.Font = new Font(labelUser.Font.FontFamily, 12);
            labelUserData.Font = new Font(labelUserData.Font.FontFamily, 12);
            cbType.Items.Add("Parking");
            cbType.Items.Add("Rent");
        }

        #region TextBox_TextChanged
        private void tbBicycles_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBicycles.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbBicycles.Text = tbBicycles.Text.Substring(0, tbBicycles.Text.Length - 1);
            }
        }

        private void tbMopeds_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMopeds.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbMopeds.Text = tbMopeds.Text.Substring(0, tbMopeds.Text.Length - 1);
            }
        }

        private void tbMotorcycles_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMotorcycles.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbMotorcycles.Text = tbMotorcycles.Text.Substring(0, tbMotorcycles.Text.Length - 1);
            }
        }

        private void tbCars_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCars.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbCars.Text = tbCars.Text.Substring(0, tbCars.Text.Length - 1);
            }
        }

        private void tbCaddies_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCaddies.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbCaddies.Text = tbCaddies.Text.Substring(0, tbCaddies.Text.Length - 1);
            }
        }

        private void tbVans_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbVans.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbVans.Text = tbVans.Text.Substring(0, tbVans.Text.Length - 1);
            }
        }

        private void tbBuses_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBuses.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbBuses.Text = tbBuses.Text.Substring(0, tbBuses.Text.Length - 1);
            }
        }

        private void tbTrucks_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTrucks.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbTrucks.Text = tbTrucks.Text.Substring(0, tbTrucks.Text.Length - 1);
            }
        }

        private void tbTrucksWTrailor_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbTrucksWTrailor.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only whole and positive numbers.");
                tbTrucksWTrailor.Text = tbTrucksWTrailor.Text.Substring(0, tbTrucksWTrailor.Text.Length - 1);
            }
        }
        #endregion

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cbType.SelectedIndex = -1;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (TextBox tb in gbAmount.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
            values.Add((tbTrucksWTrailor.Text.Length > 0) ? Int32.Parse(tbTrucksWTrailor.Text) : 0);
            string user = _userRepository.CurrentUser.Name;
            try
            {
                _controller.AddGarage(user, tbAddress.Text, cbType.Text, tbGName.Text, values);
            }
            catch (GarageRepositoryContainsGarage) 
            {
                MessageBox.Show("Garage with specified address and type already exists!");
            }
            catch (GarageAddressNotSpecified)
            {
                MessageBox.Show("You must enter the address!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("You must specify garage type!");
            }
            this.Close();
        }
    }
}
