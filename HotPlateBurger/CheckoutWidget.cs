using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using HotPlateBurger.Properties;

namespace HotPlateBurger
{
    //This is the checkout widget. It is the widget that is generated when you are in the checkout page on the left.
    public partial class CheckoutWidget : UserControl
    {
        //--------------------------------------------------------------------------------------------------------------
        //Global Variables
        public string itemID;
        public Button button;
        
        //--------------------------------------------------------------------------------------------------------------
        //Initialize Checkout Widget
        public CheckoutWidget(int amount, string title, string picture, string id, Button button)
        {
            InitializeComponent();
            widgetSize.Text = "" + amount;
            widgetTitle.Text = title;
            picturebox.Image = Resources.ResourceManager.GetObject(picture) as Image;
            this.button = button;
            itemID = id;
        }

        //--------------------------------------------------------------------------------------------------------------
        //Deletes an item from the basket and resets it's button
        public void DeleteAnItem()
        {
            HotPlateData.basket.Remove(itemID);
            HotPlateData.UpdateTotalAndGrandTotal();
            HotPlateData.UpdateCheckoutPage();
            button.Text = "Add";
            button.BackColor = Color.Coral;
        }
        //--------------------------------------------------------------------------------------------------------------
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteAnItem();
            if (HotPlateData.basket.Count == 0) HotPlateData.dashboardPage.BringToFront();
        }

        //--------------------------------------------------------------------------------------------------------------
    }
}