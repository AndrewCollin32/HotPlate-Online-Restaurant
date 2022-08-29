using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class DashBoard : UserControl
    {

        public static Button previousButton;
        public DashBoard()
        {
            InitializeComponent();
            previousButton = allButton;
            loadForm(new AllFrame());
        }

        public void loadForm(Object form)
        {
            panel2.Controls.Clear();

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.Tag = f;
            f.Show();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            allButton.BackColor = Color.SandyBrown;
            loadForm(new AllFrame());
            previousButton = allButton;
        }

        private void burgerButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            burgerButton.BackColor = Color.SandyBrown;
            loadForm(new BurgerFrame());
            previousButton = burgerButton;
        }
    }
}