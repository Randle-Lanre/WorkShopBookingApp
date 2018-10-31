using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace for learn2prog app
namespace Learn2Prog_Ltd
{
    public partial class Learn2Prog_Ltd_Form : Form
    {
        //maximum failed login attemps is set to 3
        int Trials = 3;

        //the string password stores the user input(password) while valid password stores the
        //correct password, which would later be matched to see if there are the same
        string Password;
        string Validpassword;


       //=====================================================================
       // The lists below (indicated by Begining and end)                       
       // list four categories of list the first section stores the 
       // user booking details, when the book button is clicked, the second   
       // is a temporay list that holds the data until the book button is 
       // clicked, then the data is added to the summary and hen cleared
       // the two other categories of list containing the location and price
       // of the workshop, when a user selects an item, the index would be 
       // retained and runed again the two list.
       //=======================================================================
     //BEGINING-----------------------------------------------------------------------------------   
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
        
        //this is used to calculate the days of the program
        List<int> days = new List<int> { 4, 3, 4, 4, 1 };

        //-----------------------------------------------------

        List<string> ListOfLocations = new List<string> {"Cork", "Dublin", "Galway",
           /* lis of locations    */                     "Belmullet", "Limerick","Wexford" };

        List<string> ListOfPrograms = new List<string> {"Asp.NET with C# (4 Days) €1,200",
                                                        "Winforms with C# (3 Days) €1,000",
             /* list of workshops  */                   ".NET Prog Using C# Part1 (4 Days) €1,500",
                                                        ".NET Prog Using C# Part2 (4 Days) €1,800",
                                                            "Digital Detox  (1 Day) €599" };

      //END--------------------------------------------------------------------------  

       
        //meal options to be used in the switch/case 
        const string FULLBOARD = "FullBoard";
        const string HALFBOARD = "HalfBoard";
        const string BREAKFAST = "BreakFast Only";
        const string NOFOOD = "No Meal Required";

        //certificate to be used in the switch/case
        const string DIGITALCERTIFICATE = "Digital Certificate(Free)";
        const string PRINTEDCERTIFICATE = "Printed Certificate";

        //used to hold index values for the program, location/lodging,meal and certificate
        int ProgIndex, LocIndex, MealIndex, CertIndex;

        //used in calculating the lodging and meal cost in the display button
        decimal FirstDayLodgingCost, LodgingDurationOfProgram;
        decimal FirstDayMeal, NumberOfMeals;

        //Our Calculate declaration for display button
        decimal CalculateTotal;
        decimal CalculateProg, CalculateLoc, CalculateFood, CalculateCert;


        //login warning message
        string WarningMessage;

        //format the output string that appears in a message box when the user 
        //clicks the book button
        string MessageOut;

        //used to calculate the average revenue 
        decimal AvgRevenueCalculated;


        public Learn2Prog_Ltd_Form()
        {
            InitializeComponent();
        }

       
        //runs the following codes when the form loads
        private void Learn2Prog_Ltd_Form_Load(object sender, EventArgs e)
        {
            /* makes the listbox of the location, program, meal option
             * ,certificate options and all other buttons aside login and exit buttons
             *  invisible when the program is started
             */

            BookingDetailsGB.Visible = false;
            DisplayButton.Visible = false;
            ClearButton.Visible = false;
            BookingButton.Visible = false;
            ExitButton.Visible = false;
            SummaryButton.Visible = false;
            OptionalSelectionGB.Visible = false;
            AllBookingSummaryGB.Visible = false;
            WorkshopAndLocationGB.Visible = false;

            //the summary, book and clear button are disabled
            SummaryButton.Enabled = false;
            BookingButton.Enabled = false;
            ClearButton.Enabled = false;
            

            //sets access keys for the buttons
            DisplayButton.Text = "&Display";
            ClearButton.Text = "&Clear";
            BookingButton.Text = "&Book";
            SummaryButton.Text = "&Summary";
            LoginButton.Text = "&Login";
            ExitButton.Text = "Exit";

            //sets focus where the user would enter a password
            this.ActiveControl = UserPassInput;

            UserPassInput.PasswordChar = '*';





            //this makes a default selection for the meal option and certificate
            MealList.SelectedIndex = 3;
            CertificateList.SelectedIndex = 0;


        }



        //event handler for the login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            
            Password = UserPassInput.Text; //gets the user input(password)
            
            Validpassword = "iLoveVisualC#";//correct password
            
            //if password entered is incorrect and the user still has more than zero attempts
            if (!Password.Equals(Validpassword) && Trials > 0)
            {
                
                Trials--;//decrements the number of attempts on each trial
                
                 WarningMessage = "Wrong Password: you have " + Trials + " attempts left";
                MessageBox.Show(WarningMessage,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                UserPassInput.Focus();
                UserPassInput.SelectAll();
                
            }
            else if (!Password.Equals("iLoveVisualC#") && Trials == 0)//if the user doesn't meet the 
                                                                      //the two conditions                          
            {
                MessageBox.Show("Too Many Wrong Passwords, Exiting now","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                
                //enables the following
                WorkshopAndLocationGB.Visible = true;//workshop Groupbox
                BookingDetailsGB.Visible = true;//booking details groupbox
                DisplayButton.Visible = true;
                ClearButton.Visible = true;
                ExitButton.Visible = true;
                BookingButton.Visible = true;
                SummaryButton.Visible = true;
                OptionalSelectionGB.Visible = true;//option selection groupbox

                //makes the password screen invisible if password is correct
                PasswordPanel.Visible = false;


            }

           
        }
        //displays the result of customer selection when clicked
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            
            
            //checks to see if customer made a selection from the workshops
            if(ProgramList.SelectedIndex !=-1)
            {
               //checks to see if customer selected a location from the groupbox 
                if(LocationList.SelectedIndex !=-1)
                {
                   //gets the index of the selected workshop 
                    ProgIndex = ProgramList.SelectedIndex;
                    //gets the index of the selected workshop
                    LocIndex = LocationList.SelectedIndex;
                    //gets the index of the selected meal option
                    MealIndex = MealList.SelectedIndex;
                    //gets the index of the selected certificate option
                    CertIndex = CertificateList.SelectedIndex;

                    //displays the appropriate workshop, using the index gotten
                    ProgramSummary.Text = ListOfPrograms.ElementAt(ProgIndex);
                    
                    //displays the location and the lodging cost and adds it to a temporary lsit
                    LodgingDurationOfProgram = LocationFee.ElementAt(LocIndex);
                    FirstDayLodgingCost = days.ElementAt(ProgIndex);
                    CalculateLoc = LodgingDurationOfProgram * FirstDayLodgingCost;
                    TempLocationFeeSummary.Add(CalculateLoc);
                    LocationSummary.Text = ListOfLocations.ElementAt(LocIndex)+" " +CalculateLoc.ToString("C");
                    
                    

                    
                    //displays the selected program and stores the data in a temporary list
                    CalculateProg = ProgramFee.ElementAt(ProgIndex);
                    TempProgramFeeSummary.Add(CalculateProg);

                    

                    //displays the meal option and saves the data in a temporary list
                    FirstDayMeal = FoodFee.ElementAt(MealIndex);
                    NumberOfMeals = days.ElementAt(ProgIndex);
                    CalculateFood =FirstDayMeal*NumberOfMeals ;
                    TempFoodFeeSummary.Add(CalculateFood);

                    //displays the certificate option chosen and stores the information 
                    CalculateCert = CertFee.ElementAt(CertIndex);
                    TempCertificateFeeSummary.Add(CalculateCert);

                   
                    //calculates and displays the total cost 
                    CalculateTotal = CalculateProg + CalculateLoc + CalculateFood + CalculateCert;
                    TotalCost.Text = CalculateTotal.ToString("C");

                    //enables the following buttons 
                    ClearButton.Enabled = true;//clear button
                    BookingButton.Enabled = true;//book button
                    //disables the following button
                    DisplayButton.Enabled = false;//display button
                }
                else { MessageBox.Show("Please Select a Location","Invalid Argument", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning); LocationList.Focus(); }


            }
            else { MessageBox.Show("Please Select a Program","Invalid Argument", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);ProgramList.Focus(); }


                    switch (MealIndex)/*checks to see if the selected meal index
                                      matches any of the following cases    */ 
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
                        default://if it doesnt match any case, it automatically goes to default
                            MealOptionSummary.Text = NOFOOD;
                            break;
                    }

                    switch(CertIndex)//checks to see if selected certificate index matches any of the cases
                    {
                        case 0:
                            CertificateChoosen.Text = DIGITALCERTIFICATE;
                            break;
                        case 1:
                            CertificateChoosen.Text = PRINTEDCERTIFICATE;
                            break;
                    }

        }

        //event handler for the book button
        private void BookingButton_Click(object sender, EventArgs e)
        {

            SummaryButton.Enabled = true;
            //temporary data is moved to the summary list 
            ProgramFeeSummary.Add(TempProgramFeeSummary[0]);
            LocationFeeSummary.Add(TempLocationFeeSummary[0]);
            FoodFeeSummary.Add(TempFoodFeeSummary[0]);
            CertificateFeeSummary.Add(TempCertificateFeeSummary[0]);

            //clears all the temporary list when the the display button is clicked
            //to avoid duplication of the data
            TempProgramFeeSummary.Clear();
            TempLocationFeeSummary.Clear();
            TempFoodFeeSummary.Clear();
            TempCertificateFeeSummary.Clear();

            //displays the summary of the booking
            MessageOut = ("Your Booking Informations:\n"+"Program: "+ProgramSummary.Text
                                +"\n"+ "Location: "+LocationSummary.Text+ "\n"+ "Amount Due: "+ TotalCost.Text);

            MessageBox.Show(MessageOut,"Booking Confirmation - Learn2Prog Ltd", 
                                MessageBoxButtons.OK, MessageBoxIcon.Question);


            


        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            
            //displayes the number of booking 
            TotalBookings.Text = ((int)ProgramFeeSummary.Count()).ToString();

            //shows the total registration fees of all customers
            TotalRegFees.Text = (ProgramFeeSummary.Sum()).ToString("C");

            //shows the total lodging cost, taking the number of days into account
            TotalLodgingFees.Text = (LocationFeeSummary.Sum()).ToString("C");

            //displays the sum total of the options choosen by all customers
            ValueOptionsChoosen.Text = ((FoodFeeSummary.Sum()) + (CertificateFeeSummary.Sum())).ToString("C");

            //----------calculates and displays the average revenue per booking-----------------
           AvgRevenueCalculated = (ProgramFeeSummary.Sum() + LocationFeeSummary.Sum()
                                         + FoodFeeSummary.Sum() + CertificateFeeSummary.Sum())
                                         /( ProgramFeeSummary.Count());

            AvgRevenuePerBooking.Text = AvgRevenueCalculated.ToString("C");
            //-----------------------------------------------------------------------------------

            //disables the following group boxes
            AllBookingSummaryGB.Visible = true;//groupbox containing compulsory selections
            BookingDetailsGB.Visible = false;//groupbox containing optional selections

        }

        //the clear button clears the display of the program
        private void ClearButton_Click(object sender, EventArgs e)
        {
                   
            DisplayButton.Enabled = true;//enables display button
            BookingButton.Enabled = false;//disables book button
            AllBookingSummaryGB.Visible = false;
            BookingDetailsGB.Visible = true;
            
            
            //reverts the details shown by clicking the display button back to an empty string
            ProgramSummary.Text = "";
            LocationSummary.Text = "";
            MealOptionSummary.Text = "";
            CertificateChoosen.Text = "";
            TotalCost.Text = "";

            //summary data is reverted back to an empty string
            TotalBookings.Text = "";
            TotalRegFees.Text = "";
            TotalLodgingFees.Text = "";
            ValueOptionsChoosen.Text = "";
            AvgRevenuePerBooking.Text = "";


            //reverts the selection the program and the location to "no selection"
            ProgramList.SelectedIndex = -1;
            LocationList.SelectedIndex = -1;
            
            //reverts the list of meal options and certificate option to their default values
            MealList.SelectedIndex = 3;
            CertificateList.SelectedIndex = 0;             
            
        }

        //this closes the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
