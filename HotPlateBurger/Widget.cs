using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class Widget : UserControl
    {

        public string title;
        public string price;
        public string picture;
        public Widget(string title, string price, string picture)
        {
            this.price = price;
            this.title = title;
            this.picture = picture;
            InitializeComponent(title, price, picture);
            this.Margin = new Padding(30, 30, 30, 30);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddItemFrame(title, picture).Show();
            Form1.total += Double.Parse(price);
            DashBoard.labelWithTotal.Text = "Total: $" + Form1.total.ToString("0.00");
        }
    }
}