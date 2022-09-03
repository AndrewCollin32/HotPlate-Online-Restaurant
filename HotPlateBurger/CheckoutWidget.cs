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

        public string itemID;
        public Button button;
        public CheckoutWidget(int amount, string title, string picture, string id, Button button)
        {
            InitializeComponent();
            widgetSize.Text = "" + amount;
            widgetTitle.Text = title;
            picturebox.Image = Resources.ResourceManager.GetObject(picture) as Image;
            this.button = button;
            itemID = id;
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            Form1.basket.Remove(itemID);
            Form1.UpdateTotalAndGrandTotal();
            Form1.UpdateCheckoutPage();
            button.Text = "Add";
            button.BackColor = Color.Coral;

            if (Form1.basket.Count == 0)
            {
                Form1.dashboardPage.BringToFront();
            }
            
        }
    }
}