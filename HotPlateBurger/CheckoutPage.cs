using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class checkoutPage : UserControl
    {
        public static Label totalLabelSingle;
        public static Label orderTotalLabel;
        public static Label totalLabel;
        public static FlowLayoutPanel checkoutLayout;

        public static TextBox fullnameLabelChild;
        public static TextBox emailLabelChild;
        public static MaskedTextBox phoneLabelChild;
        public checkoutPage()
        {
            InitializeComponent();

            fullnameLabelChild = FullNameTextbox;
            emailLabelChild = emailTextBox;
            phoneLabelChild = phoneTextBox;
            
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

            checkoutFlowPanel.AutoScroll = false;
            checkoutLayout.HorizontalScroll.Enabled = false;
            checkoutLayout.AutoScroll = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!new Regex(@"^\w+@\w+\.com$").IsMatch(emailTextBox.Text))
            {
                new AlertBox("Email Address", "Please enter a valid email address").Show();
                return;
            }
            if (!new Regex(@"^\d{3}-\d{3}-\d{4}$").IsMatch(phoneTextBox.Text))
            {
                new AlertBox("Phone Number", "Please enter your phone number in this format: \n000-000-0000").Show();
                return;
            }
            if (FullNameTextbox.Text.Length == 0)
            {
                new AlertBox("Full Name", "Please enter your full name").Show();
                return;
            }
            if (!new Regex(@"^\d{4}-\d{4}-\d{4}-\d{4}$").IsMatch(cardNumberMaskedTextBox.Text))
            {
                new AlertBox("Card Number", "Please enter a valid card number").Show();
                return;
            }
            if (!new Regex(@"^\d{3}$").IsMatch(cwTextBox.Text))
            {
                new AlertBox("CW", "Please enter a valid CW number").Show();
                return;
            }
            if (!new Regex(@"^(([0][1-9])|([1][012]))/\d{2}$").IsMatch(expDateLabel.Text))
            {
                new AlertBox("Expiration Date", "Please enter a EXP date for card").Show();
                return;
            }

            string confirmationCode = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
            Debug.WriteLine(totalLabel.Text + " " + totalLeft.Text);
            string order = "";
            String[] key = Form1.basket.Keys.ToArray();
            for (int i = 0; i < Form1.basket.Count; i++)
            {
                order = order + Form1.basket[key[i]][0] + "x " + (string)Form1.basket[key[i]][2] + " | ";
            }
            
            MySqlConnection conn = new MySqlConnection("SERVER=" + Form1.SQLServer + ";DATABASE=" + Form1.SQLDatabaseName + ";UID=" + Form1.SQLusername + ";PASSWORD=" + Form1.SQLPassword + ";");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ordertable VALUES(@confirmCode,@fullname,@total,@Time,@address,@email,@phone,@order);", conn);
            cmd.Parameters.AddWithValue("@confirmCode", confirmationCode);
            cmd.Parameters.AddWithValue("@fullname", FullNameTextbox.Text);
            cmd.Parameters.AddWithValue("@total", "$" + Form1.gtotal.ToString("0.00"));
            cmd.Parameters.AddWithValue("@order", order);
            cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("HH:mm:ss tt"));
            cmd.ExecuteNonQuery();

            ConfirmationPage.confirmationNumberText.Text = "Your Confirmation Number: " + confirmationCode;
            Form1.conPage.BringToFront();

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
            if (FullNameTextbox.Text == "Full Name")
            {
                FullNameTextbox.Text = "";
                FullNameTextbox.ForeColor = Color.Black;
            }
        }

        private void fullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "")
            {
                FullNameTextbox.Text = "Full Name";
                FullNameTextbox.ForeColor = Color.DimGray;
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