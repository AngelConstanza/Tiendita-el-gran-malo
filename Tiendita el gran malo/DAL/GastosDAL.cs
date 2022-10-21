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
    public class GastosDAL
    {
        private Database db;
        public GastosDAL()
        {
            db = new Database();
        }

        public DataTable getAllGastos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Gastos";
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
                    cmd.CommandText = "INSERT INTO Empleados (id_local, gasto_energetico, gasto_de_anda, gasto_de_wifi, impuesto_municipal, gasto_publicitario, gasto_de_vigilancia) VALUES (@idlocal, @gastoener, @gastoan, @gastowi, @impumuni, @gastopubli, @gastovigi);";
                    cmd.Parameters.AddWithValue("@idlocal", Gastos.id_local);
                    cmd.Parameters.AddWithValue("@gastoener", Gastos.gasto_energetico);
                    cmd.Parameters.AddWithValue("@gastoan", Gastos.gasto_anda);
                    cmd.Parameters.AddWithValue("@gastowi", Gastos.gasto_wifi);
                    cmd.Parameters.AddWithValue("@impumuni", Gastos.impuesto_municipal);
                    cmd.Parameters.AddWithValue("@gastopubli", Gastos.gasto_publicitario);
                    cmd.Parameters.AddWithValue("@gastovigi", Gastos.gasto_de_vigilancia);
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
                    cmd.CommandText = "INSERT INTO Ganancias (id_local, gasto_energetico, gasto_de_anda, gasto_de_wifi, impuesto_municipal, gasto_publicitario, gasto_de_vigilancia) VALUES (@idlocal, @gastoener, @gastoan, @gastowi, @impumuni, @gastopubli, @gastovigi);";
                    cmd.Parameters.AddWithValue("@idlocal", Gastos.id_local);
                    cmd.Parameters.AddWithValue("@gastoener", Gastos.gasto_energetico);
                    cmd.Parameters.AddWithValue("@gastoan", Gastos.gasto_anda);
                    cmd.Parameters.AddWithValue("@gastowi", Gastos.gasto_wifi);
                    cmd.Parameters.AddWithValue("@impumuni", Gastos.impuesto_municipal);
                    cmd.Parameters.AddWithValue("@gastopubli", Gastos.gasto_publicitario);
                    cmd.Parameters.AddWithValue("@gastovigi", Gastos.gasto_de_vigilancia);

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

        public bool deleteGastos(GastosBLL Gastos)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Gastos WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", Gastos.Id);
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
