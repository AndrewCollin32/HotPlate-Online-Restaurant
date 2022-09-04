using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class UserSettingsPage : UserControl
    {
        //--------------------------------------------------------------------------------------------------------------
        //An array that holds every state's acronyms in the U.S.
        public static string[] stateArray =
        {
            "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL","GA",
            "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO","MT",
            "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "CM", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD",
            "TN", "TX", "TT", "UT", "VT", "VA", "VI", "WA", "WV", "WI", "WY"
        };
        
        //--------------------------------------------------------------------------------------------------------------
        // Initializes the UserSettingsPage, adds all the states to the combobox and calls fillEverything()
        public UserSettingsPage()
        {
            InitializeComponent();

            stateComboBox.Items.Add("AL");
            foreach (string s in stateArray)
            {
                stateComboBox.Items.Add(s);
            }
            FillUserSettingsLabel();
        }
        
        //--------------------------------------------------------------------------------------------------------------
        // Fills all the textboxes with existing information
        public void FillUserSettingsLabel()
        {
            fullNameTextBox.Text = HotPlateData.userName;
            emailTextBox.Text = HotPlateData.userEmail;
            phoneTextBox.Text = HotPlateData.userPhone;

            companyTextBox.Text = HotPlateData.userCompany;
            addressTextBox.Text = HotPlateData.userAddressline;
            stateComboBox.Text = HotPlateData.userState;
            cityTextBox.Text = HotPlateData.userCity;
            postalCodeTextBox.Text = HotPlateData.userPostalNumber;
            notesTextBox.Text = HotPlateData.userNotes;
        }
        
        //--------------------------------------------------------------------------------------------------------------
        //Takes users to the previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            FillUserSettingsLabel();
            HotPlateData.previousPage.BringToFront();
        }

        //--------------------------------------------------------------------------------------------------------------
        //Validates and saves all the data to Form1.cs and takes the user back to the previous page.
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserSettingInput()) 
            {
                SaveUserSettings();
                checkoutPage.UpdateCheckOutLabels();
                HotPlateData.previousPage.BringToFront(); 
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        //Validates all of user's input
        public bool ValidateUserSettingInput()
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
            if (fullNameTextBox.Text.Length == 0)
            {
                new AlertBox("Full Name", "Please enter your full name").Show();
                return false;
            }

            if (addressTextBox.Text.Length == 0 || cityTextBox.Text.Length == 0 || postalCodeTextBox.Text.Length == 0)
            {
                new AlertBox("Address", "Please enter a valid address").Show();
                return false;
            }
            return true;
        }

        //--------------------------------------------------------------------------------------------------------------
        //Save all the inputs once validated
        public void SaveUserSettings()
        {
            HotPlateData.userName = fullNameTextBox.Text;
            HotPlateData.userEmail = emailTextBox.Text;
            HotPlateData.userPhone = phoneTextBox.Text;

            HotPlateData.userCompany = companyTextBox.Text;
            HotPlateData.userAddressline = addressTextBox.Text;
            HotPlateData.userCity = cityTextBox.Text;
            HotPlateData.userState = stateComboBox.SelectedItem.ToString();
            HotPlateData.userPostalNumber = postalCodeTextBox.Text;
            HotPlateData.userNotes = notesTextBox.Text;
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}