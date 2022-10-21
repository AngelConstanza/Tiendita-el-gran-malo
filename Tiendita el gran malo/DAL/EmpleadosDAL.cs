using Tiendita_el_gran_malo.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.DAL
{
    public class ProveedorDAL
    {
        private Database db;
        public ProveedorDAL()
        {
            db = new Database();
        }

        public DataTable getAllEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Proveedor";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch
            {
                return dt;
            }
        }

        public bool createEmpleado(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, puesto, salario) VALUES (@nom, @ap, @pu, @sal);";
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@pu", emp.Puesto);
                    cmd.Parameters.AddWithValue("@sal", emp.Salario);
                    cmd.ExecuteNonQuery();
                    Con.Close();



                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool createEmpleado(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, puesto, salario) VALUES (@nom, @ap, @pu, @sal);";
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@pu", emp.Puesto);
                    cmd.Parameters.AddWithValue("@sal", emp.Salario);
                    cmd.ExecuteNonQuery();
                    Con.Close();


                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool deleteEmpleado(EmpleadosBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
