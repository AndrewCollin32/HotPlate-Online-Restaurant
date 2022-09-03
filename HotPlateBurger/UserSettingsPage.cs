﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class UserSettingsPage : UserControl
    {
        //An array that holds every state's acronyms in the U.S.
        public static string[] stateArray =
        {
            "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL","GA",
            "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO","MT",
            "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "CM", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD",
            "TN", "TX", "TT", "UT", "VT", "VA", "VI", "WA", "WV", "WI", "WY"
        };
        // Initializes the UserSettingsPage, adds all the states to the combobox and calls fillEverything()
        public UserSettingsPage()
        {
            InitializeComponent();

            stateComboBox.Items.Add("AL");
            foreach (string s in stateArray)
            {
                stateComboBox.Items.Add(s);
            }
            fillEverything();
        }

        // Fills all the textboxes with existing information
        public void fillEverything()
        {
            fullNameTextBox.Text = Form1.userName;
            emailTextBox.Text = Form1.userEmail;
            phoneTextBox.Text = Form1.userPhone;

            companyTextBox.Text = Form1.userCompany;
            addressTextBox.Text = Form1.userAddressline;
            stateComboBox.Text = Form1.userState;
            cityTextBox.Text = Form1.userCity;
            postalCodeTextBox.Text = Form1.userPostalNumber;
            notesTextBox.Text = Form1.userNotes;
        }

        //Takes users to the previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            fillEverything();
            Form1.previousPage.BringToFront();
        }

        //Validates and saves all the data to Form1.cs and takes the user back to the previous page.
        private void saveButton_Click(object sender, EventArgs e)
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
            if (fullNameTextBox.Text.Length == 0)
            {
                new AlertBox("Full Name", "Please enter your full name").Show();
                return;
            }

            if (addressTextBox.Text.Length == 0 || cityTextBox.Text.Length == 0 || postalCodeTextBox.Text.Length == 0)
            {
                new AlertBox("Address", "Please enter a valid address").Show();
                return;
            }

            Form1.userName = fullNameTextBox.Text;
            Form1.userEmail = emailTextBox.Text;
            Form1.userPhone = phoneTextBox.Text;

            Form1.userCompany = companyTextBox.Text;
            Form1.userAddressline = addressTextBox.Text;
            Form1.userCity = cityTextBox.Text;
            Form1.userState = stateComboBox.SelectedItem.ToString();
            Form1.userPostalNumber = postalCodeTextBox.Text;
            Form1.userNotes = notesTextBox.Text;
            
            checkoutPage.updateCP();
            Form1.previousPage.BringToFront();
        }
    }
}