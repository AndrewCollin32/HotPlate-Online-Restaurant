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
        //--------------------------------------------------------------------------------------------------------------
        public static Label totalLabelSingle;
        public static Label orderTotalLabel;
        public static Label totalLabel;
        public static FlowLayoutPanel checkoutLayout;

        public static TextBox fullnameLabelChild;
        public static TextBox emailLabelChild;
        public static MaskedTextBox phoneLabelChild;

        public static Label addressLabelChild;
        //--------------------------------------------------------------------------------------------------------------
        public checkoutPage()
        {
            InitializeComponent();

            //Assigning Labels to global variables
            //Assigns user's information
            addressLabelChild = addressTextBox;
            fullnameLabelChild = FullNameTextbox;
            emailLabelChild = emailTextBox;
            phoneLabelChild = phoneTextBox;
            
            //Assigning Labels to global variables
            //Assigns order and total labels
            totalLabelSingle = totalLeft;
            orderTotalLabel = yourOrderLabel;
            totalLabel = yourTotalLabel;
            checkoutLayout = checkoutFlowPanel;
            
            //Displays a row of credit cards
            creditCardPicture.ImageLocation = "https://www.merchantequip.com/image/?logos=v|m|a|d&height=32";
            
            //TipBox
            for (int i = 0; i <= 50; i += 5) tipBox.Items.Add(i + "%");
            tipBox.SelectedIndex = 3;
            
            //Total String
            totalLabelString.Text = "Order Total: \nTip: \nTaxes: \nDelivery Fee: \nGrand Total: ";

            //Disable HorizontalScroll
            checkoutFlowPanel.AutoScroll = false;
            checkoutLayout.HorizontalScroll.Enabled = false;
            checkoutLayout.AutoScroll = true;

        }
        //--------------------------------------------------------------------------------------------------------------
        //Change address button takes you to user settings
        private void changeAddressButton_Click(object sender, EventArgs e)
        {
            HotPlateData.previousPage = HotPlateData.checkoutPage;
            HotPlateData.userSettingsPage.BringToFront();
        }
        //--------------------------------------------------------------------------------------------------------------
        //Assigns user's data to labels in the checkout page.
        public static void UpdateCheckOutLabels()
        {
            fullnameLabelChild.Text = HotPlateData.userName;
            fullnameLabelChild.ForeColor = Color.Black;
            emailLabelChild.Text = HotPlateData.userEmail;
            phoneLabelChild.Text = HotPlateData.userPhone;

            addressLabelChild.Text = 
                HotPlateData.userCompany + " " + HotPlateData.userAddressline + ", " + HotPlateData.userCity + ", " + 
                HotPlateData.userState + " " + HotPlateData.userPostalNumber;

        }
        //--------------------------------------------------------------------------------------------------------------
        // Validates every input from the user
        public bool ValidateOrder()
        {
            if (!new Regex(@"^\w+@\w+\.com$").IsMatch(emailTextBox.Text))
            {
                new AlertBox("Email Address", "Please enter a valid email address").Show();
                return false;
            }
            if (!new Regex(@"^\d{3}-\d{3}-\d{4}$").IsMatch(phoneTextBox.Text))
            {
                new AlertBox("Phone Number", "Please enter your phone number in this format: \n000-000-0000").Show();
                return false;
            }
            if (FullNameTextbox.Text.Length == 0)
            {
                new AlertBox("Full Name", "Please enter your full name").Show();
                return false;
            }
            if (!new Regex(@"^\d{4}-\d{4}-\d{4}-\d{4}$").IsMatch(cardNumberMaskedTextBox.Text))
            {
                new AlertBox("Card Number", "Please enter a valid card number").Show();
                return false;
            }
            if (!new Regex(@"^\d{3}$").IsMatch(cwTextBox.Text))
            {
                new AlertBox("CW", "Please enter a valid CW number").Show();
                return false;
            }
            if (!new Regex(@"^(([0][1-9])|([1][012]))/\d{2}$").IsMatch(expDateLabel.Text))
            {
                new AlertBox("Expiration Date", "Please enter a EXP date for card").Show();
                return false;
            }
            return true;
        }
        //--------------------------------------------------------------------------------------------------------------
        // Connects to SQL and inserts the order to the database
        public void InsertOrderToDatabase(string order, string confirmationCode)
        {
            MySqlConnection conn = new MySqlConnection(
                "SERVER=" + HotPlateData.SQLServer + ";DATABASE=" + HotPlateData.SQLDatabaseName + 
                ";UID=" + HotPlateData.SQLusername + ";PASSWORD=" + HotPlateData.SQLPassword + ";");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO ordertable VALUES" +
                "(@confirmCode,@fullname,@total,@Time,@address,@email,@phone,@order);",
                conn);
            cmd.Parameters.AddWithValue("@confirmCode", confirmationCode);
            cmd.Parameters.AddWithValue("@fullname", FullNameTextbox.Text);
            cmd.Parameters.AddWithValue("@total", "$" + HotPlateData.grandTotal.ToString("0.00"));
            cmd.Parameters.AddWithValue("@order", order);
            cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("HH:mm:ss tt"));
            cmd.ExecuteNonQuery();
        }
        
        //--------------------------------------------------------------------------------------------------------------
        // Generates a confirmation number and opens the confirmation page
        // Validates the order and saves it to the database
        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder()) return;
            
            string confirmationCode = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
            string order = "";
            foreach (string key in HotPlateData.basket.Keys.ToArray()) {
                order = order + HotPlateData.basket[key][0] + "x " + (string)HotPlateData.basket[key][2] + " | ";
            }
            
            InsertOrderToDatabase(order, confirmationCode);

            ConfirmationPage.confirmationNumberText.Text = "Your Confirmation Number: " + confirmationCode;
            HotPlateData.previousPage = HotPlateData.confirmationPage;
            HotPlateData.confirmationPage.BringToFront();

        }
        //--------------------------------------------------------------------------------------------------------------

        private void exitButton_Click(object sender, EventArgs e)
        {
            HotPlateData.dashboardPage.BringToFront();
        }
        //--------------------------------------------------------------------------------------------------------------

        private void cwTextBox_Enter(object sender, EventArgs e)
        {
            if (cwTextBox.Text == "CW")
            {
                cwTextBox.Text = "";
                cwTextBox.ForeColor = Color.Black;
            }
        }
        //--------------------------------------------------------------------------------------------------------------

        private void cwTextBox_Leave(object sender, EventArgs e)
        {
            if (cwTextBox.Text == "")
            {
                cwTextBox.Text = "CW";
                cwTextBox.ForeColor = Color.DimGray;
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void fullNameTextBox_Enter(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "Full Name")
            {
                FullNameTextbox.Text = "";
                FullNameTextbox.ForeColor = Color.Black;
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void fullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (FullNameTextbox.Text == "")
            {
                FullNameTextbox.Text = "Full Name";
                FullNameTextbox.ForeColor = Color.DimGray;
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void tipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotPlateData.tipPercentage = int.Parse(((string)tipBox.SelectedItem).Replace("%", ""));
            Debug.WriteLine(HotPlateData.tipPercentage);
            HotPlateData.UpdateTotalAndGrandTotal();
            HotPlateData.UpdateCheckoutPage();
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void cardNumberMaskedTextBox_Enter(object sender, EventArgs e)
        {
            if (cardNumberMaskedTextBox.Text == "Card Number")
            {
                cardNumberMaskedTextBox.Mask = "0000-0000-0000-0000";
                cardNumberMaskedTextBox.Text = "";
                cardNumberMaskedTextBox.ForeColor = Color.Black;
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void cardNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (cardNumberMaskedTextBox.Text == "    -    -    -")
            {
                cardNumberMaskedTextBox.Mask = null;
                cardNumberMaskedTextBox.Text = "Card Number";
                cardNumberMaskedTextBox.ForeColor = Color.DimGray;
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
        private void expDateLabel_Enter(object sender, EventArgs e)
        {
            if (expDateLabel.Text == "MM/YY")
            {
                expDateLabel.ForeColor = Color.Black;
                expDateLabel.Text = "";
                expDateLabel.Mask = "00/00";
            }
        }
        //--------------------------------------------------------------------------------------------------------------
        
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