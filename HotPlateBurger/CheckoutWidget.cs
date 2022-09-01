using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using HotPlateBurger.Properties;

namespace HotPlateBurger
{
    public partial class CheckoutWidget : UserControl
    {

        public string itemID;
        public CheckoutWidget(int amount, string title, string picture, string id)
        {
            InitializeComponent();
            widgetSize.Text = "" + amount;
            widgetTitle.Text = title;
            picturebox.Image = Resources.ResourceManager.GetObject(picture) as Image;
            
            itemID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.basket.Remove(itemID);
            Form1.updateBasket();
        }
    }
}