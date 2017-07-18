using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using garageUtility;

namespace garageWF
{
    public partial class FormChangePassword : Form
    {
        private static IController _controller;

        public FormChangePassword(IController inController)
        {
            InitializeComponent();
            _controller = inController;

            tbNewPass1.PasswordChar = '*';
            tbNewPass2.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
            this.AcceptButton = buttonOK;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (tbNewPass1.Text.Length < 1) 
            {
                MessageBox.Show("Password must contain at least 1 character.");
                return;
            }
            if (tbNewPass1.Text != tbNewPass2.Text) 
            {
                MessageBox.Show("New Passwords do not match!");
                return;
            }
            _controller.ChangePassword(tbNewPass1.Text);
            this.Close();
            MessageBox.Show("Password successfully changed!");
        }
    }
}
