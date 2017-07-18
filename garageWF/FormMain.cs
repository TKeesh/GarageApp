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
    public partial class FormMain : Form, IObserver
    {
        private static IController _controller;
        private readonly GarageRepository _garageRepository = GarageRepository.GetInstance();
        private readonly UserRepository _userRepository = UserRepository.GetInstance();

        public FormMain(IController inController)
        {
            _controller = inController;
            _garageRepository.Attach(this);
            _userRepository.Attach(this);
            InitializeComponent();
            this.FormClosing += FormMain_FormClosing;
            labelUser.Font = new Font(labelUser.Font.FontFamily, 12);
            labelUserData.Font = new Font(labelUserData.Font.FontFamily, 12);
            ListViewMain.View = View.Details;
            InitializeButtons();            

            try
            {
                _garageRepository.LoadGarageRepositoryFromDataBase();
                _userRepository.LoadGarageRepositoryFromDataBase();
            }
            catch (DatabaseDoesNotExists)
            {
                MessageBox.Show("Database file does not exists!");
            }
            
            UpdateList();
        }

        private void InitializeButtons() 
        {            
            labelUserData.Text = "";

            bAddGarage.Enabled = false;
            bDeleteGarage.Enabled = false;
            buttonChangePass.Enabled = false; //buttonChangePass.Visible = false;
            buttonChangeUsern.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonLogOut.Enabled = false;
        }

        private void UpdateUser() 
        {
            if (_userRepository.CurrentUser != null)
            {
                labelUserData.Text = _userRepository.CurrentUser.Name;
                bAddGarage.Enabled = true;
                bDeleteGarage.Enabled = true;
                buttonChangePass.Enabled = true;
                buttonChangeUsern.Enabled = true;
                buttonDeleteUser.Enabled = true;
                buttonLogOut.Enabled = true;
            }
            else InitializeButtons();      
        }

        private void UpdateList()
        {
            ListViewMain.Clear();
            ListViewMain.Columns.Add("Name");
            ListViewMain.Columns.Add("Address");
            ListViewMain.Columns.Add("Type");
            ListViewMain.Columns.Add("Open/Closed");

            Garage garage;
            for (int i = 0; i < _garageRepository.Count(); i++) 
            {
                garage = _garageRepository.GetByIndex(i);
                string tmp;
                if (garage.Open) tmp = "OPEN";
                else tmp = "CLOSED";
                ListViewItem listViewItem = new ListViewItem(new[] { garage.Name, garage.Address, garage.Type.ToString(), tmp });
                if (_userRepository.CurrentUser != null)
                {
                    if (_userRepository.CurrentUser.Name == garage.Owner) listViewItem.Font = new Font(listViewItem.Font, FontStyle.Bold);
                }
                ListViewMain.Items.Add(listViewItem);
            }
        }

        private void bAddGarage_Click(object sender, EventArgs e)
        {
            if (_userRepository.CurrentUser == null)
            {
                MessageBox.Show("You must logged in to add new garage.");
                return;
            }
            _controller.AddGarage();
        }

        private void FormMain_FormClosing(Object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Are you sure?", "Do you still want ... ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
            _garageRepository.Detach(this);
            _userRepository.Detach(this);
            _garageRepository.SaveGarageRepositoryToDatabase();
            _userRepository.SaveUserRepositoryToDatabase();
        }

        public void UpdateView()
        {
            UpdateList();
            UpdateUser();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            _controller.SignUp();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            _controller.LogIn();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            _controller.LogOut();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {            
            _controller.ChangePassword();
        }

        private void buttonChangeUsern_Click(object sender, EventArgs e)
        {
            _controller.ChangeUsername();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("After deleting \"" + _userRepository.CurrentUser.Name +
                "\" user all associated garages will be deleted!\n" + "Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.No:
                    return;
                default:
                    break;
            }
            _controller.DeleteUser();
        }

        private void bOpenGarage_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ListViewMain.SelectedIndices[0];
                ListViewMain.SelectedIndices.Clear();                
                _controller.OpenGarage(index);
            }
            catch
            {
            }
        }

        private void bDeleteGarage_Click(object sender, EventArgs e)
        {
            try
            {               
                int index = ListViewMain.SelectedIndices[0];
                ListViewMain.SelectedIndices.Clear();
                switch (MessageBox.Show("This can not be undone!\n" + "Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.No:
                        return;
                    default:
                        break;
                }
                _controller.DeleteGarage(index);
            }
            catch 
            {                
            }
        }
    }
}
