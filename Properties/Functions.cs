using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CKFinance.Properties
{
    public class Functions
    {
        public void openMidias(string value)
        {
            Process.Start(value);

        }

        public void query(string query) 
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Murillo\\projects\\CKFinance\\CkFinance.mdf;Integrated Security=True";
            string queryString = query;
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(connection);
                SqlCommand sqlCommand = new SqlCommand(queryString, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
                
            }
        }

       public void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
                e.Handled = true;   
        }

       
    }
}