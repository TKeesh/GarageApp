namespace garageWF
{
    partial class FormChangeUsername
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
            this.labelNewUsern1 = new System.Windows.Forms.Label();
            this.labelNewUsern2 = new System.Windows.Forms.Label();
            this.tbNewUsern1 = new System.Windows.Forms.TextBox();
            this.tbNewUsern2 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewUsern1
            // 
            this.labelNewUsern1.AutoSize = true;
            this.labelNewUsern1.Location = new System.Drawing.Point(100, 31);
            this.labelNewUsern1.Name = "labelNewUsern1";
            this.labelNewUsern1.Size = new System.Drawing.Size(84, 13);
            this.labelNewUsern1.TabIndex = 1;
            this.labelNewUsern1.Text = "New username: ";
            // 
            // labelNewUsern2
            // 
            this.labelNewUsern2.AutoSize = true;
            this.labelNewUsern2.Location = new System.Drawing.Point(85, 107);
            this.labelNewUsern2.Name = "labelNewUsern2";
            this.labelNewUsern2.Size = new System.Drawing.Size(113, 13);
            this.labelNewUsern2.TabIndex = 2;
            this.labelNewUsern2.Text = "New username again: ";
            // 
            // tbNewUsern1
            // 
            this.tbNewUsern1.Location = new System.Drawing.Point(76, 54);
            this.tbNewUsern1.Name = "tbNewUsern1";
            this.tbNewUsern1.Size = new System.Drawing.Size(131, 20);
            this.tbNewUsern1.TabIndex = 3;
            // 
            // tbNewUsern2
            // 
            this.tbNewUsern2.Location = new System.Drawing.Point(76, 131);
            this.tbNewUsern2.Name = "tbNewUsern2";
            this.tbNewUsern2.Size = new System.Drawing.Size(131, 20);
            this.tbNewUsern2.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(113, 189);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(54, 27);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tbNewUsern2);
            this.Controls.Add(this.tbNewUsern1);
            this.Controls.Add(this.labelNewUsern2);
            this.Controls.Add(this.labelNewUsern1);
            this.Name = "FormChangeUsername";
            this.Text = "Change Username";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewUsern1;
        private System.Windows.Forms.Label labelNewUsern2;
        private System.Windows.Forms.TextBox tbNewUsern1;
        private System.Windows.Forms.TextBox tbNewUsern2;
        private System.Windows.Forms.Button buttonOK;
    }
}