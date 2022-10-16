
namespace Tiendita_el_gran_malo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.proveedor = new System.Windows.Forms.Button();
            this.local = new System.Windows.Forms.Button();
            this.ganancia = new System.Windows.Forms.Button();
            this.gastos = new System.Windows.Forms.Button();
            this.empleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(341, 87);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(153, 23);
            this.proveedor.TabIndex = 0;
            this.proveedor.Text = "Proveedor de producto";
            this.proveedor.UseVisualStyleBackColor = true;
            this.proveedor.Click += new System.EventHandler(this.button1_Click);
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(374, 142);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(75, 23);
            this.local.TabIndex = 1;
            this.local.Text = "Locales";
            this.local.UseVisualStyleBackColor = true;
            this.local.Click += new System.EventHandler(this.local_Click);
            // 
            // ganancia
            // 
            this.ganancia.Location = new System.Drawing.Point(374, 194);
            this.ganancia.Name = "ganancia";
            this.ganancia.Size = new System.Drawing.Size(75, 23);
            this.ganancia.TabIndex = 2;
            this.ganancia.Text = "Ganancias";
            this.ganancia.UseVisualStyleBackColor = true;
            this.ganancia.Click += new System.EventHandler(this.ganancia_Click);
            // 
            // gastos
            // 
            this.gastos.Location = new System.Drawing.Point(374, 239);
            this.gastos.Name = "gastos";
            this.gastos.Size = new System.Drawing.Size(75, 23);
            this.gastos.TabIndex = 3;
            this.gastos.Text = "Gastos";
            this.gastos.UseVisualStyleBackColor = true;
            this.gastos.Click += new System.EventHandler(this.gastos_Click);
            // 
            // empleado
            // 
            this.empleado.Location = new System.Drawing.Point(341, 285);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(153, 23);
            this.empleado.TabIndex = 4;
            this.empleado.Text = "Registrar un empleado";
            this.empleado.UseVisualStyleBackColor = true;
            this.empleado.Click += new System.EventHandler(this.empleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿A que base de dato deseas acceder?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empleado);
            this.Controls.Add(this.gastos);
            this.Controls.Add(this.ganancia);
            this.Controls.Add(this.local);
            this.Controls.Add(this.proveedor);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proveedor;
        private System.Windows.Forms.Button local;
        private System.Windows.Forms.Button ganancia;
        private System.Windows.Forms.Button gastos;
        private System.Windows.Forms.Button empleado;
        private System.Windows.Forms.Label label1;
    }
}

