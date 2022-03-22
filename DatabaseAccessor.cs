using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_transaktion_Forms
{
    class DatabaseAccessor
    {
        public static void ConnectToDatabase()
        {
            string strconn = @"Data Source=" + Environment.MachineName + ";Initial Catalog=Fly;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
