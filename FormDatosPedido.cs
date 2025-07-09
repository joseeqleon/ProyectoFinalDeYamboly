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
    public partial class FormDatosPedido : Form
    {
        public FormDatosPedido()
        {
            InitializeComponent();
        }
        private void FormDatosPedido_Load(object sender, EventArgs e)
        {
            CargarCombos();
            dtpFechaPedido.Value = DateTime.Today;
            dtpFiltroFecha.Value = DateTime.Today;
            ListarPedidosPorFecha(dtpFiltroFecha.Value);
        }
        private void CargarCombos()
        {
            cmbEmpresa.DataSource = logEmpresa.Instancia.ListarEmpresa();
            cmbEmpresa.DisplayMember = "Nombre";
            cmbEmpresa.ValueMember = "EmpresaID";

            cmbProducto.DataSource = logProducto.Instancia.ListarProducto();
            cmbProducto.DisplayMember = "Producto";
            cmbProducto.ValueMember = "ProductoID";

            ActualizarComboPresentaciones();
        }
        private void txtPedidoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            entPedido p = new entPedido
            {
                EmpresaID = Convert.ToInt32(cmbEmpresa.SelectedValue),
                ProductoID = Convert.ToInt32(cmbProducto.SelectedValue),
                PresentacionID = Convert.ToInt32(cmbPresentacion.SelectedValue),
                Cantidad = cantidad,
                FechaPedido = dtpFechaPedido.Value
            };

            bool registrado = logPedido.Instancia.RegistrarPedido(p);
            if (registrado)
            {
                MessageBox.Show("Pedido registrado correctamente.", "Éxito");
                ListarPedidosPorFecha(dtpFiltroFecha.Value);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el pedido.", "Error");
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pedido para anular.");
                return;
            }

            int id = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["PedidoID"].Value);
            logPedido.Instancia.AnularPedido(id);
            MessageBox.Show("Pedido anulado correctamente.", "Anulado");
            ListarPedidosPorFecha(dtpFiltroFecha.Value);
        }
        private void ListarTodosLosPedidos()
        {
            dgvPedidos.DataSource = logPedido.Instancia.ListarPedidos();
        }
        private void ActualizarComboPresentaciones()
        {
            if (cmbProducto.SelectedValue != null && cmbProducto.SelectedValue is int productoID)
            {
                cmbPresentacion.DataSource = logPresentacion.Instancia.ListarPresentaciones(productoID);
                cmbPresentacion.DisplayMember = "Presentacion";
                cmbPresentacion.ValueMember = "PresentacionID";
            }
        }
        private void LimpiarFormulario()
        {
            txtCantidad.Clear();
            cmbEmpresa.SelectedIndex = 0;
            cmbProducto.SelectedIndex = 0;
            if (cmbPresentacion.Items.Count > 0)
                cmbPresentacion.SelectedIndex = 0;
        }
        private void ListarPedidosPorFecha(DateTime fecha)
        {
            dgvPedidos.DataSource = logPedido.Instancia.ListarPedidosPorFecha(fecha);
        }
        private void dtpFechaPedido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ListarPedidosPorFecha(dtpFiltroFecha.Value);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListarTodosLosPedidos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFiltroFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormDatosPedido_Load_1(object sender, EventArgs e)
        {

        }
    }
}
