using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class checkoutPage : UserControl
    {
        public checkoutPage()
        {
            InitializeComponent();
            pictureBox2.ImageLocation = "https://www.merchantequip.com/image/?logos=v|m|a|d&height=32";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1.db.BringToFront();
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (cardBox.Text == "Card Number")
            {
                cardBox.Text = "";
                cardBox.ForeColor = Color.Black;
            }
        }

        private void cardBox_Leave_1(object sender, EventArgs e)
        {
            if (cardBox.Text == "")
            {
                cardBox.Text = "Card Number";
                cardBox.ForeColor = Color.DimGray;
            }
        }
    }
}