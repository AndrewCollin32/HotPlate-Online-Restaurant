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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.basket.Remove(itemID);
            Form1.updateBasket();
            button.Text = "Add";
            button.BackColor = Color.Coral;

            if (Form1.basket.Count == 0)
            {
                Form1.db.BringToFront();
            }
            
        }
    }
}