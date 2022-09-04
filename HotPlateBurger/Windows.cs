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



// This is the main frame of the program. When the program runs, this is the first frame that will open. This is the back
// layer of the entire program. It only consists of top bar.
// This class also stores all the data to run this program. The data is stores:
// - SQL Login Information
// - User's information (Email, Fullname, Phone number)
// - User's Address
// - The calculated total (Before and after tax and tips)
// - The shopping basket
// - User Control Pages (CheckoutPage.cs, ConfirmationPage.cs, Dashboard.cs and UserSettingsPage.cs)
// - PreviousPage.cs - This variable is only used for users accessing UserSettings. 
namespace HotPlateBurger
{
    public partial class HotPlateData : Form
    {
        //--------------------------------------------------------------------------------------------------------------
        // SQL SETUP
        // This is where you will input your information to connect to your MySQL database.
        // You'll need to make a database first before you start the program.
        // Look below for further instructions
        // TODO: Enter your SQL Information
        
        public static string SQLDatabaseName = "hotplaterestaurant";
        public static string SQLusername = "root";
        public static string SQLPassword = "";
        public static string SQLServer = "localhost";
        
        // Once you are done creating your database and inputting your information, you need to go to Program.CS
        // and comment out the main function. Then you need to go to ImplementSQL.cs and uncomment the static void main
        // function. Compile ImplementSQL.cs This program will automatically build your tables for you. It will also
        // give you a sample menu you can work from. Once it is done compiling. (If you want to delete all of your data
        // just comment out the function: createTable(conn); and insertSampleMenu(conn); and uncomment
        // deleteEverything(conn);) Afterwards, just comment out the main static function in ImplementSQL.cs and uncomment
        // the main function in Program.cs. Your program should run smoothly from here.
        //--------------------------------------------------------------------------------------------------------------

        
        // User's Information
        public static string userEmail = "jacob42@gmail.com";
        public static string userPhone = "619-818-3829";
        public static string userName = "Jacob Burger";
        public static string userCompany = "";
        public static string userAddressline = "4732 Widow St";
        public static string userCity = "San Diego";
        public static string userState = "CA";
        public static string userPostalNumber = "92142";
        public static string userNotes = "Use back door.";

        // Previous Page is used when UserSettings is called. Once users are done editing their settings, it will bring
        // them back to the previous page.
        public static UserControl previousPage;

        // This is the shopping cart. It stores all of the items the user have selected. It goes by this format:
        // <String, Object[]> 
        // The key stores the item ID. You can also see the item ID in the foodtable in MySQL.
        // Example: basket[3] will give you the food item Double Cheese Burger if it exists in the person's shopping cart.
        // Object[] carries additional information like {Quantity, Price, Item's Name, Picture's Name, ID, Button}}
        public static Dictionary<string, Object[]> basket;

        
        // Total - The calculated total before tax, tips and fees
        // gTotal (Grand Total) Calculated total after tax, tips and fees
        public static double total = 0;
        public static double grandTotal = 0;
        
        //Switch Panel is the panel that is used to switch between UserSettings, Checkout, Dashboard and Confirmation Pages
        public static Panel switchPanel;
        
        // Tax amount, tip percentage and delivery fee
        public static int taxAmount = 10;
        public static int tipPercentage;
        public static double deliveryFee = 5.00;

        // User controls 
        public static DashBoard dashboardPage;
        public static checkoutPage checkoutPage;
        public static ConfirmationPage confirmationPage;
        public static UserSettingsPage userSettingsPage;

        public static MySqlConnection SQLconn;
        
        //--------------------------------------------------------------------------------------------------------------
        // Function to initialize Form1. It also initializes the user control pages and add them to panelSwitch.
        public HotPlateData()
        {
            InitializeComponent();
            basket = new Dictionary<string, object[]>();
            switchPanel = panelSwitch;
            InitializeUserControls();
            dashboardPage.BringToFront();
        }

        //--------------------------------------------------------------------------------------------------------------
        //Creates new usercontrols and calls addUserControlsToSwitchPanel
        public static void InitializeUserControls()
        {
            confirmationPage = (ConfirmationPage) AddUserControlsToSwitchPanel(new ConfirmationPage());
            dashboardPage = (DashBoard) AddUserControlsToSwitchPanel(new DashBoard());
            checkoutPage = (checkoutPage) AddUserControlsToSwitchPanel(new checkoutPage());
            userSettingsPage = (UserSettingsPage) AddUserControlsToSwitchPanel(new UserSettingsPage());
        }

        //--------------------------------------------------------------------------------------------------------------
        //Adds usercontrol form into switchpanel controls.
        public static UserControl AddUserControlsToSwitchPanel(UserControl page)
        {
            switchPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
            return page;
        }

        //--------------------------------------------------------------------------------------------------------------
        //Updates the total and grandTotal
        public static void UpdateTotalAndGrandTotal()
        {
            double total = 0;
            foreach (string key in basket.Keys.ToArray())
            {
                total = (int) basket[key][0] * (double) basket[key][1] + total;
            }
            HotPlateData.total = total;
            DashBoard.labelWithTotal.Text = "Total: $" + total.ToString("0.00");
            grandTotal = ((total) * tipPercentage / 100) + ((total) * taxAmount / 100) + total + deliveryFee;
        }

        //--------------------------------------------------------------------------------------------------------------
        //Updates all the labels in the checkout page
        public static void UpdateCheckoutPage()
        {
            checkoutPage.checkoutLayout.Controls.Clear();
            String orderTotal = "";
            foreach (string key in basket.Keys.ToArray()) {

                orderTotal = orderTotal + 
                             "\n" + basket[key][0] + "x " + basket[key][2] + " - $" + 
                             ((int) basket[key][0] * (double) basket[key][1]).ToString("0.00");

                checkoutPage.checkoutLayout.Controls.Add(new CheckoutWidget(
                    (int) basket[key][0], (string) basket[key][2], (string) basket[key][3], 
                    (string) basket[key][4], (Button)basket[key][5]));
                
            }
            checkoutPage.orderTotalLabel.Text = orderTotal;
            checkoutPage.totalLabelSingle.Text = "Total: $" + grandTotal.ToString("0.00");
            checkoutPage.totalLabel.Text = 
                "$" + total.ToString("0.00") + "\n" + tipPercentage + "%\n" + 
                taxAmount + "%\n$" + deliveryFee.ToString("0.00") + 
                "\n$" + grandTotal.ToString("0.00");
        }

        //--------------------------------------------------------------------------------------------------------------
        //Connects to the database and returns a SQLReader
        public static MySqlDataReader ConnectToSql(String command)
        {
            MySqlConnection conn = new MySqlConnection(
                "SERVER=" + SQLServer + ";DATABASE=" + SQLDatabaseName + 
                ";UID=" + SQLusername + ";PASSWORD=" + SQLPassword + ";");
            
            conn.Open();
            SQLconn = conn;
            MySqlCommand cmd = new MySqlCommand(command, conn);
            return cmd.ExecuteReader();
        }

        //--------------------------------------------------------------------------------------------------------------
        // Function that is triggered when you click on your profile picture. Takes you to the usersettings page.
        private void AvatarLogoClick(object sender, EventArgs e)
        {
            userSettingsPage.BringToFront();
        }

        //--------------------------------------------------------------------------------------------------------------
        // Function that is triggered when you click on your name. Takes you to the usersettings page.
        private void NameLabelClick(object sender, EventArgs e)
        {
            userSettingsPage.BringToFront();
        }

        //--------------------------------------------------------------------------------------------------------------
        // Function that is triggered when you click on your HotPlate Logo. Takes you to the dashboard page.
        private void HotPlateLogoClick(object sender, EventArgs e)
        {
            dashboardPage.BringToFront();
        }
        
        //--------------------------------------------------------------------------------------------------------------
    }
}