using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKFinance.Database
{
    internal class Connection
    {
        public string dataConnection() 
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Murillo\\projects\\CKFinance\\CkFinance.mdf;Integrated Security=True";

            return connection;
        }
    }
}
