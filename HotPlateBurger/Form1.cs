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

        public static double total = 0;
        
        public static string databaseName = "hotplaterestaurant";
        public static string username = "root";
        public static string password = "";
        public static string server = "localhost";
        
        public Form1()
        {
            InitializeComponent();

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
            
        }
    }
}