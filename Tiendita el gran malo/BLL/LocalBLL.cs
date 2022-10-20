using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.BLL
{
    public class LocalBLL
    {
        private int id;
        private string id_proveedor;
        private string Ubicacion;
        private string Horarios;
        private string Cantidad_de_empleados;


        public LocalBLL(int id)
        {
            this.id = id;
        }

        public LocalBLL(int id, string id_proveedor, string ubicacion, string Horarios, string Cantidad_de_empleados)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
            this.ubicacion = ubicacion;
            this.horarios = Horarios;
            this.cantidad_de_empleados = Cantidad_de_empleados;

        }

         


        public int Id_local { get => id; set => id = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string ubicacion { get => ubicacion; set => ubicacion = value; }
        public string horarios { get => horarios; set => horarios = value; }
        public string cantidad_de_empleados { get => Cantidad_de_empleados; set => Cantidad_de_empleados = value; }

    }


}