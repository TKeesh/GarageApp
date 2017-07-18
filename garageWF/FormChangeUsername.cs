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
    public partial class FormChangeUsername : Form
    {
        private static IController _controller;

        public FormChangeUsername(IController inController)
        {
            InitializeComponent();
            _controller = inController;
            this.AcceptButton = buttonOK;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (tbNewUsern1.Text.Length < 1) 
            {
                MessageBox.Show("Username must contain at least 1 character.");
                return;
            }
            if (tbNewUsern1.Text != tbNewUsern2.Text) 
            {
                MessageBox.Show("New Usernames do not match.");
                return;
            }
            _controller.ChangeUsername(tbNewUsern1.Text);
            this.Close();
            MessageBox.Show("Username changed to: " + tbNewUsern1.Text);
        }
    }
}
