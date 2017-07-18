namespace garageWF
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListViewMain = new System.Windows.Forms.ListView();
            this.bAddGarage = new System.Windows.Forms.Button();
            this.bDeleteGarage = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserData = new System.Windows.Forms.Label();
            this.buttonChangeUsern = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.bOpenGarage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewMain
            // 
            this.ListViewMain.FullRowSelect = true;
            this.ListViewMain.Location = new System.Drawing.Point(12, 111);
            this.ListViewMain.MultiSelect = false;
            this.ListViewMain.Name = "ListViewMain";
            this.ListViewMain.Size = new System.Drawing.Size(353, 285);
            this.ListViewMain.TabIndex = 0;
            this.ListViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // bAddGarage
            // 
            this.bAddGarage.Location = new System.Drawing.Point(371, 111);
            this.bAddGarage.Name = "bAddGarage";
            this.bAddGarage.Size = new System.Drawing.Size(76, 52);
            this.bAddGarage.TabIndex = 1;
            this.bAddGarage.Text = "Add garage";
            this.bAddGarage.UseVisualStyleBackColor = true;
            this.bAddGarage.Click += new System.EventHandler(this.bAddGarage_Click);
            // 
            // bDeleteGarage
            // 
            this.bDeleteGarage.Location = new System.Drawing.Point(371, 169);
            this.bDeleteGarage.Name = "bDeleteGarage";
            this.bDeleteGarage.Size = new System.Drawing.Size(76, 42);
            this.bDeleteGarage.TabIndex = 2;
            this.bDeleteGarage.Text = "Delete garage";
            this.bDeleteGarage.UseVisualStyleBackColor = true;
            this.bDeleteGarage.Click += new System.EventHandler(this.bDeleteGarage_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(289, 12);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(76, 27);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(371, 12);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(76, 27);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(256, 78);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(109, 27);
            this.buttonChangePass.TabIndex = 5;
            this.buttonChangePass.Text = "Change Password";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(371, 45);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(76, 27);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "User: ";
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Location = new System.Drawing.Point(55, 13);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(34, 13);
            this.labelUserData.TabIndex = 8;
            this.labelUserData.Text = "ToDo";
            // 
            // buttonChangeUsern
            // 
            this.buttonChangeUsern.Location = new System.Drawing.Point(257, 45);
            this.buttonChangeUsern.Name = "buttonChangeUsern";
            this.buttonChangeUsern.Size = new System.Drawing.Size(108, 27);
            this.buttonChangeUsern.TabIndex = 9;
            this.buttonChangeUsern.Text = "Change Username";
            this.buttonChangeUsern.UseVisualStyleBackColor = true;
            this.buttonChangeUsern.Click += new System.EventHandler(this.buttonChangeUsern_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(371, 78);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(76, 21);
            this.buttonDeleteUser.TabIndex = 10;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // bOpenGarage
            // 
            this.bOpenGarage.Location = new System.Drawing.Point(12, 53);
            this.bOpenGarage.Name = "bOpenGarage";
            this.bOpenGarage.Size = new System.Drawing.Size(76, 52);
            this.bOpenGarage.TabIndex = 11;
            this.bOpenGarage.Text = "Open garage";
            this.bOpenGarage.UseVisualStyleBackColor = true;
            this.bOpenGarage.Click += new System.EventHandler(this.bOpenGarage_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 408);
            this.Controls.Add(this.bOpenGarage);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonChangeUsern);
            this.Controls.Add(this.labelUserData);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.bDeleteGarage);
            this.Controls.Add(this.bAddGarage);
            this.Controls.Add(this.ListViewMain);
            this.Name = "FormMain";
            this.Text = "Garage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewMain;
        private System.Windows.Forms.Button bAddGarage;
        private System.Windows.Forms.Button bDeleteGarage;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.Button buttonChangeUsern;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button bOpenGarage;

    }
}

