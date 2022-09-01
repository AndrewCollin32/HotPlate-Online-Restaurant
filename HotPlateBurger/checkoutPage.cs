using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class checkoutPage : UserControl
    {
        public static Label totalLabelSingle;
        public static Label orderTotalLabel;
        public static Label totalLabel;
        public static FlowLayoutPanel checkoutLayout;
        public checkoutPage()
        {
            InitializeComponent();

            totalLabelSingle = totalLeft;
            orderTotalLabel = yourOrderLabel;
            totalLabel = yourTotalLabel;
            checkoutLayout = checkoutFlowPanel;
            
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

        private void cardNumberMaskedTextBox_Enter(object sender, EventArgs e)
        {
            if (cardNumberMaskedTextBox.Text == "Card Number")
            {
                cardNumberMaskedTextBox.Mask = "0000-0000-0000-0000";
                cardNumberMaskedTextBox.Text = "";
                cardNumberMaskedTextBox.ForeColor = Color.Black;
            }
        }

        private void cardNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (cardNumberMaskedTextBox.Text == "    -    -    -")
            {
                cardNumberMaskedTextBox.Mask = null;
                cardNumberMaskedTextBox.Text = "Card Number";
                cardNumberMaskedTextBox.ForeColor = Color.DimGray;
            }
        }
        
        private void expDateLabel_Enter(object sender, EventArgs e)
        {
            if (expDateLabel.Text == "MM/YY")
            {
                expDateLabel.ForeColor = Color.Black;
                expDateLabel.Text = "";
                expDateLabel.Mask = "00/00";
            }
        }

        private void expDateLabel_Leave(object sender, EventArgs e)
        {
            if (expDateLabel.Text == "  /  ")
            {
                expDateLabel.ForeColor = Color.DimGray;
                expDateLabel.Text = "MM/YY";
                expDateLabel.Mask = "";
            }
        }
    }
}