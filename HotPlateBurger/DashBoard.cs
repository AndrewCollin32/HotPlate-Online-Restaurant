using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class DashBoard : UserControl
    {

        public static Label labelWithTotal;

        public static Button previousButton;

        public static AllFrame allFrame;

        public ArrayList widgetArray;
        public DashBoard()
        {
            InitializeComponent();
            previousButton = allButton;
            labelWithTotal = totalLabel;
            widgetArray = new ArrayList();
            
            allFrame = new AllFrame();
            loadForm(allFrame);

            loadWidgets();
            loadWidgetForFrame("a");
            
            allFrame.BringToFront();

        }

        public void loadForm(Object form)
        {
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.Tag = f;
            f.Show();
        }

        public void loadWidgets()
        {
            MySqlDataReader reader = Form1.executeSQL("SELECT * FROM foodtable");
            while (reader.Read())
            {
                Widget w = new Widget("" + reader[2], "" + reader[3], "" + reader[4], "" + reader[1], "" + reader[0]);
                widgetArray.Add(w);
            }
        }

        public void loadWidgetForFrame(string category)
        {
            switch (category)
            {
                case "a":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                    }
                    break;
                case "b":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        if (((Widget)widgetArray[i]).category == "b")
                        {
                            allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                        }
                    }
                    break;
                case "c":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        if (((Widget)widgetArray[i]).category == "c")
                        {
                            allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                        }
                    }
                    break;
                case "s":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        if (((Widget)widgetArray[i]).category == "s")
                        {
                            allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                        }
                    }
                    break;
                case "d":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        if (((Widget)widgetArray[i]).category == "d")
                        {
                            allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                        }
                    }
                    break;
                case "de":
                    for (int i = 0; i < widgetArray.Count; i++)
                    {
                        if (((Widget)widgetArray[i]).category == "de")
                        {
                            allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                        }
                    }
                    break;
                    
            }
            {
                
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            allButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("a");
            previousButton = allButton;
        }

        private void burgerButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            burgerButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("b");
            previousButton = burgerButton;
        }

        private void chickenButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            chickenButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("c");
            previousButton = chickenButton;
        }

        private void sidesButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            sidesButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("s");
            previousButton = sidesButton;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            drinkButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("d");
            previousButton = drinkButton;
        }

        private void dessertsButton_Click(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.Coral;
            dessertsButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            loadWidgetForFrame("de");
            previousButton = dessertsButton;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.updateBasket();
            if (Form1.basket.Count == 0)
            {
                new AlertBox("Cart Is Empty", "Can't open checkout page because your cart is empty").Show();
            }
            else
            {
                checkoutPage.fullnameLabelChild.Text = Form1.userName;
                checkoutPage.fullnameLabelChild.ForeColor = Color.Black;
                checkoutPage.emailLabelChild.Text = Form1.userEmail;
                checkoutPage.phoneLabelChild.Text = Form1.userPhone;
                Form1.cp.BringToFront();
            }
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
            Form1.updateBasket();
            if (Form1.basket.Count == 0)
            {
                new AlertBox("Cart Is Empty", "Can't open checkout page because your cart is empty").Show();
            }
            else
            {
                checkoutPage.fullnameLabelChild.Text = Form1.userName;
                checkoutPage.fullnameLabelChild.ForeColor = Color.Black;
                checkoutPage.emailLabelChild.Text = Form1.userEmail;
                checkoutPage.phoneLabelChild.Text = Form1.userPhone;
                Form1.cp.BringToFront();
            }
        }
    }
}