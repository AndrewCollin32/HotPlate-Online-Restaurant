using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class UserSettingsPage : UserControl
    {
        public static string[] stateArray =
        {
            "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL","GA",
            "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO","MT",
            "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "CM", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD",
            "TN", "TX", "TT", "UT", "VT", "VA", "VI", "WA", "WV", "WI", "WY"
        };
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

        private void backButton_Click(object sender, EventArgs e)
        {
            fillEverything();
            Form1.db.BringToFront();
        }
        
    }
}