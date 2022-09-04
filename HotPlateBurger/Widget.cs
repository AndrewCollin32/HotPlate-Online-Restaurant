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

        public string title;
        public string price;
        public string picture;
        public string id;
        public string category;
        
        // Creates a new widget 
        public Widget(MySqlDataReader reader)
        {
            id = (string) reader[2];
            price = (string) reader[3];
            title = (string) reader[4];
            picture = (string) reader[1];
            category = (string) reader[0];
            
            InitializeComponent(title, price, picture);
            
            Margin = new Padding(30, 30, 30, 30);
            
            if (Form1.basket.ContainsKey(id))
            {
                addButton.BackColor = Color.SandyBrown;
                addButton.Text = "Add More";
            }
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            Form1.total += Double.Parse(price);
            DashBoard.labelWithTotal.Text = "Total: $" + Form1.total.ToString("0.00");
            addButton.BackColor = Color.SandyBrown;
            addButton.Text = "Add More";
            AddItem(id, Double.Parse(price), title, picture, addButton);
        }

        public static void AddItem(string id, double price, string title, string picture, Button button)
        {
            if (Form1.basket.ContainsKey(id))
            {
                Form1.basket[id][0] = (int)Form1.basket[id][0] + 1;
            }
            else
            {
                Form1.basket.Add(id, new object[]{1, price, title, picture, id, button});
            }
        }
        
    }
}