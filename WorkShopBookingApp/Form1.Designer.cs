namespace WorkShopBookingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProgramList = new System.Windows.Forms.ListBox();
            this.LocationList = new System.Windows.Forms.ListBox();
            this.MealList = new System.Windows.Forms.ListBox();
            this.UserPassInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CertificateList = new System.Windows.Forms.ListBox();
            this.BookingButton = new System.Windows.Forms.Button();
            this.BookingGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalCost = new System.Windows.Forms.Label();
            this.CertificateChoosen = new System.Windows.Forms.Label();
            this.MealOptionSummary = new System.Windows.Forms.Label();
            this.LocationSummary = new System.Windows.Forms.Label();
            this.ProgramSummary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OptionalSelectionGB = new System.Windows.Forms.GroupBox();
            this.BookingGroupBox.SuspendLayout();
            this.OptionalSelectionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramList
            // 
            this.ProgramList.BackColor = System.Drawing.SystemColors.Window;
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgramList.Items.AddRange(new object[] {
            "ASP.NET with C#  \t          4days\t€1,200 ",
            "Winforms Apps with C#     3days\t€1,000",
            ".NET Prog using C# Part 1  4days\t€1,500",
            ".NET Prog using C# Part 2  4days\t€1,800",
            "Digital Detox\t          1 day\t€599"});
            this.ProgramList.Location = new System.Drawing.Point(24, 144);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(251, 56);
            this.ProgramList.TabIndex = 2;
            this.ProgramList.Visible = false;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LocationList
            // 
            this.LocationList.FormattingEnabled = true;
            this.LocationList.Items.AddRange(new object[] {
            "Cork\t€150",
            "Dublin\t€225",
            "Galway\t€175",
            "Belmullet  €305",
            "Limerick\t€135",
            "Wexford\t€89"});
            this.LocationList.Location = new System.Drawing.Point(24, 206);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(141, 43);
            this.LocationList.TabIndex = 3;
            this.LocationList.Visible = false;
            // 
            // MealList
            // 
            this.MealList.FormattingEnabled = true;
            this.MealList.Items.AddRange(new object[] {
            "Full Board           €39.50",
            "Half Board          €27.50",
            "Breakfast Only   €12.50"});
            this.MealList.Location = new System.Drawing.Point(6, 19);
            this.MealList.Name = "MealList";
            this.MealList.Size = new System.Drawing.Size(137, 43);
            this.MealList.TabIndex = 4;
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(157, 89);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(193, 20);
            this.UserPassInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(260, 115);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(90, 25);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(340, 548);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(365, 317);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Visible = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(200, 548);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(121, 23);
            this.SummaryButton.TabIndex = 10;
            this.SummaryButton.Text = "Booking Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(365, 377);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Visible = false;
            // 
            // CertificateList
            // 
            this.CertificateList.FormattingEnabled = true;
            this.CertificateList.Items.AddRange(new object[] {
            "Digital Certificate      FREE",
            "Printed Certificate     €29.95"});
            this.CertificateList.Location = new System.Drawing.Point(6, 68);
            this.CertificateList.Name = "CertificateList";
            this.CertificateList.Size = new System.Drawing.Size(137, 43);
            this.CertificateList.TabIndex = 12;
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(99, 548);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(75, 23);
            this.BookingButton.TabIndex = 13;
            this.BookingButton.Text = "Book";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Visible = false;
            // 
            // BookingGroupBox
            // 
            this.BookingGroupBox.Controls.Add(this.TotalCost);
            this.BookingGroupBox.Controls.Add(this.CertificateChoosen);
            this.BookingGroupBox.Controls.Add(this.MealOptionSummary);
            this.BookingGroupBox.Controls.Add(this.LocationSummary);
            this.BookingGroupBox.Controls.Add(this.ProgramSummary);
            this.BookingGroupBox.Controls.Add(this.label6);
            this.BookingGroupBox.Controls.Add(this.label5);
            this.BookingGroupBox.Controls.Add(this.label4);
            this.BookingGroupBox.Controls.Add(this.label3);
            this.BookingGroupBox.Controls.Add(this.label2);
            this.BookingGroupBox.Location = new System.Drawing.Point(46, 317);
            this.BookingGroupBox.Name = "BookingGroupBox";
            this.BookingGroupBox.Size = new System.Drawing.Size(304, 210);
            this.BookingGroupBox.TabIndex = 14;
            this.BookingGroupBox.TabStop = false;
            this.BookingGroupBox.Text = "Your Booking Details";
            this.BookingGroupBox.Visible = false;
            // 
            // TotalCost
            // 
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost.Location = new System.Drawing.Point(111, 173);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(177, 25);
            this.TotalCost.TabIndex = 9;
            // 
            // CertificateChoosen
            // 
            this.CertificateChoosen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CertificateChoosen.Location = new System.Drawing.Point(111, 139);
            this.CertificateChoosen.Name = "CertificateChoosen";
            this.CertificateChoosen.Size = new System.Drawing.Size(177, 25);
            this.CertificateChoosen.TabIndex = 8;
            // 
            // MealOptionSummary
            // 
            this.MealOptionSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MealOptionSummary.Location = new System.Drawing.Point(111, 98);
            this.MealOptionSummary.Name = "MealOptionSummary";
            this.MealOptionSummary.Size = new System.Drawing.Size(177, 23);
            this.MealOptionSummary.TabIndex = 7;
            // 
            // LocationSummary
            // 
            this.LocationSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LocationSummary.Location = new System.Drawing.Point(111, 57);
            this.LocationSummary.Name = "LocationSummary";
            this.LocationSummary.Size = new System.Drawing.Size(177, 26);
            this.LocationSummary.TabIndex = 6;
            // 
            // ProgramSummary
            // 
            this.ProgramSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProgramSummary.Location = new System.Drawing.Point(111, 16);
            this.ProgramSummary.Name = "ProgramSummary";
            this.ProgramSummary.Size = new System.Drawing.Size(177, 27);
            this.ProgramSummary.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Totoal Cost: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Certificate Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Meal Option:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Program:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 16;
            // 
            // OptionalSelectionGB
            // 
            this.OptionalSelectionGB.Controls.Add(this.MealList);
            this.OptionalSelectionGB.Controls.Add(this.CertificateList);
            this.OptionalSelectionGB.Location = new System.Drawing.Point(293, 146);
            this.OptionalSelectionGB.Name = "OptionalSelectionGB";
            this.OptionalSelectionGB.Size = new System.Drawing.Size(160, 127);
            this.OptionalSelectionGB.TabIndex = 19;
            this.OptionalSelectionGB.TabStop = false;
            this.OptionalSelectionGB.Text = "Optional Selections";
            this.OptionalSelectionGB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(569, 594);
            this.Controls.Add(this.OptionalSelectionGB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BookingGroupBox);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPassInput);
            this.Controls.Add(this.LocationList);
            this.Controls.Add(this.ProgramList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Workshop Booking";
            this.BookingGroupBox.ResumeLayout(false);
            this.BookingGroupBox.PerformLayout();
            this.OptionalSelectionGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProgramList;
        private System.Windows.Forms.ListBox LocationList;
        private System.Windows.Forms.ListBox MealList;
        private System.Windows.Forms.TextBox UserPassInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ListBox CertificateList;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.GroupBox BookingGroupBox;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label CertificateChoosen;
        private System.Windows.Forms.Label MealOptionSummary;
        private System.Windows.Forms.Label LocationSummary;
        private System.Windows.Forms.Label ProgramSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox OptionalSelectionGB;
    }
}

