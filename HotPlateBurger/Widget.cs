using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class Widget : UserControl
    {

        public string title;
        public string price;
        public Widget(string title, string price, string picture)
        {
            this.price = price;
            this.title = title;
            InitializeComponent(title, price, picture);
            this.Margin = new Padding(30, 30, 30, 30);
        }
        
    }
}