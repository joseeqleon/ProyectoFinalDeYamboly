using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoYambolyFinal
{
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
        }

        private void MantenedorProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
        private void ListarProductos()
        {
            dgvProductos.DataSource = logProducto.Instancia.ListarProducto();
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductoID.Text = dgvProductos.Rows[e.RowIndex].Cells["ProductoID"].Value.ToString();
                txtProducto.Text = dgvProductos.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

                int id = Convert.ToInt32(txtProductoID.Text);
                dgvPresentaciones.DataSource = logPresentacion.Instancia.ListarPresentaciones(id);
            }
        }
        private void Producto_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            entProducto p = new entProducto
            {
                Producto = txtProducto.Text,
                Descripcion = txtDescripcion.Text
            };
            logProducto.Instancia.InsertarProducto(p);
            ListarProductos();
            LimpiarProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            entProducto p = new entProducto
            {
                ProductoID = Convert.ToInt32(txtProductoID.Text),
                Producto = txtProducto.Text,
                Descripcion = txtDescripcion.Text
            };
            logProducto.Instancia.EditarProducto(p);
            ListarProductos();
            LimpiarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtProductoID.Text);
            logProducto.Instancia.EliminarProducto(id); // FALTA ESTA LÍNEA
            ListarProductos();
            LimpiarProducto();
        }
        private void LimpiarProducto()
        {
            txtProductoID.Clear();
            txtProducto.Clear();
            txtDescripcion.Clear();
            dgvPresentaciones.DataSource = null;
        }
        // ---------------------- PRESENTACIONES ----------------------
        private void ListarTodasLasPresentaciones()
        {
            dgvPresentaciones.DataSource = logPresentacion.Instancia.ListarPresentacionesGlobal();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Presnetacion_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPresentacionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNPresentacion_Click(object sender, EventArgs e)
        {
            entPresentacion pr = new entPresentacion
            {
                ProductoID = Convert.ToInt32(txtProductoID.Text),
                Presentacion = txtPresentacion.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Cantidad = Convert.ToInt32(txtCantidadP.Text)
            };

            logPresentacion.Instancia.RegistrarPresentacion(pr);
            dgvPresentaciones.DataSource = logPresentacion.Instancia.ListarPresentaciones(pr.ProductoID);
            LimpiarPresentacion();
        }

        private void btnModificarPre_Click(object sender, EventArgs e)
        {
            entPresentacion pr = new entPresentacion
            {
                PresentacionID = Convert.ToInt32(txtPresentacionID.Text),
                Presentacion = txtPresentacion.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Cantidad = Convert.ToInt32(txtCantidadP.Text)
            };

            logPresentacion.Instancia.EditarPresentacion(pr);
            dgvPresentaciones.DataSource = logPresentacion.Instancia.ListarPresentaciones(Convert.ToInt32(txtProductoID.Text));
            LimpiarPresentacion();
        }

        private void btnEliminarPre_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtPresentacionID.Text);
            logPresentacion.Instancia.EliminarPresentacion(id);
            dgvPresentaciones.DataSource = logPresentacion.Instancia.ListarPresentaciones(Convert.ToInt32(txtProductoID.Text));
            LimpiarPresentacion();
        }
        private void LimpiarPresentacion()
        {
            txtPresentacionID.Clear();
            txtPresentacion.Clear();
            txtPrecio.Clear();
            txtCantidadP.Clear();
        }
        private void btnMostrarP_Click(object sender, EventArgs e)
        {
            ListarTodasLasPresentaciones();
        }

        private void dgvPresentaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPresentacionID.Text = dgvPresentaciones.Rows[e.RowIndex].Cells["PresentacionID"].Value.ToString();
                txtPresentacion.Text = dgvPresentaciones.Rows[e.RowIndex].Cells["Presentacion"].Value.ToString();
                txtPrecio.Text = dgvPresentaciones.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                txtCantidadP.Text = dgvPresentaciones.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            }
        }
    }
}
