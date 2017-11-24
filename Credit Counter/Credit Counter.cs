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
        int Count; //The ccumulative number for Clicking the coins

        #endregion

        #region The clicking events of coins 

        private void method() // The counting method for each clicking events
        { }

        private void pb_oneP_Click(object sender, EventArgs e)
        {
            Coin_value = 1; 
        }

        private void pb_twoP_Click(object sender, EventArgs e)
        {
            Coin_value = 2;
        }

        private void pb_fiveP_Click(object sender, EventArgs e)
        {
            Coin_value = 5;
        }

        private void pb_tenP_Click(object sender, EventArgs e)
        {
            Coin_value = 10;
        }

        private void pb_twentyP_Click(object sender, EventArgs e)
        {
            Coin_value = 20;
        }

        private void pb_fiftyP_Click(object sender, EventArgs e)
        {
            Coin_value = 50;
        }

        private void pb_onePound_Click(object sender, EventArgs e)
        {
            Coin_value = 100;
        }

        private void pb_twoPound_Click(object sender, EventArgs e)
        {
            Coin_value = 200;
        }

        #endregion

        #region The reset event
        private void bt_Reset_Click(object sender, EventArgs e)// Reset the text initial status
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
    }
}
