using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShopBookingApp
{
    public partial class Form1 : Form
    {
        int Trials = 3;


        List<decimal> ProgramFeeSummary = new List<decimal>();
        List<decimal> LocationFeeSummary = new List<decimal>();
        List<decimal> FoodFeeSummary = new List<decimal>();
        List<decimal> CertificateFeeSummary = new List<decimal>();
        //-------------------------------------------------

        List<decimal> ProgramFee = new List<decimal> { 1200m,1000m,1500m,1800m,599m };
        List<decimal> LocationFee = new List<decimal> { 150m,225m,175m,305m,135m,89m };
        List<decimal> FoodFee = new List<decimal> { 39.50m,27.50m, 12.50m};
        List<decimal> CertFee = new List<decimal> {0.0m, 29.95m };

        //-----------------------------------------------------

        List<string> LocationLocation = new List<string> {"Cork", "Dublin", "Galway",
                                                        "Belmullet", "Limerick","Wexford" };

        List<string> ProgramProgram = new List<string> {"Asp.NET with C#","Winforms with C#",
                                                    ".NET Prog Using C#",".NET Prog Using C#",
                                                            "Digital Detox" };

        List<string> FoodFood = new List<string> { "FullBoard", "HalfBoard", "Breakfast" };
        List<string> CertCert = new List<string> { "Digital Cert(Free)", "Printed Cert" };


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocationList.SelectedIndex != -1) { MessageBox.Show("Please Select an item"); }
        }






        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string Password;
            string Validpassword;
            Password = UserPassInput.Text;
            UserPassInput.PasswordChar = '*';
            Validpassword = "iLoveVisualC#";
            
            
            if (!Password.Equals(Validpassword) && Trials > 1)
            {

                Trials--;
                MessageBox.Show("Wrong Password: you have " + Trials + " trials left");
                UserPassInput.Focus();
                UserPassInput.SelectAll();
                
            }
            else if (!Password.Equals("iLoveVisualC#") && Trials == 1)
            {
                MessageBox.Show("Too Many Wrong Passwords, Exiting now");
                this.Close();
            }
            else
            {
                MessageBox.Show("Welcome");
                LocationList.Visible = true;
               // MealList.Visible = true;
                ProgramList.Visible = true;
                //CertificateList.Visible = true;
                BookingGroupBox.Visible = true;
                DisplayButton.Visible = true;
                ClearButton.Visible = true;
                BookingButton.Visible = true;
                SummaryButton.Visible = true;
                //listBoxUserSummary.Visible = true;
               // DetailsTitleLabel.Visible = true;
                OptionalSelectionGB.Visible = true;

            }

           
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            int ProgIndex, LocIndex, MealIndex, CertIndex;

            // listBoxUserSummary.Items.Add(ProgramList.SelectedItem);
            //listBoxUserSummary.Items.Add(LocationList.SelectedItem);
            //listBoxUserSummary.Items.Add(MealList.SelectedItem);
            //listBoxUserSummary.Items.Add(CertificateList.SelectedItem);

            ProgIndex = ProgramList.SelectedIndex;
            LocIndex = LocationList.SelectedIndex;
            MealIndex = MealList.SelectedIndex;
            CertIndex = CertificateList.SelectedIndex;

            //LocationSummary.Text = (LocationFee.ElementAt(LocIndex)).ToString();
            ProgramSummary.Text = ProgramProgram.ElementAt(ProgIndex);
            LocationSummary.Text = LocationLocation.ElementAt(LocIndex);
            MealOptionSummary.Text = FoodFood.ElementAt(MealIndex);
            CertificateChoosen.Text = CertCert.ElementAt(CertIndex);


            decimal CalculateTotal;
            decimal CalculateProg, CalculateLoc, CalculateFood, CalculateCert;

            CalculateProg = ProgramFee.ElementAt(ProgIndex);
            CalculateLoc = LocationFee.ElementAt(LocIndex);
            CalculateFood = FoodFee.ElementAt(MealIndex);
            CalculateCert = CertFee.ElementAt(CertIndex);

            CalculateTotal = CalculateProg + CalculateLoc + CalculateFood + CalculateCert;
            TotalCost.Text = CalculateTotal.ToString("C");
            
            
            

            
            

        }
    }
}
