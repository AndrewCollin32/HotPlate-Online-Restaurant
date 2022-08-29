using System;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public void loadForm(Object form)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.Tag = f;
            f.Show();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            loadForm(new AllFrame());
        }

        private void burgerButton_Click(object sender, EventArgs e)
        {
            loadForm(new BurgerFrame());
        }
    }
}