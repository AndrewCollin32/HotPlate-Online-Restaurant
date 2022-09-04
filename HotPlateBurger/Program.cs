using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


// This program was created by Andrew Collin

namespace HotPlateBurger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //--------------------------------------------------------------------------------------------------------------
        //Comment begins here
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotPlateData());
        }
        
        //Comment ends here
        //--------------------------------------------------------------------------------------------------------------
    }
}