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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProgramSummary = new System.Windows.Forms.Label();
            this.LocationSummary = new System.Windows.Forms.Label();
            this.MealOptionSummary = new System.Windows.Forms.Label();
            this.CertificateChoosen = new System.Windows.Forms.Label();
            this.TotalBookingSummary = new System.Windows.Forms.Label();
            this.BookingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramList
            // 
            this.ProgramList.BackColor = System.Drawing.SystemColors.Window;
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgramList.Items.AddRange(new object[] {
            "ASP.NET with C#",
            "Winforms Apps with C#",
            ".NET Prog using C# Part 1",
            ".NET Prog using C# Part 2",
            "Digital Detox"});
            this.ProgramList.Location = new System.Drawing.Point(12, 134);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(140, 69);
            this.ProgramList.TabIndex = 2;
            this.ProgramList.Visible = false;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LocationList
            // 
            this.LocationList.FormattingEnabled = true;
            this.LocationList.Items.AddRange(new object[] {
            "Cork",
            "Dublin",
            "Galway",
            "Belmullet",
            "Limerick",
            "Wexford"});
            this.LocationList.Location = new System.Drawing.Point(158, 134);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(146, 69);
            this.LocationList.TabIndex = 3;
            this.LocationList.Visible = false;
            // 
            // MealList
            // 
            this.MealList.FormattingEnabled = true;
            this.MealList.Items.AddRange(new object[] {
            "Full Board",
            "Half Board",
            "Breakfast Only"});
            this.MealList.Location = new System.Drawing.Point(326, 160);
            this.MealList.Name = "MealList";
            this.MealList.Size = new System.Drawing.Size(137, 43);
            this.MealList.TabIndex = 4;
            this.MealList.Visible = false;
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(162, 63);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(193, 20);
            this.UserPassInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(373, 60);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(90, 25);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(373, 101);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 28);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(337, 305);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(210, 492);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(121, 23);
            this.SummaryButton.TabIndex = 10;
            this.SummaryButton.Text = "Booking Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(362, 492);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CertificateList
            // 
            this.CertificateList.FormattingEnabled = true;
            this.CertificateList.Items.AddRange(new object[] {
            "Digital Certificate",
            "Printed Certificate"});
            this.CertificateList.Location = new System.Drawing.Point(326, 209);
            this.CertificateList.Name = "CertificateList";
            this.CertificateList.Size = new System.Drawing.Size(137, 43);
            this.CertificateList.TabIndex = 12;
            this.CertificateList.Visible = false;
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(103, 492);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(75, 23);
            this.BookingButton.TabIndex = 13;
            this.BookingButton.Text = "Book";
            this.BookingButton.UseVisualStyleBackColor = true;
            // 
            // BookingGroupBox
            // 
            this.BookingGroupBox.Controls.Add(this.TotalBookingSummary);
            this.BookingGroupBox.Controls.Add(this.CertificateChoosen);
            this.BookingGroupBox.Controls.Add(this.MealOptionSummary);
            this.BookingGroupBox.Controls.Add(this.LocationSummary);
            this.BookingGroupBox.Controls.Add(this.ProgramSummary);
            this.BookingGroupBox.Controls.Add(this.label6);
            this.BookingGroupBox.Controls.Add(this.label5);
            this.BookingGroupBox.Controls.Add(this.label4);
            this.BookingGroupBox.Controls.Add(this.label3);
            this.BookingGroupBox.Controls.Add(this.label2);
            this.BookingGroupBox.Location = new System.Drawing.Point(54, 257);
            this.BookingGroupBox.Name = "BookingGroupBox";
            this.BookingGroupBox.Size = new System.Drawing.Size(277, 212);
            this.BookingGroupBox.TabIndex = 14;
            this.BookingGroupBox.TabStop = false;
            this.BookingGroupBox.Text = "Your Booking Details";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Location:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Certificate Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Totoal Booking Amount: ";
            // 
            // ProgramSummary
            // 
            this.ProgramSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProgramSummary.Location = new System.Drawing.Point(145, 16);
            this.ProgramSummary.Name = "ProgramSummary";
            this.ProgramSummary.Size = new System.Drawing.Size(118, 27);
            this.ProgramSummary.TabIndex = 5;
            // 
            // LocationSummary
            // 
            this.LocationSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LocationSummary.Location = new System.Drawing.Point(145, 57);
            this.LocationSummary.Name = "LocationSummary";
            this.LocationSummary.Size = new System.Drawing.Size(112, 24);
            this.LocationSummary.TabIndex = 6;
            // 
            // MealOptionSummary
            // 
            this.MealOptionSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MealOptionSummary.Location = new System.Drawing.Point(145, 98);
            this.MealOptionSummary.Name = "MealOptionSummary";
            this.MealOptionSummary.Size = new System.Drawing.Size(112, 22);
            this.MealOptionSummary.TabIndex = 7;
            // 
            // CertificateChoosen
            // 
            this.CertificateChoosen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CertificateChoosen.Location = new System.Drawing.Point(145, 139);
            this.CertificateChoosen.Name = "CertificateChoosen";
            this.CertificateChoosen.Size = new System.Drawing.Size(118, 21);
            this.CertificateChoosen.TabIndex = 8;
            // 
            // TotalBookingSummary
            // 
            this.TotalBookingSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalBookingSummary.Location = new System.Drawing.Point(145, 173);
            this.TotalBookingSummary.Name = "TotalBookingSummary";
            this.TotalBookingSummary.Size = new System.Drawing.Size(118, 25);
            this.TotalBookingSummary.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 542);
            this.Controls.Add(this.BookingGroupBox);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.CertificateList);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPassInput);
            this.Controls.Add(this.MealList);
            this.Controls.Add(this.LocationList);
            this.Controls.Add(this.ProgramList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Workshop Booking";
            this.BookingGroupBox.ResumeLayout(false);
            this.BookingGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label TotalBookingSummary;
        private System.Windows.Forms.Label CertificateChoosen;
        private System.Windows.Forms.Label MealOptionSummary;
        private System.Windows.Forms.Label LocationSummary;
        private System.Windows.Forms.Label ProgramSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

