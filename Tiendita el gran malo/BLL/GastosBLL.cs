using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.BLL
{
    public class GastosBLL
    {
        private int id;
        private string gasto_energetico;
        private string gasto_de_Anda;
        private string gasto_de_wifi;
        private string Impuesto_municipal;
        private string gasto_publicitario;
        private string gasto_de_vigilancia;


        public GastosBLL(int id)
        {
            this.id = id;
        }

        public GastosBLL(int id, string gasto_energetico, string gasto_de_Anda, string gasto_de_wifi, string Impuesto_municipal, string gasto_publicitario, string gasto_de_vigilancia)
        {
            this.id = id;
            this.gasto_energetico = gasto_energetico;
            this.gasto_de_Anda = gasto_de_Anda;
            this.gasto_de_wifi = gasto_de_wifi;
            this.impuesto_municipal = impuesto_municipal;
            this.gasto_publicitario = gasto_publicitario;
            this.gasto_de_vigilancia = gasto_de_vigilancia;

        }




        public int Id_local { get => id; set => id = value; }
        public string Gasto_energetico { get => gasto_energetico; set => gasto_energetico = value; }
        public string Gasto_de_Anda { get => gasto_de_Anda; set => gasto_de_Anda = value; }
        public string Gasto_de_wifi { get => gasto_de_wifi; set => gasto_de_wifi = value; }
        public string impuesto_municipal { get => impuesto_municipal; set => impuesto_municipal = value; }
        public string Gasto_publicitario { get => gasto_publicitario; set => gasto_publicitario = value; }
        public string Gasto_de_vigilancia { get => gasto_de_vigilancia; set => gasto_de_vigilancia = value; }



    }


}




