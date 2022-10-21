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
    public class LocalDAL
    {
        private Database db;
        public LocalDAL()
        {
            db = new Database();
        }

        public DataTable getAllLocal()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
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

        public bool createLocal(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (id,id_proveedor,ubicacion,horarios,cantidad_de_empleados) VALUES (@id, @idpro, @ubi, @hora, @cantemple);";
                    cmd.Parameters.AddWithValue("@id", Local.id);
                    cmd.Parameters.AddWithValue("@idpro", Local.id_proveedor);
                    cmd.Parameters.AddWithValue("@ubi", Local.ubicacion);
                    cmd.Parameters.AddWithValue("@hora", Local.horarios);
                    cmd.Parameters.AddWithValue("@cantemple", Local.cantidad_de_empleados);



                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }

        public bool createLocal(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (id,id_proveedor,ubicacion,horarios,cantidad_de_empleados) VALUES (@id, @idpro, @ubi, @hora, @canti);";
                    cmd.Parameters.AddWithValue("@id", Local.id);
                    cmd.Parameters.AddWithValue("@idpro", Local.id_proveedor);
                    cmd.Parameters.AddWithValue("@ubi", Local.ubicacion);
                    cmd.Parameters.AddWithValue("@hora", Local.horarios);
                    cmd.Parameters.AddWithValue("@cantemple", Local.cantidad_de_empleados);

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

        public bool deleteLocal(LocalBLL Local)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Local WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", Local.Id);
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
