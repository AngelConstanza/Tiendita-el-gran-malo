using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.DAL
{
    public class DataBase
    {
        public static string getStrConnection()
        {
            return Settings.Default.ParcialConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getConnection());
            return Con
        }

        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open()
                if (Con.State == System.Data.ConnectionState.Open)
                {
                   Con.Close();
                   return true;
                }
                else
                {
                   return false
                }
        }
    }
}