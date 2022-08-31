using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class AddItemFrame : Form
    {
        public AddItemFrame(string title, string picture)
        {
            InitializeComponent(title, picture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}