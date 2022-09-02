using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class ConfirmationPage : UserControl
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] key = Form1.basket.Keys.ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                ((Button)Form1.basket[key[i]][5]).Text = "Add";
                ((Button)Form1.basket[key[i]][5]).BackColor = Color.Coral;
                Form1.basket.Remove(key[i]);
            }

            Form1.gtotal = 0;
            Form1.total = 0;

            Form1.cp = new checkoutPage();
            Form1.switchPanel.Controls.Add(Form1.cp);
            Form1.cp.Dock = DockStyle.Fill;
            Form1.updateBasket();
            Form1.db.BringToFront();
        }
    }
}