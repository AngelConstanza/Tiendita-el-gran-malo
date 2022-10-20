using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.BLL
{
    public class ProveedorBLL
    {
        private int id;
        private string nombre_del_proveedor;
        private string tipo_de_producto;
        private string cantidad;
        private string precio;


        public ProveedorBLL(int id)
        {
            this.id = id;
        }

        public ProveedorBLL(int id, string nombre_del_proveedor, string tipo_de_producto, string cantidad, string precio)
        {
            this.id = id;
            this.nombre_del_proveedor = nombre_del_proveedor;
            this.tipo_de_producto = tipo_de_producto;
            this.cantidad = cantidad;
            this.precio = precio;

        }




        public int Id_local { get => id; set => id = value; }
        public string Nombre_del_proveedor { get => nombre_del_proveedor; set => nombre_del_proveedor = value; }
        public string Tipo_de_producto { get => tipo_de_producto; set => tipo_de_producto = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Precio { get => precio; set => precio = value; }

    }


}