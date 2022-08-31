using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class AllFrame : Form
    {

        public static FlowLayoutPanel flowLayoutPanel;
        public AllFrame()
        {
            InitializeComponent();
            flowLayoutPanel = flowLayoutPanel1;

            MySqlDataReader reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 'b'");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4]));
            }
            reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 'c'");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4]));
            }
            reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 's'");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4]));
            }
            reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 'd'");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4]));
            }
            reader = Form1.executeSQL("SELECT * FROM foodtable WHERE category = 'de'");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4]));
            }
        }
    }
}