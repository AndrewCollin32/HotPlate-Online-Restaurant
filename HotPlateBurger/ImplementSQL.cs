using MySql.Data.MySqlClient;

namespace HotPlateBurger
{
    public class ImplementSQL
    {
        //Creates table and uploads sample data
        static void Main()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.Open();
        }
    }
}