using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public class ImplementSQL
    {
        //Creates table and uploads sample data
        
        // static void Main()
        // {
        //     MySqlConnection conn =
        //         new MySqlConnection("SERVER=" + Form1.server + ";DATABASE=" + Form1.databaseName + ";UID=" + Form1.username + ";PASSWORD=" + Form1.password + ";");
        //     conn.Open();
        //     //createTable(conn);
        //     //deleteEverything(conn);
        //     insertSampleMenu(conn);
        // }
        
        static void createTable(MySqlConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE `foodtable` (" +
                                                "`category` varchar(30) NOT NULL," +
                                                "`ID` varchar(45) NOT NULL," +
                                                "`title` varchar(45) NOT NULL," +
                                                "`price` varchar(45) NOT NULL," +
                                                "`picture` varchar(100) NOT NULL," +
                                                "PRIMARY KEY (`ID`));", conn);
            cmd.ExecuteNonQuery();

            cmd = new MySqlCommand("CREATE TABLE `hotplaterestaurant`.`ordertable` (" +
                                   "`CustomerID` VARCHAR(40) NOT NULL," +
                                   "`CustomerName` VARCHAR(45) NOT NULL," +
                                   "`Total` INT NOT NULL," +
                                   "`Order` VARCHAR(500) NULL," +
                                   "PRIMARY KEY (`CustomerID`));", conn);

            cmd.ExecuteNonQuery();
        }

        static void deleteEverything(MySqlConnection conn)
        {
            (new MySqlCommand("DROP TABLE foodtable;", conn))
                .ExecuteNonQuery();
            (new MySqlCommand("DROP TABLE ordertable;", conn))
                .ExecuteNonQuery();
        }

        static void insertSampleMenu(MySqlConnection conn)
        {
            (new MySqlCommand(
                    "INSERT INTO foodtable VALUES ('burger','1','Hamburger','5.30','hamburger.jpg')",
                    conn)).ExecuteNonQuery();
        }
    }
}