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

            MySqlDataReader reader = Form1.executeSQL("SELECT * FROM foodtable");
            while (reader.Read())
            {
                flowLayoutPanel.Controls.Add(new Widget("" + reader[2],"" + reader[3],  "" + reader[4], ""+reader[1]));
            }
        }
    }
}