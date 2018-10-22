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

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           MessageBox.Show(ProgramList.SelectedItem.ToString());
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
            Validpassword = "iLoveVisualC#";
            
            if (!Password.Equals(Validpassword) && Trials > 0)
            {

                Trials--;
                MessageBox.Show("wrong Password you have " + Trials + "Trials left");
                UserPassInput.Focus();
                UserPassInput.SelectAll();
                
            }
            else if (!Password.Equals("iLoveVisualC#") && Trials == 1)
            {
                MessageBox.Show("Too Many Wrong Passwords");
                this.Close();
            }
            else
            {
                MessageBox.Show("Welcome");

            }

            

        }
    }
}
