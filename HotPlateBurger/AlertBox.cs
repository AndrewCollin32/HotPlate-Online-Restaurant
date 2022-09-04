using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class AlertBox : Form
    {
        
        public AlertBox(string titleText, string descText)
        {
            InitializeComponent();
            title.Text = titleText;
            Text = titleText;
            description.Text = descText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}