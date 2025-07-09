namespace ProyectoYambolyFinal
{
    partial class MantenedorProducto
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
            this.Producto = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Presnetacion = new System.Windows.Forms.GroupBox();
            this.btnMostrarP = new System.Windows.Forms.Button();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPresentacionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.dgvPresentaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarPre = new System.Windows.Forms.Button();
            this.btnModificarPre = new System.Windows.Forms.Button();
            this.btnNPresentacion = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.Presnetacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Producto
            // 
            this.Producto.Controls.Add(this.btnMostrar);
            this.Producto.Controls.Add(this.txtProductoID);
            this.Producto.Controls.Add(this.label5);
            this.Producto.Controls.Add(this.dgvProductos);
            this.Producto.Controls.Add(this.btnNuevo);
            this.Producto.Controls.Add(this.btnModificar);
            this.Producto.Controls.Add(this.btnEliminar);
            this.Producto.Controls.Add(this.label2);
            this.Producto.Controls.Add(this.txtDescripcion);
            this.Producto.Controls.Add(this.txtProducto);
            this.Producto.Controls.Add(this.label1);
            this.Producto.Location = new System.Drawing.Point(11, 11);
            this.Producto.Margin = new System.Windows.Forms.Padding(2);
            this.Producto.Name = "Producto";
            this.Producto.Padding = new System.Windows.Forms.Padding(2);
            this.Producto.Size = new System.Drawing.Size(400, 418);
            this.Producto.TabIndex = 24;
            this.Producto.TabStop = false;
            this.Producto.Text = "Menu Producto";
            this.Producto.Enter += new System.EventHandler(this.Producto_Enter);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(318, 122);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(68, 19);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(76, 27);
            this.txtProductoID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(68, 20);
            this.txtProductoID.TabIndex = 14;
            this.txtProductoID.TextChanged += new System.EventHandler(this.txtProductoID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID-Producto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(8, 145);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(379, 265);
            this.dgvProductos.TabIndex = 7;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(8, 122);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(76, 122);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 19);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(156, 122);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 19);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(76, 85);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(310, 20);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(76, 54);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(310, 20);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Presnetacion
            // 
            this.Presnetacion.Controls.Add(this.btnMostrarP);
            this.Presnetacion.Controls.Add(this.txtCantidadP);
            this.Presnetacion.Controls.Add(this.label7);
            this.Presnetacion.Controls.Add(this.txtPresentacionID);
            this.Presnetacion.Controls.Add(this.label6);
            this.Presnetacion.Controls.Add(this.txtPresentacion);
            this.Presnetacion.Controls.Add(this.dgvPresentaciones);
            this.Presnetacion.Controls.Add(this.label4);
            this.Presnetacion.Controls.Add(this.btnEliminarPre);
            this.Presnetacion.Controls.Add(this.btnModificarPre);
            this.Presnetacion.Controls.Add(this.btnNPresentacion);
            this.Presnetacion.Controls.Add(this.txtPrecio);
            this.Presnetacion.Controls.Add(this.label3);
            this.Presnetacion.Location = new System.Drawing.Point(456, 15);
            this.Presnetacion.Margin = new System.Windows.Forms.Padding(2);
            this.Presnetacion.Name = "Presnetacion";
            this.Presnetacion.Padding = new System.Windows.Forms.Padding(2);
            this.Presnetacion.Size = new System.Drawing.Size(412, 462);
            this.Presnetacion.TabIndex = 25;
            this.Presnetacion.TabStop = false;
            this.Presnetacion.Text = "Menu Presentacion";
            this.Presnetacion.Enter += new System.EventHandler(this.Presnetacion_Enter);
            // 
            // btnMostrarP
            // 
            this.btnMostrarP.Location = new System.Drawing.Point(332, 141);
            this.btnMostrarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarP.Name = "btnMostrarP";
            this.btnMostrarP.Size = new System.Drawing.Size(62, 19);
            this.btnMostrarP.TabIndex = 16;
            this.btnMostrarP.Text = "Mostrar";
            this.btnMostrarP.UseVisualStyleBackColor = true;
            this.btnMostrarP.Click += new System.EventHandler(this.btnMostrarP_Click);
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(84, 113);
            this.txtCantidadP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(77, 20);
            this.txtCantidadP.TabIndex = 24;
            this.txtCantidadP.TextChanged += new System.EventHandler(this.txtCantidadP_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cantidad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPresentacionID
            // 
            this.txtPresentacionID.Location = new System.Drawing.Point(94, 25);
            this.txtPresentacionID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPresentacionID.Name = "txtPresentacionID";
            this.txtPresentacionID.Size = new System.Drawing.Size(68, 20);
            this.txtPresentacionID.TabIndex = 15;
            this.txtPresentacionID.TextChanged += new System.EventHandler(this.txtPresentacionID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID-Presentacion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(84, 53);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(310, 20);
            this.txtPresentacion.TabIndex = 16;
            this.txtPresentacion.TextChanged += new System.EventHandler(this.txtPresentacion_TextChanged);
            // 
            // dgvPresentaciones
            // 
            this.dgvPresentaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresentaciones.Location = new System.Drawing.Point(14, 168);
            this.dgvPresentaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPresentaciones.Name = "dgvPresentaciones";
            this.dgvPresentaciones.RowHeadersWidth = 51;
            this.dgvPresentaciones.RowTemplate.Height = 24;
            this.dgvPresentaciones.Size = new System.Drawing.Size(379, 265);
            this.dgvPresentaciones.TabIndex = 18;
            this.dgvPresentaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresentaciones_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presentacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEliminarPre
            // 
            this.btnEliminarPre.Location = new System.Drawing.Point(196, 141);
            this.btnEliminarPre.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPre.Name = "btnEliminarPre";
            this.btnEliminarPre.Size = new System.Drawing.Size(56, 19);
            this.btnEliminarPre.TabIndex = 21;
            this.btnEliminarPre.Text = "Eliminar";
            this.btnEliminarPre.UseVisualStyleBackColor = true;
            this.btnEliminarPre.Click += new System.EventHandler(this.btnEliminarPre_Click);
            // 
            // btnModificarPre
            // 
            this.btnModificarPre.Location = new System.Drawing.Point(128, 141);
            this.btnModificarPre.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarPre.Name = "btnModificarPre";
            this.btnModificarPre.Size = new System.Drawing.Size(64, 19);
            this.btnModificarPre.TabIndex = 20;
            this.btnModificarPre.Text = "Modificar";
            this.btnModificarPre.UseVisualStyleBackColor = true;
            this.btnModificarPre.Click += new System.EventHandler(this.btnModificarPre_Click);
            // 
            // btnNPresentacion
            // 
            this.btnNPresentacion.Location = new System.Drawing.Point(14, 141);
            this.btnNPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnNPresentacion.Name = "btnNPresentacion";
            this.btnNPresentacion.Size = new System.Drawing.Size(103, 19);
            this.btnNPresentacion.TabIndex = 19;
            this.btnNPresentacion.Text = "Nuevo Presentacion";
            this.btnNPresentacion.UseVisualStyleBackColor = true;
            this.btnNPresentacion.Click += new System.EventHandler(this.btnNPresentacion_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(84, 81);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 485);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Presnetacion);
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            this.Load += new System.EventHandler(this.MantenedorProducto_Load);
            this.Producto.ResumeLayout(false);
            this.Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.Presnetacion.ResumeLayout(false);
            this.Presnetacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresentaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Producto;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Presnetacion;
        private System.Windows.Forms.Button btnMostrarP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPresentacionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.DataGridView dgvPresentaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarPre;
        private System.Windows.Forms.Button btnModificarPre;
        private System.Windows.Forms.Button btnNPresentacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
    }
}