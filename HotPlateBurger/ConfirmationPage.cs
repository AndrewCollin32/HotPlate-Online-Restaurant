using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class ConfirmationPage : UserControl
    {
        //--------------------------------------------------------------------------------------------------------------
        //Stores the confirmation number to display it on the page
        public static Label confirmationNumberText;
        
        //--------------------------------------------------------------------------------------------------------------
        // Initialize the confirmation page. Assigns the confirmation label to global variable
        public ConfirmationPage()
        {
            InitializeComponent();
            confirmationNumberText = confirmationNumberLabel;
        }
        //--------------------------------------------------------------------------------------------------------------
        //Resets total and grandTotal to 0
        public static void DeleteAllOrderData()
        {
            HotPlateData.grandTotal = 0;
            HotPlateData.total = 0;
        }

        //--------------------------------------------------------------------------------------------------------------
        //Resets all widget buttons to it's original state
        public static void ResetAllWidgetButtons()
        {
            String[] key = HotPlateData.basket.Keys.ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                ((Button)HotPlateData.basket[key[i]][5]).Text = "Add";
                ((Button)HotPlateData.basket[key[i]][5]).BackColor = Color.Coral;
                HotPlateData.basket.Remove(key[i]);
            }
        }
        
        //--------------------------------------------------------------------------------------------------------------
        private void okButton_Click(object sender, EventArgs e)
        {

            ResetAllWidgetButtons();
            DeleteAllOrderData();
            HotPlateData.checkoutPage = (checkoutPage) HotPlateData.AddUserControlsToSwitchPanel(new checkoutPage());
            HotPlateData.previousPage = HotPlateData.dashboardPage;
            HotPlateData.dashboardPage.BringToFront();
        }
        
        //--------------------------------------------------------------------------------------------------------------
    }
}