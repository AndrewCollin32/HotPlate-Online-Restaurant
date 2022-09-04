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
        //--------------------------------------------------------------------------------------------------------------
        //The label that displays the total in the bottom left
        public static Label labelWithTotal;

        //Previous button basically stores the previous button you've pressed in the category.
        // This is to change the color of the button once the user makes another choice
        public static Button previousButton;

        // Panel that carries AllFrames.cs
        public static AllFrame allFrame;

        // Array that carries every food card that was loaded from the database
        public ArrayList widgetArray;
        
        //--------------------------------------------------------------------------------------------------------------
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
            LoadWidgetForFrame("a");
            
            allFrame.BringToFront();

        }

        //--------------------------------------------------------------------------------------------------------------
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

        //--------------------------------------------------------------------------------------------------------------
        //Loads all the widgets to the widgetArray from the SQL database.
        public void loadWidgets()
        {
            MySqlDataReader reader = HotPlateData.ConnectToSql("SELECT * FROM foodtable");
            while (reader.Read())
            {
                Widget w = new Widget(reader);
                widgetArray.Add(w);
            }
            HotPlateData.SQLconn.Close();
        }

        //--------------------------------------------------------------------------------------------------------------
        //Adds the proper widgets to AllFrame flowlayoutpanel from the widgetArray to the specified category.
        public void LoadWidgetForFrame(string category)
        {
            for (int i = 0; i < widgetArray.Count; i++)
            {
                if (((Widget)widgetArray[i]).category == category || category == "a")
                {
                    allFrame.flowLayoutPanel.Controls.Add((Widget)widgetArray[i]);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        // Updates previous button status and assigns current button to previous button
        public void UpdateButton(Button button, string category)
        {
            previousButton.BackColor = Color.Coral;
            allButton.BackColor = Color.SandyBrown;
            allFrame.flowLayoutPanel.Controls.Clear();
            LoadWidgetForFrame(category);
            previousButton = button;
        }
        //--------------------------------------------------------------------------------------------------------------
        private void allButton_Click(object sender, EventArgs e)
        {
           UpdateButton(allButton, "a");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void burgerButton_Click(object sender, EventArgs e)
        {
            UpdateButton(burgerButton, "b");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void chickenButton_Click(object sender, EventArgs e)
        {
            UpdateButton(chickenButton, "c");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void sidesButton_Click(object sender, EventArgs e)
        {
            UpdateButton(sidesButton, "s");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void drinkButton_Click(object sender, EventArgs e)
        {
            UpdateButton(drinkButton, "d");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void dessertsButton_Click(object sender, EventArgs e)
        {
            UpdateButton(dessertsButton, "de");
        }

        //--------------------------------------------------------------------------------------------------------------
        private void shoppingCartIcon_Click(object sender, EventArgs e)
        {
            HotPlateData.UpdateTotalAndGrandTotal();
            if (HotPlateData.basket.Count == 0)
            {
                new AlertBox("Cart Is Empty", "Can't open checkout page because your cart is empty").Show();
            }
            else
            {
                HotPlateData.UpdateCheckoutPage();
                HotPlateData.previousPage = HotPlateData.checkoutPage;
                checkoutPage.UpdateCheckOutLabels();
                HotPlateData.checkoutPage.BringToFront();
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        private void totalLabel_Click(object sender, EventArgs e)
        {
            HotPlateData.UpdateTotalAndGrandTotal();
            if (HotPlateData.basket.Count == 0)
            {
                new AlertBox("Cart Is Empty", "Can't open checkout page because your cart is empty").Show();
            }
            else
            {
                HotPlateData.UpdateCheckoutPage();
                HotPlateData.previousPage = HotPlateData.checkoutPage;
                checkoutPage.UpdateCheckOutLabels();
                HotPlateData.checkoutPage.BringToFront();
            }
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}