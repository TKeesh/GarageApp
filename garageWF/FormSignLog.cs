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
    public partial class FormSignLog : Form
    {
        private static IController _controller;
        private byte signORlog;

        public FormSignLog(IController inController, byte type)
        {
            InitializeComponent();
            signORlog = type;
            _controller = inController;

            tbPassword.PasswordChar = '*';
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
            this.AcceptButton = buttonOK;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length < 1)
            {
                MessageBox.Show("Username must contain at least 1 character.");
                return;
            }
            if (tbPassword.Text.Length < 1) 
            {
                MessageBox.Show("Password must contain at least 1 character.");
                return;
            }

            if (signORlog == 0)
            {
                try 
                { 
                    _controller.AddUser(tbUsername.Text, tbPassword.Text);
                    this.Close();
                    MessageBox.Show("User " + tbUsername.Text + " successfully added. Now you can log in.");
                }
                catch (UserRepositoryContainsUser)
                {
                    MessageBox.Show("This Username already exists in repository.");
                }
            }
            else
            {
                try
                {
                    _controller.GetUser(tbUsername.Text, tbPassword.Text);
                    this.Close();
                    MessageBox.Show("Log in successful!");
                }
                catch (UserRepositoryDoesNotContainUser)
                {
                    MessageBox.Show("Wrong Username.");
                }
                catch (IncorrectPassword)
                {
                    MessageBox.Show("Wrong Password.");
                }
            }    
        }
    }
}
