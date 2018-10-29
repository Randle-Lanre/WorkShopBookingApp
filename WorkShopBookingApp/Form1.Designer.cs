namespace Learn2Prog_Ltd
{
    partial class Learn2Prog_Ltd_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn2Prog_Ltd_Form));
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
            this.OptionalSelectionGB = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AllBookingSummaryGB = new System.Windows.Forms.GroupBox();
            this.AvgRevenuePerBooking = new System.Windows.Forms.Label();
            this.ValueOptionsChoosen = new System.Windows.Forms.Label();
            this.TotalLodgingFees = new System.Windows.Forms.Label();
            this.TotalRegFees = new System.Windows.Forms.Label();
            this.TotalBookings = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BookingGroupBox.SuspendLayout();
            this.OptionalSelectionGB.SuspendLayout();
            this.AllBookingSummaryGB.SuspendLayout();
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
            this.ProgramList.Location = new System.Drawing.Point(99, 163);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(251, 56);
            this.ProgramList.TabIndex = 2;
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
            this.LocationList.Location = new System.Drawing.Point(99, 248);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(141, 43);
            this.LocationList.TabIndex = 3;
            // 
            // MealList
            // 
            this.MealList.FormattingEnabled = true;
            this.MealList.Items.AddRange(new object[] {
            "Full Board           €39.50",
            "Half Board          €27.50",
            "Breakfast Only   €12.50",
            "No Meal"});
            this.MealList.Location = new System.Drawing.Point(6, 32);
            this.MealList.Name = "MealList";
            this.MealList.Size = new System.Drawing.Size(137, 43);
            this.MealList.TabIndex = 4;
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(251, 82);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(193, 20);
            this.UserPassInput.TabIndex = 5;
            this.UserPassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(307, 115);
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
            this.DisplayButton.Location = new System.Drawing.Point(399, 329);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
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
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(399, 370);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Visible = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CertificateList
            // 
            this.CertificateList.FormattingEnabled = true;
            this.CertificateList.Items.AddRange(new object[] {
            "Digital Certificate      FREE",
            "Printed Certificate     €29.95"});
            this.CertificateList.Location = new System.Drawing.Point(6, 98);
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
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
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
            this.BookingGroupBox.Size = new System.Drawing.Size(338, 205);
            this.BookingGroupBox.TabIndex = 14;
            this.BookingGroupBox.TabStop = false;
            this.BookingGroupBox.Text = "Your Booking Details";
            // 
            // TotalCost
            // 
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCost.Location = new System.Drawing.Point(161, 173);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(177, 25);
            this.TotalCost.TabIndex = 9;
            this.TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CertificateChoosen
            // 
            this.CertificateChoosen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CertificateChoosen.Location = new System.Drawing.Point(161, 134);
            this.CertificateChoosen.Name = "CertificateChoosen";
            this.CertificateChoosen.Size = new System.Drawing.Size(177, 25);
            this.CertificateChoosen.TabIndex = 8;
            this.CertificateChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MealOptionSummary
            // 
            this.MealOptionSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MealOptionSummary.Location = new System.Drawing.Point(161, 98);
            this.MealOptionSummary.Name = "MealOptionSummary";
            this.MealOptionSummary.Size = new System.Drawing.Size(177, 23);
            this.MealOptionSummary.TabIndex = 7;
            this.MealOptionSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationSummary
            // 
            this.LocationSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LocationSummary.Location = new System.Drawing.Point(161, 53);
            this.LocationSummary.Name = "LocationSummary";
            this.LocationSummary.Size = new System.Drawing.Size(177, 26);
            this.LocationSummary.TabIndex = 6;
            this.LocationSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgramSummary
            // 
            this.ProgramSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProgramSummary.Location = new System.Drawing.Point(161, 16);
            this.ProgramSummary.Name = "ProgramSummary";
            this.ProgramSummary.Size = new System.Drawing.Size(177, 27);
            this.ProgramSummary.TabIndex = 5;
            this.ProgramSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Overall Workshop Cost: ";
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
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lodging Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Program and Registration cost:";
            // 
            // OptionalSelectionGB
            // 
            this.OptionalSelectionGB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OptionalSelectionGB.Controls.Add(this.label11);
            this.OptionalSelectionGB.Controls.Add(this.label10);
            this.OptionalSelectionGB.Controls.Add(this.MealList);
            this.OptionalSelectionGB.Controls.Add(this.CertificateList);
            this.OptionalSelectionGB.Location = new System.Drawing.Point(449, 144);
            this.OptionalSelectionGB.Name = "OptionalSelectionGB";
            this.OptionalSelectionGB.Size = new System.Drawing.Size(222, 147);
            this.OptionalSelectionGB.TabIndex = 19;
            this.OptionalSelectionGB.TabStop = false;
            this.OptionalSelectionGB.Text = "Optional Selections";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Certificate option";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Meal Options";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Learn2Prog ";
            // 
            // AllBookingSummaryGB
            // 
            this.AllBookingSummaryGB.Controls.Add(this.AvgRevenuePerBooking);
            this.AllBookingSummaryGB.Controls.Add(this.ValueOptionsChoosen);
            this.AllBookingSummaryGB.Controls.Add(this.TotalLodgingFees);
            this.AllBookingSummaryGB.Controls.Add(this.TotalRegFees);
            this.AllBookingSummaryGB.Controls.Add(this.TotalBookings);
            this.AllBookingSummaryGB.Controls.Add(this.label16);
            this.AllBookingSummaryGB.Controls.Add(this.label15);
            this.AllBookingSummaryGB.Controls.Add(this.label14);
            this.AllBookingSummaryGB.Controls.Add(this.label13);
            this.AllBookingSummaryGB.Controls.Add(this.label12);
            this.AllBookingSummaryGB.Location = new System.Drawing.Point(480, 329);
            this.AllBookingSummaryGB.Name = "AllBookingSummaryGB";
            this.AllBookingSummaryGB.Size = new System.Drawing.Size(327, 242);
            this.AllBookingSummaryGB.TabIndex = 21;
            this.AllBookingSummaryGB.TabStop = false;
            this.AllBookingSummaryGB.Text = "Booking Summary";
            // 
            // AvgRevenuePerBooking
            // 
            this.AvgRevenuePerBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvgRevenuePerBooking.Location = new System.Drawing.Point(209, 198);
            this.AvgRevenuePerBooking.Name = "AvgRevenuePerBooking";
            this.AvgRevenuePerBooking.Size = new System.Drawing.Size(100, 23);
            this.AvgRevenuePerBooking.TabIndex = 9;
            this.AvgRevenuePerBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueOptionsChoosen
            // 
            this.ValueOptionsChoosen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ValueOptionsChoosen.Location = new System.Drawing.Point(209, 167);
            this.ValueOptionsChoosen.Name = "ValueOptionsChoosen";
            this.ValueOptionsChoosen.Size = new System.Drawing.Size(100, 23);
            this.ValueOptionsChoosen.TabIndex = 8;
            this.ValueOptionsChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLodgingFees
            // 
            this.TotalLodgingFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalLodgingFees.Location = new System.Drawing.Point(209, 122);
            this.TotalLodgingFees.Name = "TotalLodgingFees";
            this.TotalLodgingFees.Size = new System.Drawing.Size(100, 23);
            this.TotalLodgingFees.TabIndex = 7;
            this.TotalLodgingFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalRegFees
            // 
            this.TotalRegFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalRegFees.Location = new System.Drawing.Point(209, 77);
            this.TotalRegFees.Name = "TotalRegFees";
            this.TotalRegFees.Size = new System.Drawing.Size(100, 23);
            this.TotalRegFees.TabIndex = 6;
            this.TotalRegFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBookings
            // 
            this.TotalBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalBookings.Location = new System.Drawing.Point(209, 40);
            this.TotalBookings.Name = "TotalBookings";
            this.TotalBookings.Size = new System.Drawing.Size(100, 23);
            this.TotalBookings.TabIndex = 5;
            this.TotalBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Average Revenue Per Booking";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Value of Options Choosen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total Lodging Fees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Total Registration Fees";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Number of bookings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "List of Programming Workshop and Registration Cost ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Locations and Lodging cost";
            // 
            // Learn2Prog_Ltd_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(819, 589);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AllBookingSummaryGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OptionalSelectionGB);
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
            this.Name = "Learn2Prog_Ltd_Form";
            this.Text = "Learn2Prog Ltd";
            this.Load += new System.EventHandler(this.Learn2Prog_Ltd_Form_Load);
            this.BookingGroupBox.ResumeLayout(false);
            this.BookingGroupBox.PerformLayout();
            this.OptionalSelectionGB.ResumeLayout(false);
            this.OptionalSelectionGB.PerformLayout();
            this.AllBookingSummaryGB.ResumeLayout(false);
            this.AllBookingSummaryGB.PerformLayout();
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
        private System.Windows.Forms.GroupBox OptionalSelectionGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox AllBookingSummaryGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AvgRevenuePerBooking;
        private System.Windows.Forms.Label ValueOptionsChoosen;
        private System.Windows.Forms.Label TotalLodgingFees;
        private System.Windows.Forms.Label TotalRegFees;
        private System.Windows.Forms.Label TotalBookings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

