using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class checkoutPage : UserControl
    {
        public checkoutPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1.db.BringToFront();
        }
    }
}