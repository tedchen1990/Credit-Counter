using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit_Counter
{
    public partial class Credit_Counter : Form
    {
        public Credit_Counter()
        {
            InitializeComponent();
        }

        #region Variables

        int Coin_value; //Click the picture of coins to get the value
        int Count; //The ccumulative number for clicking the coins
        double Cost_Credits; // The value of Cost credits which have to setting before clicking coins

        #endregion
        
        #region Clicking events of coins 
        private void pb_oneP_Click(object sender, EventArgs e)
        {
            Coin_value = 1; // This is 1p, and the value is 1 as a mark 
            Cmethod(Coin_value); //Put the value of 1p Coins into the method,
        }

        private void pb_twoP_Click(object sender, EventArgs e)
        {
            Coin_value = 2;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_fiveP_Click(object sender, EventArgs e)
        {
            Coin_value = 5;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_tenP_Click(object sender, EventArgs e)
        {
            Coin_value = 10;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_twentyP_Click(object sender, EventArgs e)
        {
            Coin_value = 20;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_fiftyP_Click(object sender, EventArgs e)
        {
            Coin_value = 50;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_onePound_Click(object sender, EventArgs e)
        {
            Coin_value = 100;
            Cmethod(Coin_value); //Likewise
        }

        private void pb_twoPound_Click(object sender, EventArgs e)
        {
            Coin_value = 200;
            Cmethod(Coin_value); //Likewise
        }

        #endregion

        #region Resetting event
        private void bt_Reset_Click(object sender, EventArgs e) //Reset the text initial status
        {
            //Clear the textboxs of left
            txb_valuePence.Text = "0";
            txb_valuePound.Text = "0.00";
            txb_CostCredits.Text = "0";
            txb_Credits.Text = "0";

            //Clear the lable of right which are the number for clicking the coins
            lb_oneP_num.Text = lb_twoP_num.Text =
            lb_fiveP_num.Text = lb_tenP_num.Text =
            lb_twentyP_num.Text = lb_fiftyP_num.Text =
            lb_onePound_num.Text = lb_twoPound_num.Text = "0";
        }
        #endregion

        #region Clicking Method 
        private void Cmethod(int Coin_value) //Use the Coin_value into the method for counting of each clicking events and display on interface
        {
            double.TryParse(txb_CostCredits.Text.Trim(), out Cost_Credits);//Get the values to Cost_Credits from the textbox of txb_CostCredits of interface and avoid a failed convert 
            if (Cost_Credits > 0) //The Cost_value must be greater than 0 and before the method start
            {
                switch (Coin_value)
                {

                }
            }
            else // Show the prompt if the Cost_value is less than 0 
            {
                MessageBox.Show("You have not set the cost of a credit !" + "\n" + "\n" + "Please set a cost which must be greater than 0 and have to be a number !");
                txb_CostCredits.Focus(); // Return the cursor to the textbox of Cost Credits
            }
        }
        #endregion


    }
}
