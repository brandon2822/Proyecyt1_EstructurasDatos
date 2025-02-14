namespace PROYECTOBD
{
    partial class Modificar
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
            this.btnModProveedor = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnModProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModProveedor
            // 
            this.btnModProveedor.Location = new System.Drawing.Point(545, 218);
            this.btnModProveedor.Name = "btnModProveedor";
            this.btnModProveedor.Size = new System.Drawing.Size(133, 78);
            this.btnModProveedor.TabIndex = 7;
            this.btnModProveedor.Text = "MODIFICAR PROVEEDOR";
            this.btnModProveedor.UseVisualStyleBackColor = true;
            this.btnModProveedor.Click += new System.EventHandler(this.btnModProveedor_Click);
            // 
            // btnModPedido
            // 
            this.btnModPedido.Location = new System.Drawing.Point(334, 218);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(133, 78);
            this.btnModPedido.TabIndex = 6;
            this.btnModPedido.Text = "MODIFICAR PEDIDO";
            this.btnModPedido.UseVisualStyleBackColor = true;
            this.btnModPedido.Click += new System.EventHandler(this.btnModPedido_Click);
            // 
            // btnModProducto
            // 
            this.btnModProducto.Location = new System.Drawing.Point(123, 218);
            this.btnModProducto.Name = "btnModProducto";
            this.btnModProducto.Size = new System.Drawing.Size(133, 78);
            this.btnModProducto.TabIndex = 5;
            this.btnModProducto.Text = "MODIFICAR PRODUCTO";
            this.btnModProducto.UseVisualStyleBackColor = true;
            this.btnModProducto.Click += new System.EventHandler(this.btnModProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(176, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la Tabla a la que desea modificar un registro:";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModProveedor);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnModProducto);
            this.Controls.Add(this.label1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModProveedor;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.Button btnModProducto;
        private System.Windows.Forms.Label label1;
    }
}