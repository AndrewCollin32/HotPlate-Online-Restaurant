using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    //Widgets that are generated for the main page. 
    public partial class Widget : UserControl
    {
        //--------------------------------------------------------------------------------------------------------------
        // Each widget stores the menu item's data
        public string title;
        public string price;
        public string picture;
        public string id;
        public string category;
        
        //--------------------------------------------------------------------------------------------------------------
        // Creates a new widget 
        public Widget(MySqlDataReader reader)
        {
            id = (string) reader[1];
            price = (string) reader[3];
            title = (string) reader[2];
            picture = (string) reader[4];
            category = (string) reader[0];
            
            InitializeComponent(title, price, picture);
            
            Margin = new Padding(30, 30, 30, 30);
        }
        //--------------------------------------------------------------------------------------------------------------
        
        //Event activated when the add button is clicked. Updates the total, add an item to the shopping basket anc
        //changes the color and text of the button
        private void addButton_Click(object sender, EventArgs e)
        {
            HotPlateData.total += Double.Parse(price);
            DashBoard.labelWithTotal.Text = "Total: $" + HotPlateData.total.ToString("0.00");
            addButton.BackColor = Color.SandyBrown;
            addButton.Text = "Add More";
            AddItem(id, Double.Parse(price), title, picture, addButton);
        }
        //--------------------------------------------------------------------------------------------------------------

        //Adds the item to the basket. Only called from addButton_Click method.
        public void AddItem(string id, double price, string title, string picture, Button button)
        {
            if (HotPlateData.basket.ContainsKey(id)) 
            { HotPlateData.basket[id][0] = (int)HotPlateData.basket[id][0] + 1; }
            else 
            {HotPlateData.basket.Add(id, new object[]{1, price, title, picture, id, button}); }
        }
        
        //--------------------------------------------------------------------------------------------------------------
        
    }
}