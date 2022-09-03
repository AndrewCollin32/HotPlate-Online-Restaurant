using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        public static Button addItemButton;
        public Widget(string title, string price, string picture, string id, string category)
        {
            this.id = id;
            this.price = price;
            this.title = title;
            this.picture = picture;
            this.category = category;
            InitializeComponent(title, price, picture);
            addItemButton = addButton;
            this.Margin = new Padding(30, 30, 30, 30);
            if (Form1.basket.ContainsKey(id))
            {
                addButton.BackColor = Color.SandyBrown;
                addButton.Text = "Add More";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //new AddItemFrame(title, picture).Show();
            Form1.total += Double.Parse(price);
            DashBoard.labelWithTotal.Text = "Total: $" + Form1.total.ToString("0.00");
            addButton.BackColor = Color.SandyBrown;
            addButton.Text = "Add More";
            addItem(id, Double.Parse(price), title, picture, addButton);
        }

        public static void addItem(string id, double price, string title, string picture, Button button)
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

        public static void printDebug()
        {
            Debug.WriteLine("------------------------------------------------------------------------------------");
            string[] key =  Form1.basket.Keys.ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                Debug.WriteLine(Form1.basket[key[i]][0]);
            }
            
        }
    }
}