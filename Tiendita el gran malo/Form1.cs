using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiendita_el_gran_malo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form proveedor = new Form2();
            proveedor.Show();
        }

        private void local_Click(object sender, EventArgs e)
        {
            Form local = new Form3();
            local.Show();
        }

        private void ganancia_Click(object sender, EventArgs e)
        {
            Form ganancias = new Form4();
            ganancias.Show();
        }

        private void gastos_Click(object sender, EventArgs e)
        {
            Form gastos = new Form5();
            gastos.Show();
        }

        private void empleado_Click(object sender, EventArgs e)
        {
            Form empleado = new Form6();
            empleado.Show();
        }
    }
}
