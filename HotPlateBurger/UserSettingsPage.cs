using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class UserSettingsPage : UserControl
    {
        public UserSettingsPage()
        {
            InitializeComponent();
            fillEverything();
        }

        public void fillEverything()
        {
            fullNameTextBox.Text = Form1.userName;
            emailTextBox.Text = Form1.userEmail;
            phoneTextBox.Text = Form1.userPhone;

            companyTextBox.Text = Form1.userCompany;
            addressTextBox.Text = Form1.userAddressline;
            stateTextbox.Text = Form1.userState;
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