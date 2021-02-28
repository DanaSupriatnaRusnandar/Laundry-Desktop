using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection.setConnection("localhost", "laundry", "root", "");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());

            //Tes Koneksi Database
            /*if (Connection.Ping()) Application.Run(new Login());
            else MessageBox.Show("Tidak dapat terhubung pada Database.", "DATABASE CONNECTION ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error );*/
        }
    }
}
