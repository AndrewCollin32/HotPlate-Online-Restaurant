using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace HotPlateBurger
{
    public partial class Widget : UserControl
    {

        public string title;
        public string price;
        public string picture;
        public string id;
        public Widget(string title, string price, string picture, string id)
        {
            this.id = id;
            this.price = price;
            this.title = title;
            this.picture = picture;
            InitializeComponent(title, price, picture);
            this.Margin = new Padding(30, 30, 30, 30);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddItemFrame(title, picture).Show();
            Form1.total += Double.Parse(price);
            DashBoard.labelWithTotal.Text = "Total: $" + Form1.total.ToString("0.00");
            
            addItem(id, Double.Parse(price), title, picture);
        }

        public static void addItem(string id, double price, string title, string picture)
        {
            if (Form1.basket.ContainsKey(id))
            {
                Form1.basket[id][0] = (int)Form1.basket[id][0] + 1;
            }
            else
            {
                Form1.basket.Add(id, new object[]{1, price, title, picture});
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