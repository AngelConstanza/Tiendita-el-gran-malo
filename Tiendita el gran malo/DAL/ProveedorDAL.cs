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

        public DataTable getAllProveedor()
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

        public bool createProveedor(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, ProveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Proveedor (id, nOmbre_proveedor, tipo_producto, cantidad, precio) VALUES (@id, @nompro, @tipro, @can, @pre);";
                    cmd.Parameters.AddWithValue("@id", proveedor.id);
                    cmd.Parameters.AddWithValue("@nompro", proveedor.nombre_proveedor);
                    cmd.Parameters.AddWithValue("@tipro", proveedor.tipo_producto);
                    cmd.Parameters.AddWithValue("@can", proveedor.cantidad);
                    cmd.Parameters.AddWithValue("@pre", proveedor.precio);
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
                    cmd.CommandText = "INSERT INTO proveedor (id, nombre_proveedor, tipo_producto, cantidad, precio) VALUES (@id, @nompro, @tipro, @can, @pre);";
                    cmd.Parameters.AddWithValue("@id", proveedor.id);
                    cmd.Parameters.AddWithValue("@nompro", proveedor.id_proveedor);
                    cmd.Parameters.AddWithValue("@tipro", proveedor.tipo_producto);
                    cmd.Parameters.AddWithValue("@can", proveedor.cantidad);
                    cmd.Parameters.AddWithValue("@pre", proveedor.precio);

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

        public bool deleteproveedor(proveedorBLL proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM proveedor WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", proveedor.Id);
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
