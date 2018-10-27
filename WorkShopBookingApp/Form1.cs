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
    public partial class Learn2Prog_Ltd_Form : Form
    {
        int Trials = 3;

        //used to house booking information, that would later be used to calculate
        //the summary
        List<decimal> ProgramFeeSummary = new List<decimal>();
        List<decimal> LocationFeeSummary = new List<decimal>();
        List<decimal> FoodFeeSummary = new List<decimal>();
        List<decimal> CertificateFeeSummary = new List<decimal>();
        //-------------------------------------------------

        //declared temporary list to hold values.
        List<decimal> TempProgramFeeSummary = new List<decimal>();
        List<decimal> TempLocationFeeSummary = new List<decimal>();
        List<decimal> TempFoodFeeSummary = new List<decimal>();
        List<decimal> TempCertificateFeeSummary = new List<decimal>();


        //--------------------------------------------------
        //list declared to hold the price of the workshop,location,food and certificate
        List<decimal> ProgramFee = new List<decimal> { 1200m,1000m,1500m,1800m,599m };
       
        List<decimal> LocationFee = new List<decimal> { 150m,225m,175m,305m,135m,89m };
        List<decimal> FoodFee = new List<decimal> { 39.50m,27.50m, 12.50m,0.0m};
        List<decimal> CertFee = new List<decimal> {0.0m, 29.95m };

        //-----------------------------------------------------

        List<string> LocationLocation = new List<string> {"Cork €150", "Dublin €225", "Galway €175",
                                                        "Belmullet €305", "Limerick €135","Wexford €89" };

        List<string> ProgramProgram = new List<string> {"Asp.NET with C# (4 Days) €1,200",
                                                        "Winforms with C# (3 Days) €1,000",
                                                    ".NET Prog Using C# Part1 (4 Days) €1,500",
                                                        ".NET Prog Using C# Part2 (4 Days) €1,800",
                                                            "Digital Detox  (1 Day) €599" };

        

       // List<string> FoodFood = new List<string> { "FullBoard", "HalfBoard", "Breakfast","No food" };
        //List<string> CertCert = new List<string> { "Digital Cert(Free)", "Printed Cert" };

        const string FULLBOARD = "FullBoard";
        const string HALFBOARD = "HalfBoard";
        const string BREAKFAST = "BreakFast Only";
        const string NOFOOD = "No Meal Required";

        const string DIGITALCERTIFICATE = "Digital Certificate(Free)";
        const string PRINTEDCERTIFICATE = "Printed Certificate";

        int ProgIndex, LocIndex, MealIndex, CertIndex;

        //Our Calculate declaration for display button
        decimal CalculateTotal;
        decimal CalculateProg, CalculateLoc, CalculateFood, CalculateCert;


        string MessageOut;

       
        public Learn2Prog_Ltd_Form()
        {
            InitializeComponent();
        }

        private void Learn2Prog_Ltd_Form_Load(object sender, EventArgs e)
        {

            LocationList.Visible = false;
            ProgramList.Visible = false;
            BookingGroupBox.Visible = false;
            DisplayButton.Visible = false;
            ClearButton.Visible = false;
            BookingButton.Visible = false;
            SummaryButton.Visible = false;
            OptionalSelectionGB.Visible = false;

            SummaryButton.Enabled = false;
            BookingButton.Enabled = false;
            ClearButton.Enabled = false;    





            MealList.SelectedIndex = 3;
            CertificateList.SelectedIndex = 0;


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
            Validpassword = "#";
            
            
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

            

            if(ProgramList.SelectedIndex !=-1)
            {
                
                if(LocationList.SelectedIndex !=-1)
                {
                    ProgIndex = ProgramList.SelectedIndex;
                    LocIndex = LocationList.SelectedIndex;

                    MealIndex = MealList.SelectedIndex;
                    CertIndex = CertificateList.SelectedIndex;


                    ProgramSummary.Text = ProgramProgram.ElementAt(ProgIndex);
                    LocationSummary.Text = LocationLocation.ElementAt(LocIndex);
                    //MealOptionSummary.Text = FoodFood.ElementAt(MealIndex);
                    //CertificateChoosen.Text = CertCert.ElementAt(CertIndex);

                    

                    CalculateProg = ProgramFee.ElementAt(ProgIndex);
                    TempProgramFeeSummary.Add(CalculateProg);

                    CalculateLoc = LocationFee.ElementAt(LocIndex);
                    TempLocationFeeSummary.Add(CalculateLoc);

                    CalculateFood = FoodFee.ElementAt(MealIndex);
                    TempFoodFeeSummary.Add(CalculateFood);

                    CalculateCert = CertFee.ElementAt(CertIndex);
                    TempCertificateFeeSummary.Add(CalculateCert);



                    CalculateTotal = CalculateProg + CalculateLoc + CalculateFood + CalculateCert;
                    TotalCost.Text = CalculateTotal.ToString("C1");

                    ClearButton.Enabled = true;
                    BookingButton.Enabled = true;
                }
                else { MessageBox.Show("Please Select a Location","Invalid Argument", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); LocationList.Focus(); }


            }
            else { MessageBox.Show("Please Select a Program","Invalid Argument", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);ProgramList.Focus(); }


                    switch (MealIndex)
                    {
                        case 0:
                            MealOptionSummary.Text = FULLBOARD;
                            break;
                        case 1:
                            MealOptionSummary.Text = HALFBOARD;
                            break;
                        case 2:
                            MealOptionSummary.Text = BREAKFAST;
                            break;
                        default:
                            MealOptionSummary.Text = NOFOOD;
                            break;
                    }

                    switch(CertIndex)
                    {
                        case 0:
                            CertificateChoosen.Text = DIGITALCERTIFICATE;
                            break;
                        case 1:
                            CertificateChoosen.Text = PRINTEDCERTIFICATE;
                            break;
                    }

        }


        private void BookingButton_Click(object sender, EventArgs e)
        {

            SummaryButton.Enabled = true;

            ProgramFeeSummary.Add(TempProgramFeeSummary[0]);
            LocationFeeSummary.Add(TempLocationFeeSummary[0]);
            FoodFeeSummary.Add(TempFoodFeeSummary[0]);
            CertificateFeeSummary.Add(TempCertificateFeeSummary[0]);


            TempProgramFeeSummary.Clear();
            TempLocationFeeSummary.Clear();
            TempFoodFeeSummary.Clear();
            TempCertificateFeeSummary.Clear();


            MessageOut = ("Your Booking Informations:\n"+"Program: "+ProgramSummary.Text
                                +"\n"+ "Location: "+LocationSummary.Text+ "\n"+ "Amount Due: "+ TotalCost.Text);

            MessageBox.Show(MessageOut,"Booking Confirmation - Learn2Prog Ltd", 
                                MessageBoxButtons.OK, MessageBoxIcon.Question);


            


        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {



        }


    }
            

}
