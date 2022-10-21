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
    public class GananciasDAL
    {
        private Database db;
        public GananciasDAL()
        {
            db = new Database();
        }

        public DataTable getAllGanancias()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Ganancias";
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

        public bool createGanancias(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, Proveedor proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ganancias  (id_local, ganancias_diarias, ganancias_semanales, ganancias_mensuales, ganancias_anuales) VALUES (@idlocal, @gan_di, @gan_sem @gan_men, Ganancias.anuales;";
                    cmd.Parameters.AddWithValue("@id_local", Ganancias.id_local);
                    cmd.Parameters.AddWithValue("@gan_di", Ganancias.ganancias_diarias);
                    cmd.Parameters.AddWithValue("@gan_sem", Ganancias.ganancias_semanales);
                    cmd.Parameters.AddWithValue("@gan_men", Ganancias.ganancias_mensuales);
                    cmd.Parameters.AddWithValue("@gan_anu", Ganancias.ganancias_anuales);

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

        public bool createGanancias(EmpleadosBLL emp, GananciasBLL Ganancias, GastosBLL Gastos, LocalBLL Local, Proveedor proveedor)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Ganancias  (id_local, ganancias_diarias, ganancias_semanales, ganancias_mensuales, ganancias_anuales) VALUES (@idlocal, @gan_di, @gan_sem @gan_men, Ganancias.anuales;";
                    cmd.Parameters.AddWithValue("@id_local", Ganancias.id_local);
                    cmd.Parameters.AddWithValue("@gan_di", Ganancias.ganancias_diarias);
                    cmd.Parameters.AddWithValue("@gan_sem", Ganancias.ganancias_semanales);
                    cmd.Parameters.AddWithValue("@gan_men", Ganancias.ganancias_mensuales);
                    cmd.Parameters.AddWithValue("@gan_anu", Ganancias.ganancias_anuales);

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

        public bool deleteGanancias(GananciasBLL Ganancias)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Ganancias WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", Ganancias.Id);
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
