using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class checkoutPage : UserControl
    {
        public static Label totalLabelSingle;
        public static Label orderTotalLabel;
        public static Label totalLabel;
        public checkoutPage()
        {
            InitializeComponent();

            totalLabelSingle = totalLeft;
            orderTotalLabel = yourOrderLabel;
            totalLabel = yourTotalLabel;
            
            pictureBox2.ImageLocation = "https://www.merchantequip.com/image/?logos=v|m|a|d&height=32";
            tipBox.Items.Add("0%");
            tipBox.Items.Add("5%");
            tipBox.Items.Add("10%");
            tipBox.Items.Add("15%");
            tipBox.Items.Add("20%");
            tipBox.Items.Add("25%");
            tipBox.Items.Add("30%");
            tipBox.Items.Add("35%");
            tipBox.Items.Add("40%");
            tipBox.Items.Add("45%");
            tipBox.Items.Add("50%");

            tipBox.SelectedIndex = 3;
            
            totalLabelString.Text = "Order Total: \nTip: \nTaxes: \nDelivery Fee: \nGrand Total: ";
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

        private void cwTextBox_Enter(object sender, EventArgs e)
        {
            if (cwTextBox.Text == "CW")
            {
                cwTextBox.Text = "";
                cwTextBox.ForeColor = Color.Black;
            }
        }

        private void cwTextBox_Leave(object sender, EventArgs e)
        {
            if (cwTextBox.Text == "")
            {
                cwTextBox.Text = "CW";
                cwTextBox.ForeColor = Color.DimGray;
            }
        }

        private void expDateTextBox_Enter(object sender, EventArgs e)
        {
            if (expDateTextBox.Text == "MM/YY")
            {
                expDateTextBox.Text = "";
                expDateTextBox.ForeColor = Color.Black;
            }
        }

        private void expDateTextBox_Leave(object sender, EventArgs e)
        {
            if (expDateTextBox.Text == "")
            {
                expDateTextBox.Text = "MM/YY";
                expDateTextBox.ForeColor = Color.DimGray;
            }
        }

        private void fullNameTextBox_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Full Name")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void fullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Full Name";
                textBox4.ForeColor = Color.DimGray;
            }
        }

        private void tipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.tipPercentage = int.Parse(((string)tipBox.SelectedItem).Replace("%", ""));
            Debug.WriteLine(Form1.tipPercentage);
            Form1.updateBasket();
        }
        
    }
}