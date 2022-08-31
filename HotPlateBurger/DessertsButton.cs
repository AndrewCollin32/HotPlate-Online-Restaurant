using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class DessertsFrame : Form
    {
        public DessertsFrame()
        {
            InitializeComponent();
            MySqlDataReader reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 'de'");
            while (reader.Read())
            {
                flowLayoutPanel1.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4], ""+reader[1]));
            }
        }
    }
}