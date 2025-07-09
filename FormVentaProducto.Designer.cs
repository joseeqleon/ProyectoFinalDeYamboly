namespace ProyectoYambolyFinal
{
    partial class FormVentaProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.lblPresentacion);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.btnCancelarVenta);
            this.groupBox1.Controls.Add(this.btnRegistrarVenta);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPedido);
            this.groupBox1.Controls.Add(this.txtIdVenta);
            this.groupBox1.Controls.Add(this.dtpFechaVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(453, 255);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Venta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(372, 232);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(76, 19);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(74, 169);
            this.lblPresentacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(89, 13);
            this.lblPresentacion.TabIndex = 26;
            this.lblPresentacion.Text = "Presentacion info";
            this.lblPresentacion.Click += new System.EventHandler(this.lblPresentacion_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(74, 129);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 13);
            this.lblProducto.TabIndex = 25;
            this.lblProducto.Text = "Producto info";
            this.lblProducto.Click += new System.EventHandler(this.lblProducto_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(71, 88);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(69, 13);
            this.lblEmpresa.TabIndex = 24;
            this.lblEmpresa.Text = "Empresa Info";
            this.lblEmpresa.Click += new System.EventHandler(this.lblEmpresa_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(301, 232);
            this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(67, 19);
            this.btnCancelarVenta.TabIndex = 23;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(232, 232);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(64, 19);
            this.btnRegistrarVenta.TabIndex = 22;
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(71, 213);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 13);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad info";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Empresa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presentacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbPedido
            // 
            this.cmbPedido.DisplayMember = "Nombre";
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(74, 55);
            this.cmbPedido.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(161, 21);
            this.cmbPedido.TabIndex = 11;
            this.cmbPedido.ValueMember = "Nombre";
            this.cmbPedido.SelectedIndexChanged += new System.EventHandler(this.cmbPedido_SelectedIndexChanged);
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(74, 24);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(80, 20);
            this.txtIdVenta.TabIndex = 4;
            this.txtIdVenta.TextChanged += new System.EventHandler(this.txtIdVenta_TextChanged);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(253, 42);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaVenta.TabIndex = 7;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpFechaVenta_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Venta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IDPedido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdVenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(2, 261);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(453, 203);
            this.dgvVentas.TabIndex = 8;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // FormVentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVentas);
            this.Name = "FormVentaProducto";
            this.Text = "FormVentaProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}