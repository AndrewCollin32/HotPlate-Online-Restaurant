using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public partial class AllFrame : Form
    {

        public FlowLayoutPanel flowLayoutPanel;
        public AllFrame()
        {
            InitializeComponent();
            flowLayoutPanel = flowLayoutPanel1;
        }
    }
}