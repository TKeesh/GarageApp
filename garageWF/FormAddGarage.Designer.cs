namespace garageWF
{
    partial class FormAddGarage
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserData = new System.Windows.Forms.Label();
            this.labelGName = new System.Windows.Forms.Label();
            this.labelGAddress = new System.Windows.Forms.Label();
            this.labelGType = new System.Windows.Forms.Label();
            this.labelBicycles = new System.Windows.Forms.Label();
            this.labelMopeds = new System.Windows.Forms.Label();
            this.labelMotorcycles = new System.Windows.Forms.Label();
            this.labelCars = new System.Windows.Forms.Label();
            this.labelCaddies = new System.Windows.Forms.Label();
            this.labelVans = new System.Windows.Forms.Label();
            this.labelBuses = new System.Windows.Forms.Label();
            this.labelTrucks = new System.Windows.Forms.Label();
            this.labelTrucksWTrailer = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbGName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbBicycles = new System.Windows.Forms.TextBox();
            this.tbCars = new System.Windows.Forms.TextBox();
            this.tbMotorcycles = new System.Windows.Forms.TextBox();
            this.tbMopeds = new System.Windows.Forms.TextBox();
            this.tbCaddies = new System.Windows.Forms.TextBox();
            this.tbVans = new System.Windows.Forms.TextBox();
            this.tbBuses = new System.Windows.Forms.TextBox();
            this.tbTrucks = new System.Windows.Forms.TextBox();
            this.tbTrucksWTrailor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.gbAmount = new System.Windows.Forms.GroupBox();
            this.gbAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(168, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User: ";
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Location = new System.Drawing.Point(218, 9);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(34, 13);
            this.labelUserData.TabIndex = 1;
            this.labelUserData.Text = "ToDo";
            // 
            // labelGName
            // 
            this.labelGName.AutoSize = true;
            this.labelGName.Location = new System.Drawing.Point(21, 42);
            this.labelGName.Name = "labelGName";
            this.labelGName.Size = new System.Drawing.Size(77, 13);
            this.labelGName.TabIndex = 2;
            this.labelGName.Text = "Garage name: ";
            // 
            // labelGAddress
            // 
            this.labelGAddress.AutoSize = true;
            this.labelGAddress.Location = new System.Drawing.Point(47, 69);
            this.labelGAddress.Name = "labelGAddress";
            this.labelGAddress.Size = new System.Drawing.Size(51, 13);
            this.labelGAddress.TabIndex = 3;
            this.labelGAddress.Text = "Address: ";
            // 
            // labelGType
            // 
            this.labelGType.AutoSize = true;
            this.labelGType.Location = new System.Drawing.Point(61, 95);
            this.labelGType.Name = "labelGType";
            this.labelGType.Size = new System.Drawing.Size(37, 13);
            this.labelGType.TabIndex = 4;
            this.labelGType.Text = "Type: ";
            // 
            // labelBicycles
            // 
            this.labelBicycles.AutoSize = true;
            this.labelBicycles.Location = new System.Drawing.Point(51, 27);
            this.labelBicycles.Name = "labelBicycles";
            this.labelBicycles.Size = new System.Drawing.Size(52, 13);
            this.labelBicycles.TabIndex = 5;
            this.labelBicycles.Text = "Bicycles: ";
            // 
            // labelMopeds
            // 
            this.labelMopeds.AutoSize = true;
            this.labelMopeds.Location = new System.Drawing.Point(52, 53);
            this.labelMopeds.Name = "labelMopeds";
            this.labelMopeds.Size = new System.Drawing.Size(51, 13);
            this.labelMopeds.TabIndex = 6;
            this.labelMopeds.Text = "Mopeds: ";
            // 
            // labelMotorcycles
            // 
            this.labelMotorcycles.AutoSize = true;
            this.labelMotorcycles.Location = new System.Drawing.Point(33, 79);
            this.labelMotorcycles.Name = "labelMotorcycles";
            this.labelMotorcycles.Size = new System.Drawing.Size(70, 13);
            this.labelMotorcycles.TabIndex = 7;
            this.labelMotorcycles.Text = "Motorcycles: ";
            // 
            // labelCars
            // 
            this.labelCars.AutoSize = true;
            this.labelCars.Location = new System.Drawing.Point(69, 105);
            this.labelCars.Name = "labelCars";
            this.labelCars.Size = new System.Drawing.Size(34, 13);
            this.labelCars.TabIndex = 8;
            this.labelCars.Text = "Cars: ";
            // 
            // labelCaddies
            // 
            this.labelCaddies.AutoSize = true;
            this.labelCaddies.Location = new System.Drawing.Point(52, 131);
            this.labelCaddies.Name = "labelCaddies";
            this.labelCaddies.Size = new System.Drawing.Size(51, 13);
            this.labelCaddies.TabIndex = 9;
            this.labelCaddies.Text = "Caddies: ";
            // 
            // labelVans
            // 
            this.labelVans.AutoSize = true;
            this.labelVans.Location = new System.Drawing.Point(66, 157);
            this.labelVans.Name = "labelVans";
            this.labelVans.Size = new System.Drawing.Size(37, 13);
            this.labelVans.TabIndex = 10;
            this.labelVans.Text = "Vans: ";
            // 
            // labelBuses
            // 
            this.labelBuses.AutoSize = true;
            this.labelBuses.Location = new System.Drawing.Point(61, 183);
            this.labelBuses.Name = "labelBuses";
            this.labelBuses.Size = new System.Drawing.Size(42, 13);
            this.labelBuses.TabIndex = 11;
            this.labelBuses.Text = "Buses: ";
            // 
            // labelTrucks
            // 
            this.labelTrucks.AutoSize = true;
            this.labelTrucks.Location = new System.Drawing.Point(57, 209);
            this.labelTrucks.Name = "labelTrucks";
            this.labelTrucks.Size = new System.Drawing.Size(46, 13);
            this.labelTrucks.TabIndex = 12;
            this.labelTrucks.Text = "Trucks: ";
            // 
            // labelTrucksWTrailer
            // 
            this.labelTrucksWTrailer.AutoSize = true;
            this.labelTrucksWTrailer.Location = new System.Drawing.Point(7, 235);
            this.labelTrucksWTrailer.Name = "labelTrucksWTrailer";
            this.labelTrucksWTrailer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTrucksWTrailer.Size = new System.Drawing.Size(96, 13);
            this.labelTrucksWTrailer.TabIndex = 13;
            this.labelTrucksWTrailer.Text = "Trucks with trailer: ";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(104, 92);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 14;
            // 
            // tbGName
            // 
            this.tbGName.Location = new System.Drawing.Point(104, 39);
            this.tbGName.Name = "tbGName";
            this.tbGName.Size = new System.Drawing.Size(210, 20);
            this.tbGName.TabIndex = 15;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(104, 66);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(210, 20);
            this.tbAddress.TabIndex = 16;
            // 
            // tbBicycles
            // 
            this.tbBicycles.Location = new System.Drawing.Point(109, 24);
            this.tbBicycles.Name = "tbBicycles";
            this.tbBicycles.Size = new System.Drawing.Size(59, 20);
            this.tbBicycles.TabIndex = 17;
            this.tbBicycles.TextChanged += new System.EventHandler(this.tbBicycles_TextChanged);
            // 
            // tbCars
            // 
            this.tbCars.Location = new System.Drawing.Point(109, 102);
            this.tbCars.Name = "tbCars";
            this.tbCars.Size = new System.Drawing.Size(59, 20);
            this.tbCars.TabIndex = 20;
            this.tbCars.TextChanged += new System.EventHandler(this.tbCars_TextChanged);
            // 
            // tbMotorcycles
            // 
            this.tbMotorcycles.Location = new System.Drawing.Point(109, 76);
            this.tbMotorcycles.Name = "tbMotorcycles";
            this.tbMotorcycles.Size = new System.Drawing.Size(59, 20);
            this.tbMotorcycles.TabIndex = 19;
            this.tbMotorcycles.TextChanged += new System.EventHandler(this.tbMotorcycles_TextChanged);
            // 
            // tbMopeds
            // 
            this.tbMopeds.Location = new System.Drawing.Point(109, 50);
            this.tbMopeds.Name = "tbMopeds";
            this.tbMopeds.Size = new System.Drawing.Size(59, 20);
            this.tbMopeds.TabIndex = 18;
            this.tbMopeds.TextChanged += new System.EventHandler(this.tbMopeds_TextChanged);
            // 
            // tbCaddies
            // 
            this.tbCaddies.Location = new System.Drawing.Point(109, 128);
            this.tbCaddies.Name = "tbCaddies";
            this.tbCaddies.Size = new System.Drawing.Size(59, 20);
            this.tbCaddies.TabIndex = 21;
            this.tbCaddies.TextChanged += new System.EventHandler(this.tbCaddies_TextChanged);
            // 
            // tbVans
            // 
            this.tbVans.Location = new System.Drawing.Point(109, 154);
            this.tbVans.Name = "tbVans";
            this.tbVans.Size = new System.Drawing.Size(59, 20);
            this.tbVans.TabIndex = 22;
            this.tbVans.TextChanged += new System.EventHandler(this.tbVans_TextChanged);
            // 
            // tbBuses
            // 
            this.tbBuses.Location = new System.Drawing.Point(109, 180);
            this.tbBuses.Name = "tbBuses";
            this.tbBuses.Size = new System.Drawing.Size(59, 20);
            this.tbBuses.TabIndex = 23;
            this.tbBuses.TextChanged += new System.EventHandler(this.tbBuses_TextChanged);
            // 
            // tbTrucks
            // 
            this.tbTrucks.Location = new System.Drawing.Point(109, 206);
            this.tbTrucks.Name = "tbTrucks";
            this.tbTrucks.Size = new System.Drawing.Size(59, 20);
            this.tbTrucks.TabIndex = 24;
            this.tbTrucks.TextChanged += new System.EventHandler(this.tbTrucks_TextChanged);
            // 
            // tbTrucksWTrailor
            // 
            this.tbTrucksWTrailor.Location = new System.Drawing.Point(109, 232);
            this.tbTrucksWTrailor.Name = "tbTrucksWTrailor";
            this.tbTrucksWTrailor.Size = new System.Drawing.Size(59, 20);
            this.tbTrucksWTrailor.TabIndex = 25;
            this.tbTrucksWTrailor.TextChanged += new System.EventHandler(this.tbTrucksWTrailor_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(316, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdd.Size = new System.Drawing.Size(97, 56);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(316, 312);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 45);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear all";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // gbAmount
            // 
            this.gbAmount.Controls.Add(this.labelTrucksWTrailer);
            this.gbAmount.Controls.Add(this.tbTrucksWTrailor);
            this.gbAmount.Controls.Add(this.tbBicycles);
            this.gbAmount.Controls.Add(this.tbMopeds);
            this.gbAmount.Controls.Add(this.tbCaddies);
            this.gbAmount.Controls.Add(this.labelBicycles);
            this.gbAmount.Controls.Add(this.tbMotorcycles);
            this.gbAmount.Controls.Add(this.tbVans);
            this.gbAmount.Controls.Add(this.labelMopeds);
            this.gbAmount.Controls.Add(this.tbCars);
            this.gbAmount.Controls.Add(this.tbBuses);
            this.gbAmount.Controls.Add(this.labelMotorcycles);
            this.gbAmount.Controls.Add(this.tbTrucks);
            this.gbAmount.Controls.Add(this.labelTrucks);
            this.gbAmount.Controls.Add(this.labelCars);
            this.gbAmount.Controls.Add(this.labelBuses);
            this.gbAmount.Controls.Add(this.labelVans);
            this.gbAmount.Controls.Add(this.labelCaddies);
            this.gbAmount.Location = new System.Drawing.Point(15, 119);
            this.gbAmount.Name = "gbAmount";
            this.gbAmount.Size = new System.Drawing.Size(188, 259);
            this.gbAmount.TabIndex = 28;
            this.gbAmount.TabStop = false;
            this.gbAmount.Text = "Amount";
            // 
            // FormAddGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 391);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbGName);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.labelGType);
            this.Controls.Add(this.labelGAddress);
            this.Controls.Add(this.labelGName);
            this.Controls.Add(this.labelUserData);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.gbAmount);
            this.Name = "FormAddGarage";
            this.Text = "Add Garage";
            this.gbAmount.ResumeLayout(false);
            this.gbAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.Label labelGName;
        private System.Windows.Forms.Label labelGAddress;
        private System.Windows.Forms.Label labelGType;
        private System.Windows.Forms.Label labelBicycles;
        private System.Windows.Forms.Label labelMopeds;
        private System.Windows.Forms.Label labelMotorcycles;
        private System.Windows.Forms.Label labelCars;
        private System.Windows.Forms.Label labelCaddies;
        private System.Windows.Forms.Label labelVans;
        private System.Windows.Forms.Label labelBuses;
        private System.Windows.Forms.Label labelTrucks;
        private System.Windows.Forms.Label labelTrucksWTrailer;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbGName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbBicycles;
        private System.Windows.Forms.TextBox tbCars;
        private System.Windows.Forms.TextBox tbMotorcycles;
        private System.Windows.Forms.TextBox tbMopeds;
        private System.Windows.Forms.TextBox tbCaddies;
        private System.Windows.Forms.TextBox tbVans;
        private System.Windows.Forms.TextBox tbBuses;
        private System.Windows.Forms.TextBox tbTrucks;
        private System.Windows.Forms.TextBox tbTrucksWTrailor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox gbAmount;
    }
}