using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    //The dashboard user controls form is the main page that features all the different category buttons
    public partial class DashBoard : UserControl
    {

        //The label that displays the total in the bottom left
        public static Label labelWithTotal;

        //Previous button basically stores the previous button you've pressed in the category.
        // This is to change the color of the button once the user makes another choice
        public static Button previousButton;

        // Panel that carries AllFrames.cs
        public static AllFrame allFrame;

        // Array that carries every food card that was loaded from the database
        public ArrayList widgetArray;
        
        //Initialize the Dashboard User Controls Panel
        //Loads all the widgets to AllFrame.cs
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

        //Function made specifically to load AllFrame.cs
        public void loadForm(Object form)
        {
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.Tag = f;
            f.Show();
        }

        //Loads all the widgets to the widgetArray from the SQL database.
        public void loadWidgets()
        {
            MySqlDataReader reader = Form1.executeSQL("SELECT * FROM foodtable");
            while (reader.Read())
            {
                Widget w = new Widget("" + reader[2], "" + reader[3], "" + reader[4], "" + reader[1], "" + reader[0]);
                widgetArray.Add(w);
            }
            Form1.SQLconn.Close();
        }

        //Adds the proper widgets to AllFrame flowlayoutpanel from the widgetArray to the specified category.
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
                Form1.previousPage = Form1.cp;
                checkoutPage.updateCP();
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
                Form1.previousPage = Form1.cp;
                checkoutPage.updateCP();
                Form1.cp.BringToFront();
            }
        }
    }
}