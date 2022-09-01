using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class Form1 : Form
    {

        public static Dictionary<string, Object[]> basket;

        public static double total = 0;
        public static Panel switchPanel;
        public static int taxAmount = 10;
        public static int tipPercentage;
        public static double deliveryFee = 5.00;
        
        public static string databaseName = "hotplaterestaurant";
        public static string username = "root";
        public static string password = "";
        public static string server = "localhost";

        public static DashBoard db;
        public static checkoutPage cp;
        
        public Form1()
        {
            InitializeComponent();
            basket = new Dictionary<string, object[]>();
            switchPanel = panelSwitch;
            
            db = new DashBoard();
            cp = new checkoutPage();
            panelSwitch.Controls.Add(cp);
            panelSwitch.Controls.Add(db);
            cp.Dock = DockStyle.Fill;
            db.Dock = DockStyle.Fill;
            db.BringToFront();

        }

        public static void updateBasket()
        {

            checkoutPage.checkoutLayout.Controls.Clear();
            String orderTotal = "";
            double total = 0;
            string[] key = basket.Keys.ToArray();
            for (int i = 0; i < key.Length; i++)
            {
                total = (int) basket[key[i]][0] * (double) basket[key[i]][1] + total;
                orderTotal = orderTotal + "\n" + basket[key[i]][0] + "x " + basket[key[i]][2] + " - $" + ((int) basket[key[i]][0] * (double) basket[key[i]][1]).ToString("0.00");
                checkoutPage.checkoutLayout.Controls.Add(new CheckoutWidget((int) basket[key[i]][0], (string) basket[key[i]][2], (string) basket[key[i]][3], (string) basket[key[i]][4]));
            }

            DashBoard.labelWithTotal.Text = "Total: $" + total.ToString("0.00");
            checkoutPage.orderTotalLabel.Text = orderTotal;

            double grandTotal = ((total) * tipPercentage / 100) + ((total) * taxAmount / 100) + total + deliveryFee;
            string totalCalculation = "$" + total.ToString("0.00") + "\n" + tipPercentage + "%\n" + taxAmount +
                                      "%\n$" + deliveryFee.ToString("0.00") + "\n$" + grandTotal.ToString("0.00");
            checkoutPage.totalLabelSingle.Text = "Total: $" + grandTotal.ToString("0.00");
            checkoutPage.totalLabel.Text = totalCalculation;
            

        }

        public static MySqlDataReader executeSQL(String command)
        {
            MySqlConnection conn = new MySqlConnection("SERVER=" + server + ";DATABASE=" + databaseName + ";UID=" + username + ";PASSWORD=" + password + ";");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(command, conn);
            return cmd.ExecuteReader();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            db.BringToFront();
        }
    }
}