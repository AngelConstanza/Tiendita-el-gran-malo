using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.BLL
{
    public class GananciasBLL
    {
        private int id;
        private string ganancias_diarias;
        private string ganancias_semanales;
        private string ganancias_mensuales;
        private string ganancias_anuales;


        public GananciasBLL(int id)
        {
            this.id = id;
        }

        public GananciasBLL(int id, string ganancias_diarias, string ganancias_semanales, string ganancias_mensuales, string ganancias_anuales)
        {
            this.id = id;
            this.ganancias_diarias = ganancias_diarias;
            this.ganancias_semanales = ganancias_semanales;
            this.ganancias_mensuales = ganancias_mensuales;
            this.ganancias_anuales = ganancias_anuales;

        }




        public int Id_local { get => id; set => id = value; }
        public string Ganancias_diarias { get => ganancias_diarias; set => ganancias_diarias = value; }
        public string Ganancias_semanales { get => ganancias_semanales; set => ganancias_semanales = value; }
        public string Ganancias_mensuales { get => ganancias_mensuales; set => ganancias_mensuales = value; }
        public string Ganancias_anuale { get => ganancias_anuales; set => ganancias_anuales = value; }

    }


}
