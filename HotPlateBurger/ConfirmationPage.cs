using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class ConfirmationPage : UserControl
    {
        public static Label confirmationNumberText;
        public ConfirmationPage()
        {
            InitializeComponent();
            confirmationNumberText = confirmationNumberLabel;
        }

        private void okButtonClick(object sender, EventArgs e)
        {
            String[] key = Form1.basket.Keys.ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                ((Button)Form1.basket[key[i]][5]).Text = "Add";
                ((Button)Form1.basket[key[i]][5]).BackColor = Color.Coral;
                Form1.basket.Remove(key[i]);
            }

            Form1.grandTotal = 0;
            Form1.total = 0;

            Form1.checkoutPage = new checkoutPage();
            Form1.switchPanel.Controls.Add(Form1.checkoutPage);
            Form1.checkoutPage.Dock = DockStyle.Fill;
            Form1.UpdateTotalAndGrandTotal();
            Form1.previousPage = Form1.dashboardPage;
            Form1.dashboardPage.BringToFront();
        }
    }
}