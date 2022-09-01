using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class CheckoutWidget : UserControl
    {
        public CheckoutWidget(int amount, string title, string picture)
        {
            InitializeComponent(amount, title, picture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}