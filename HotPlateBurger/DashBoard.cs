using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class DashBoard : UserControl
    {

        public static Label labelWithTotal;

        public static Button previousButton;
        public DashBoard()
        {
            InitializeComponent();
            previousButton = allButton;
            loadForm(new AllFrame());
            labelWithTotal = totalLabel;
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

        private void chickenButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            chickenButton.BackColor = Color.SandyBrown;
            loadForm(new ChickenFrame());
            previousButton = chickenButton;
        }

        private void sidesButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            sidesButton.BackColor = Color.SandyBrown;
            loadForm(new SidesFrame());
            previousButton = sidesButton;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            drinkButton.BackColor = Color.SandyBrown;
            loadForm(new DrinksFrame());
            previousButton = drinkButton;
        }

        private void dessertsButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            dessertsButton.BackColor = Color.SandyBrown;
            loadForm(new DessertsFrame());
            previousButton = dessertsButton;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}