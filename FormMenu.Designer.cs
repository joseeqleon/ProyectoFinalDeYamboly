namespace ProyectoYambolyFinal
{
    partial class FormMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRPago = new System.Windows.Forms.Button();
            this.btnRPedido = new System.Windows.Forms.Button();
            this.btnRVenta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMProducto = new System.Windows.Forms.Button();
            this.btnMEmpresa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRPago);
            this.groupBox1.Controls.Add(this.btnRPedido);
            this.groupBox1.Controls.Add(this.btnRVenta);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(582, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRPago
            // 
            this.btnRPago.Location = new System.Drawing.Point(230, 40);
            this.btnRPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnRPago.Name = "btnRPago";
            this.btnRPago.Size = new System.Drawing.Size(115, 43);
            this.btnRPago.TabIndex = 4;
            this.btnRPago.Text = "Realizar Pago";
            this.btnRPago.UseVisualStyleBackColor = true;
            this.btnRPago.Click += new System.EventHandler(this.btnRPago_Click);
            // 
            // btnRPedido
            // 
            this.btnRPedido.Location = new System.Drawing.Point(58, 40);
            this.btnRPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnRPedido.Name = "btnRPedido";
            this.btnRPedido.Size = new System.Drawing.Size(115, 43);
            this.btnRPedido.TabIndex = 5;
            this.btnRPedido.Text = "Realizar Pedido";
            this.btnRPedido.UseVisualStyleBackColor = true;
            this.btnRPedido.Click += new System.EventHandler(this.btnRPedido_Click);
            // 
            // btnRVenta
            // 
            this.btnRVenta.Location = new System.Drawing.Point(410, 40);
            this.btnRVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRVenta.Name = "btnRVenta";
            this.btnRVenta.Size = new System.Drawing.Size(115, 43);
            this.btnRVenta.TabIndex = 3;
            this.btnRVenta.Text = "Realizar Venta";
            this.btnRVenta.UseVisualStyleBackColor = true;
            this.btnRVenta.Click += new System.EventHandler(this.btnRVenta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMProducto);
            this.groupBox2.Controls.Add(this.btnMEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(11, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(582, 126);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MANTENEDORES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnMProducto
            // 
            this.btnMProducto.Location = new System.Drawing.Point(50, 46);
            this.btnMProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnMProducto.Name = "btnMProducto";
            this.btnMProducto.Size = new System.Drawing.Size(115, 43);
            this.btnMProducto.TabIndex = 1;
            this.btnMProducto.Text = "Mant_Producto";
            this.btnMProducto.UseVisualStyleBackColor = true;
            this.btnMProducto.Click += new System.EventHandler(this.btnMProducto_Click);
            // 
            // btnMEmpresa
            // 
            this.btnMEmpresa.Location = new System.Drawing.Point(380, 46);
            this.btnMEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMEmpresa.Name = "btnMEmpresa";
            this.btnMEmpresa.Size = new System.Drawing.Size(115, 43);
            this.btnMEmpresa.TabIndex = 2;
            this.btnMEmpresa.Text = "Mant_Empresa";
            this.btnMEmpresa.UseVisualStyleBackColor = true;
            this.btnMEmpresa.Click += new System.EventHandler(this.btnMEmpresa_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRPago;
        private System.Windows.Forms.Button btnRPedido;
        private System.Windows.Forms.Button btnRVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMProducto;
        private System.Windows.Forms.Button btnMEmpresa;
    }
}

