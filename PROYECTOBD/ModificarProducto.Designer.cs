namespace PROYECTOBD
{
    partial class ModificarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtIDproducto = new System.Windows.Forms.TextBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.txtModPrecio = new System.Windows.Forms.TextBox();
            this.txtModDescripcion = new System.Windows.Forms.TextBox();
            this.txtModCantidad = new System.Windows.Forms.TextBox();
            this.txtModCategoria = new System.Windows.Forms.TextBox();
            this.txtModProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 374);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(228, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 51);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(75, 67);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 51);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtIDproducto
            // 
            this.txtIDproducto.Location = new System.Drawing.Point(280, 26);
            this.txtIDproducto.Name = "txtIDproducto";
            this.txtIDproducto.Size = new System.Drawing.Size(100, 20);
            this.txtIDproducto.TabIndex = 30;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(214, 149);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(100, 20);
            this.txtModNombre.TabIndex = 29;
            // 
            // txtModPrecio
            // 
            this.txtModPrecio.Location = new System.Drawing.Point(214, 227);
            this.txtModPrecio.Name = "txtModPrecio";
            this.txtModPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtModPrecio.TabIndex = 28;
            // 
            // txtModDescripcion
            // 
            this.txtModDescripcion.Location = new System.Drawing.Point(214, 191);
            this.txtModDescripcion.Name = "txtModDescripcion";
            this.txtModDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtModDescripcion.TabIndex = 27;
            // 
            // txtModCantidad
            // 
            this.txtModCantidad.Location = new System.Drawing.Point(214, 271);
            this.txtModCantidad.Name = "txtModCantidad";
            this.txtModCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtModCantidad.TabIndex = 26;
            // 
            // txtModCategoria
            // 
            this.txtModCategoria.Location = new System.Drawing.Point(214, 316);
            this.txtModCategoria.Name = "txtModCategoria";
            this.txtModCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtModCategoria.TabIndex = 25;
            // 
            // txtModProveedor
            // 
            this.txtModProveedor.Location = new System.Drawing.Point(214, 364);
            this.txtModProveedor.Name = "txtModProveedor";
            this.txtModProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtModProveedor.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID de Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ingrese el ID del producto a modificar:";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIDproducto);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.txtModPrecio);
            this.Controls.Add(this.txtModDescripcion);
            this.Controls.Add(this.txtModCantidad);
            this.Controls.Add(this.txtModCategoria);
            this.Controls.Add(this.txtModProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIDproducto;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.TextBox txtModPrecio;
        private System.Windows.Forms.TextBox txtModDescripcion;
        private System.Windows.Forms.TextBox txtModCantidad;
        private System.Windows.Forms.TextBox txtModCategoria;
        private System.Windows.Forms.TextBox txtModProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}