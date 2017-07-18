namespace garageWF
{
    partial class FormRentOpen
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
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.tbGName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.labelOpenClosed = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.gbAvailable = new System.Windows.Forms.GroupBox();
            this.labelTrucksWTrailerAv = new System.Windows.Forms.Label();
            this.labelBicyclesAv = new System.Windows.Forms.Label();
            this.labelMopedsAv = new System.Windows.Forms.Label();
            this.labelMotorcyclesAv = new System.Windows.Forms.Label();
            this.labelTrucksAv = new System.Windows.Forms.Label();
            this.labelCarsAv = new System.Windows.Forms.Label();
            this.labelBusesAv = new System.Windows.Forms.Label();
            this.labelVansAv = new System.Windows.Forms.Label();
            this.labelCaddiesAv = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.tbTrucksWTrailer = new System.Windows.Forms.TextBox();
            this.tbTrucks = new System.Windows.Forms.TextBox();
            this.tbBuses = new System.Windows.Forms.TextBox();
            this.tbVans = new System.Windows.Forms.TextBox();
            this.tbCaddies = new System.Windows.Forms.TextBox();
            this.tbCars = new System.Windows.Forms.TextBox();
            this.tbMotorcycles = new System.Windows.Forms.TextBox();
            this.tbMopeds = new System.Windows.Forms.TextBox();
            this.tbBicycles = new System.Windows.Forms.TextBox();
            this.labelTrucksWTrailer = new System.Windows.Forms.Label();
            this.labelBicycles = new System.Windows.Forms.Label();
            this.labelMopeds = new System.Windows.Forms.Label();
            this.labelMotorcycles = new System.Windows.Forms.Label();
            this.labelTrucks = new System.Windows.Forms.Label();
            this.labelCars = new System.Windows.Forms.Label();
            this.labelBuses = new System.Windows.Forms.Label();
            this.labelVans = new System.Windows.Forms.Label();
            this.labelCaddies = new System.Windows.Forms.Label();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddLoan = new System.Windows.Forms.Button();
            this.listViewLoan = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.gbLoan = new System.Windows.Forms.GroupBox();
            this.buttonRemoveLoan = new System.Windows.Forms.Button();
            this.gbAvailable.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.gbLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Enabled = false;
            this.buttonDiscard.Location = new System.Drawing.Point(377, 142);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(57, 29);
            this.buttonDiscard.TabIndex = 52;
            this.buttonDiscard.TabStop = false;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Visible = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // tbGName
            // 
            this.tbGName.Enabled = false;
            this.tbGName.Location = new System.Drawing.Point(53, 38);
            this.tbGName.Name = "tbGName";
            this.tbGName.Size = new System.Drawing.Size(210, 20);
            this.tbGName.TabIndex = 51;
            this.tbGName.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(377, 107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(57, 29);
            this.buttonSave.TabIndex = 50;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(377, 57);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(57, 45);
            this.buttonEdit.TabIndex = 49;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Enabled = false;
            this.buttonOpenClose.Location = new System.Drawing.Point(297, 57);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(74, 45);
            this.buttonOpenClose.TabIndex = 48;
            this.buttonOpenClose.TabStop = false;
            this.buttonOpenClose.Text = "Open/Close";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Visible = false;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // labelOpenClosed
            // 
            this.labelOpenClosed.AutoSize = true;
            this.labelOpenClosed.Location = new System.Drawing.Point(323, 10);
            this.labelOpenClosed.Name = "labelOpenClosed";
            this.labelOpenClosed.Size = new System.Drawing.Size(34, 13);
            this.labelOpenClosed.TabIndex = 47;
            this.labelOpenClosed.Text = "ToDo";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(11, 73);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 13);
            this.labelAddress.TabIndex = 46;
            this.labelAddress.Text = "Address: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Name: ";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(11, 10);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(44, 13);
            this.labelOwner.TabIndex = 44;
            this.labelOwner.Text = "Owner: ";
            // 
            // gbAvailable
            // 
            this.gbAvailable.Controls.Add(this.labelTrucksWTrailerAv);
            this.gbAvailable.Controls.Add(this.labelBicyclesAv);
            this.gbAvailable.Controls.Add(this.labelMopedsAv);
            this.gbAvailable.Controls.Add(this.labelMotorcyclesAv);
            this.gbAvailable.Controls.Add(this.labelTrucksAv);
            this.gbAvailable.Controls.Add(this.labelCarsAv);
            this.gbAvailable.Controls.Add(this.labelBusesAv);
            this.gbAvailable.Controls.Add(this.labelVansAv);
            this.gbAvailable.Controls.Add(this.labelCaddiesAv);
            this.gbAvailable.Location = new System.Drawing.Point(193, 107);
            this.gbAvailable.Name = "gbAvailable";
            this.gbAvailable.Size = new System.Drawing.Size(164, 259);
            this.gbAvailable.TabIndex = 43;
            this.gbAvailable.TabStop = false;
            this.gbAvailable.Text = "Available";
            // 
            // labelTrucksWTrailerAv
            // 
            this.labelTrucksWTrailerAv.AutoSize = true;
            this.labelTrucksWTrailerAv.Location = new System.Drawing.Point(7, 235);
            this.labelTrucksWTrailerAv.Name = "labelTrucksWTrailerAv";
            this.labelTrucksWTrailerAv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTrucksWTrailerAv.Size = new System.Drawing.Size(96, 13);
            this.labelTrucksWTrailerAv.TabIndex = 13;
            this.labelTrucksWTrailerAv.Text = "Trucks with trailer: ";
            // 
            // labelBicyclesAv
            // 
            this.labelBicyclesAv.AutoSize = true;
            this.labelBicyclesAv.Location = new System.Drawing.Point(51, 27);
            this.labelBicyclesAv.Name = "labelBicyclesAv";
            this.labelBicyclesAv.Size = new System.Drawing.Size(52, 13);
            this.labelBicyclesAv.TabIndex = 5;
            this.labelBicyclesAv.Text = "Bicycles: ";
            // 
            // labelMopedsAv
            // 
            this.labelMopedsAv.AutoSize = true;
            this.labelMopedsAv.Location = new System.Drawing.Point(52, 53);
            this.labelMopedsAv.Name = "labelMopedsAv";
            this.labelMopedsAv.Size = new System.Drawing.Size(51, 13);
            this.labelMopedsAv.TabIndex = 6;
            this.labelMopedsAv.Text = "Mopeds: ";
            // 
            // labelMotorcyclesAv
            // 
            this.labelMotorcyclesAv.AutoSize = true;
            this.labelMotorcyclesAv.Location = new System.Drawing.Point(33, 79);
            this.labelMotorcyclesAv.Name = "labelMotorcyclesAv";
            this.labelMotorcyclesAv.Size = new System.Drawing.Size(70, 13);
            this.labelMotorcyclesAv.TabIndex = 7;
            this.labelMotorcyclesAv.Text = "Motorcycles: ";
            // 
            // labelTrucksAv
            // 
            this.labelTrucksAv.AutoSize = true;
            this.labelTrucksAv.Location = new System.Drawing.Point(57, 209);
            this.labelTrucksAv.Name = "labelTrucksAv";
            this.labelTrucksAv.Size = new System.Drawing.Size(46, 13);
            this.labelTrucksAv.TabIndex = 12;
            this.labelTrucksAv.Text = "Trucks: ";
            // 
            // labelCarsAv
            // 
            this.labelCarsAv.AutoSize = true;
            this.labelCarsAv.Location = new System.Drawing.Point(69, 105);
            this.labelCarsAv.Name = "labelCarsAv";
            this.labelCarsAv.Size = new System.Drawing.Size(34, 13);
            this.labelCarsAv.TabIndex = 8;
            this.labelCarsAv.Text = "Cars: ";
            // 
            // labelBusesAv
            // 
            this.labelBusesAv.AutoSize = true;
            this.labelBusesAv.Location = new System.Drawing.Point(61, 183);
            this.labelBusesAv.Name = "labelBusesAv";
            this.labelBusesAv.Size = new System.Drawing.Size(42, 13);
            this.labelBusesAv.TabIndex = 11;
            this.labelBusesAv.Text = "Buses: ";
            // 
            // labelVansAv
            // 
            this.labelVansAv.AutoSize = true;
            this.labelVansAv.Location = new System.Drawing.Point(66, 157);
            this.labelVansAv.Name = "labelVansAv";
            this.labelVansAv.Size = new System.Drawing.Size(37, 13);
            this.labelVansAv.TabIndex = 10;
            this.labelVansAv.Text = "Vans: ";
            // 
            // labelCaddiesAv
            // 
            this.labelCaddiesAv.AutoSize = true;
            this.labelCaddiesAv.Location = new System.Drawing.Point(52, 131);
            this.labelCaddiesAv.Name = "labelCaddiesAv";
            this.labelCaddiesAv.Size = new System.Drawing.Size(51, 13);
            this.labelCaddiesAv.TabIndex = 9;
            this.labelCaddiesAv.Text = "Caddies: ";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.tbTrucksWTrailer);
            this.gbTotal.Controls.Add(this.tbTrucks);
            this.gbTotal.Controls.Add(this.tbBuses);
            this.gbTotal.Controls.Add(this.tbVans);
            this.gbTotal.Controls.Add(this.tbCaddies);
            this.gbTotal.Controls.Add(this.tbCars);
            this.gbTotal.Controls.Add(this.tbMotorcycles);
            this.gbTotal.Controls.Add(this.tbMopeds);
            this.gbTotal.Controls.Add(this.tbBicycles);
            this.gbTotal.Controls.Add(this.labelTrucksWTrailer);
            this.gbTotal.Controls.Add(this.labelBicycles);
            this.gbTotal.Controls.Add(this.labelMopeds);
            this.gbTotal.Controls.Add(this.labelMotorcycles);
            this.gbTotal.Controls.Add(this.labelTrucks);
            this.gbTotal.Controls.Add(this.labelCars);
            this.gbTotal.Controls.Add(this.labelBuses);
            this.gbTotal.Controls.Add(this.labelVans);
            this.gbTotal.Controls.Add(this.labelCaddies);
            this.gbTotal.Location = new System.Drawing.Point(11, 107);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(167, 259);
            this.gbTotal.TabIndex = 42;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // tbTrucksWTrailer
            // 
            this.tbTrucksWTrailer.Enabled = false;
            this.tbTrucksWTrailer.Location = new System.Drawing.Point(102, 232);
            this.tbTrucksWTrailer.Name = "tbTrucksWTrailer";
            this.tbTrucksWTrailer.Size = new System.Drawing.Size(59, 20);
            this.tbTrucksWTrailer.TabIndex = 50;
            this.tbTrucksWTrailer.Visible = false;
            // 
            // tbTrucks
            // 
            this.tbTrucks.Enabled = false;
            this.tbTrucks.Location = new System.Drawing.Point(102, 206);
            this.tbTrucks.Name = "tbTrucks";
            this.tbTrucks.Size = new System.Drawing.Size(59, 20);
            this.tbTrucks.TabIndex = 49;
            this.tbTrucks.Visible = false;
            // 
            // tbBuses
            // 
            this.tbBuses.Enabled = false;
            this.tbBuses.Location = new System.Drawing.Point(102, 180);
            this.tbBuses.Name = "tbBuses";
            this.tbBuses.Size = new System.Drawing.Size(59, 20);
            this.tbBuses.TabIndex = 48;
            this.tbBuses.Visible = false;
            // 
            // tbVans
            // 
            this.tbVans.Enabled = false;
            this.tbVans.Location = new System.Drawing.Point(102, 154);
            this.tbVans.Name = "tbVans";
            this.tbVans.Size = new System.Drawing.Size(59, 20);
            this.tbVans.TabIndex = 47;
            this.tbVans.Visible = false;
            // 
            // tbCaddies
            // 
            this.tbCaddies.Enabled = false;
            this.tbCaddies.Location = new System.Drawing.Point(102, 128);
            this.tbCaddies.Name = "tbCaddies";
            this.tbCaddies.Size = new System.Drawing.Size(59, 20);
            this.tbCaddies.TabIndex = 46;
            this.tbCaddies.Visible = false;
            // 
            // tbCars
            // 
            this.tbCars.Enabled = false;
            this.tbCars.Location = new System.Drawing.Point(102, 102);
            this.tbCars.Name = "tbCars";
            this.tbCars.Size = new System.Drawing.Size(59, 20);
            this.tbCars.TabIndex = 45;
            this.tbCars.Visible = false;
            // 
            // tbMotorcycles
            // 
            this.tbMotorcycles.Enabled = false;
            this.tbMotorcycles.Location = new System.Drawing.Point(102, 76);
            this.tbMotorcycles.Name = "tbMotorcycles";
            this.tbMotorcycles.Size = new System.Drawing.Size(59, 20);
            this.tbMotorcycles.TabIndex = 44;
            this.tbMotorcycles.Visible = false;
            // 
            // tbMopeds
            // 
            this.tbMopeds.Enabled = false;
            this.tbMopeds.Location = new System.Drawing.Point(102, 50);
            this.tbMopeds.Name = "tbMopeds";
            this.tbMopeds.Size = new System.Drawing.Size(59, 20);
            this.tbMopeds.TabIndex = 43;
            this.tbMopeds.Visible = false;
            // 
            // tbBicycles
            // 
            this.tbBicycles.Enabled = false;
            this.tbBicycles.Location = new System.Drawing.Point(102, 24);
            this.tbBicycles.Name = "tbBicycles";
            this.tbBicycles.Size = new System.Drawing.Size(59, 20);
            this.tbBicycles.TabIndex = 42;
            this.tbBicycles.Visible = false;
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
            // labelTrucks
            // 
            this.labelTrucks.AutoSize = true;
            this.labelTrucks.Location = new System.Drawing.Point(57, 209);
            this.labelTrucks.Name = "labelTrucks";
            this.labelTrucks.Size = new System.Drawing.Size(46, 13);
            this.labelTrucks.TabIndex = 12;
            this.labelTrucks.Text = "Trucks: ";
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
            // labelBuses
            // 
            this.labelBuses.AutoSize = true;
            this.labelBuses.Location = new System.Drawing.Point(61, 183);
            this.labelBuses.Name = "labelBuses";
            this.labelBuses.Size = new System.Drawing.Size(42, 13);
            this.labelBuses.TabIndex = 11;
            this.labelBuses.Text = "Buses: ";
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
            // labelCaddies
            // 
            this.labelCaddies.AutoSize = true;
            this.labelCaddies.Location = new System.Drawing.Point(52, 131);
            this.labelCaddies.Name = "labelCaddies";
            this.labelCaddies.Size = new System.Drawing.Size(51, 13);
            this.labelCaddies.TabIndex = 9;
            this.labelCaddies.Text = "Caddies: ";
            // 
            // cbVehicle
            // 
            this.cbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicle.Enabled = false;
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Location = new System.Drawing.Point(4, 26);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(167, 21);
            this.cbVehicle.TabIndex = 53;
            this.cbVehicle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Vehicle for the loan: ";
            this.label1.Visible = false;
            // 
            // tbComments
            // 
            this.tbComments.Enabled = false;
            this.tbComments.Location = new System.Drawing.Point(4, 66);
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(167, 20);
            this.tbComments.TabIndex = 55;
            this.tbComments.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(1, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Comments:";
            this.label2.Visible = false;
            // 
            // buttonAddLoan
            // 
            this.buttonAddLoan.Enabled = false;
            this.buttonAddLoan.Location = new System.Drawing.Point(357, 10);
            this.buttonAddLoan.Name = "buttonAddLoan";
            this.buttonAddLoan.Size = new System.Drawing.Size(70, 76);
            this.buttonAddLoan.TabIndex = 57;
            this.buttonAddLoan.TabStop = false;
            this.buttonAddLoan.Text = "Add Loan";
            this.buttonAddLoan.UseVisualStyleBackColor = true;
            this.buttonAddLoan.Visible = false;
            this.buttonAddLoan.Click += new System.EventHandler(this.buttonAddLoan_Click);
            // 
            // listViewLoan
            // 
            this.listViewLoan.Enabled = false;
            this.listViewLoan.FullRowSelect = true;
            this.listViewLoan.Location = new System.Drawing.Point(4, 100);
            this.listViewLoan.MultiSelect = false;
            this.listViewLoan.Name = "listViewLoan";
            this.listViewLoan.Size = new System.Drawing.Size(346, 154);
            this.listViewLoan.TabIndex = 58;
            this.listViewLoan.TabStop = false;
            this.listViewLoan.UseCompatibleStateImageBehavior = false;
            this.listViewLoan.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Customer name: ";
            this.label3.Visible = false;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Enabled = false;
            this.tbCustomer.Location = new System.Drawing.Point(186, 26);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(164, 20);
            this.tbCustomer.TabIndex = 60;
            this.tbCustomer.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(183, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Customer ID card number:";
            this.label4.Visible = false;
            // 
            // tbCardNo
            // 
            this.tbCardNo.Enabled = false;
            this.tbCardNo.Location = new System.Drawing.Point(186, 66);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(164, 20);
            this.tbCardNo.TabIndex = 62;
            this.tbCardNo.Visible = false;
            this.tbCardNo.TextChanged += new System.EventHandler(this.tbCardNo_TextChanged);
            // 
            // gbLoan
            // 
            this.gbLoan.Controls.Add(this.buttonRemoveLoan);
            this.gbLoan.Controls.Add(this.tbCardNo);
            this.gbLoan.Controls.Add(this.label4);
            this.gbLoan.Controls.Add(this.tbCustomer);
            this.gbLoan.Controls.Add(this.label3);
            this.gbLoan.Controls.Add(this.listViewLoan);
            this.gbLoan.Controls.Add(this.buttonAddLoan);
            this.gbLoan.Controls.Add(this.label2);
            this.gbLoan.Controls.Add(this.tbComments);
            this.gbLoan.Controls.Add(this.label1);
            this.gbLoan.Controls.Add(this.cbVehicle);
            this.gbLoan.Location = new System.Drawing.Point(11, 372);
            this.gbLoan.Name = "gbLoan";
            this.gbLoan.Size = new System.Drawing.Size(433, 257);
            this.gbLoan.TabIndex = 63;
            this.gbLoan.TabStop = false;
            this.gbLoan.Visible = false;
            // 
            // buttonRemoveLoan
            // 
            this.buttonRemoveLoan.Enabled = false;
            this.buttonRemoveLoan.Location = new System.Drawing.Point(357, 99);
            this.buttonRemoveLoan.Name = "buttonRemoveLoan";
            this.buttonRemoveLoan.Size = new System.Drawing.Size(70, 43);
            this.buttonRemoveLoan.TabIndex = 63;
            this.buttonRemoveLoan.Text = "Remove Loan";
            this.buttonRemoveLoan.UseVisualStyleBackColor = true;
            this.buttonRemoveLoan.Visible = false;
            this.buttonRemoveLoan.Click += new System.EventHandler(this.buttonRemoveLoan_Click);
            // 
            // FormRentOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 641);
            this.Controls.Add(this.gbLoan);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.tbGName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOpenClose);
            this.Controls.Add(this.labelOpenClosed);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.gbAvailable);
            this.Controls.Add(this.gbTotal);
            this.Name = "FormRentOpen";
            this.Text = "Rent";
            this.gbAvailable.ResumeLayout(false);
            this.gbAvailable.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.gbLoan.ResumeLayout(false);
            this.gbLoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.TextBox tbGName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.Label labelOpenClosed;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.GroupBox gbAvailable;
        private System.Windows.Forms.Label labelTrucksWTrailerAv;
        private System.Windows.Forms.Label labelBicyclesAv;
        private System.Windows.Forms.Label labelMopedsAv;
        private System.Windows.Forms.Label labelMotorcyclesAv;
        private System.Windows.Forms.Label labelTrucksAv;
        private System.Windows.Forms.Label labelCarsAv;
        private System.Windows.Forms.Label labelBusesAv;
        private System.Windows.Forms.Label labelVansAv;
        private System.Windows.Forms.Label labelCaddiesAv;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.TextBox tbTrucksWTrailer;
        private System.Windows.Forms.TextBox tbTrucks;
        private System.Windows.Forms.TextBox tbBuses;
        private System.Windows.Forms.TextBox tbVans;
        private System.Windows.Forms.TextBox tbCaddies;
        private System.Windows.Forms.TextBox tbCars;
        private System.Windows.Forms.TextBox tbMotorcycles;
        private System.Windows.Forms.TextBox tbMopeds;
        private System.Windows.Forms.TextBox tbBicycles;
        private System.Windows.Forms.Label labelTrucksWTrailer;
        private System.Windows.Forms.Label labelBicycles;
        private System.Windows.Forms.Label labelMopeds;
        private System.Windows.Forms.Label labelMotorcycles;
        private System.Windows.Forms.Label labelTrucks;
        private System.Windows.Forms.Label labelCars;
        private System.Windows.Forms.Label labelBuses;
        private System.Windows.Forms.Label labelVans;
        private System.Windows.Forms.Label labelCaddies;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddLoan;
        private System.Windows.Forms.ListView listViewLoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.GroupBox gbLoan;
        private System.Windows.Forms.Button buttonRemoveLoan;
    }
}