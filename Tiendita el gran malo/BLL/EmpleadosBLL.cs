using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_el_gran_malo.BLL
{
   public class EmpleadosBLL
   {
        private int id;
        private string nombres;
        private string apellidos;
        private string puesto;
        private string salario;
        
        
        public EmpleadosBLL(int id)
        {
            this.id = id;
        }
        
            public EmpleadosBLL(int id, string nombres, string apellidos, string puesto, string salario)
            {
                this.id = id;
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.puesto = puesto;
                this.salario = salario;

            }




        public int Id_local { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Salario { get => salario; set => salario = value; }

    }


}

    


   
    


