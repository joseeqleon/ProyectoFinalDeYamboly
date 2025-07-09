using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class FormVentaProducto : Form
    {
        public FormVentaProducto()
        {
            InitializeComponent();
        }
        private void FormVentaProducto_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            dtpFechaVenta.Value = DateTime.Today;
            ListarVentas();
        }
        private void CargarPedidos()
        {
            cmbPedido.DataSource = logPedido.Instancia.ListarPedidos();
            cmbPedido.DisplayMember = "PedidoID";
            cmbPedido.ValueMember = "PedidoID";
        }
        private void ListarVentas()
        {
            dgvVentas.DataSource = logVenta.Instancia.ListarVentas();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPedido.SelectedItem is entPedido pedido)
            {
                string nombreEmpresa = logEmpresa.Instancia.ListarEmpresa()
                    .FirstOrDefault(emp => emp.EmpresaID == pedido.EmpresaID)?.Nombre ?? "Desconocido";

                string nombreProducto = logProducto.Instancia.ListarProducto()
                    .FirstOrDefault(p => p.ProductoID == pedido.ProductoID)?.Producto ?? "Desconocido";

                string nombrePresentacion = logPresentacion.Instancia
                    .ListarPresentaciones(pedido.ProductoID)
                    .FirstOrDefault(pr => pr.PresentacionID == pedido.PresentacionID)?.Presentacion ?? "Desconocido";

                lblEmpresa.Text = nombreEmpresa;
                lblProducto.Text = nombreProducto;
                lblPresentacion.Text = nombrePresentacion;
                lblCantidad.Text = pedido.Cantidad.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblPresentacion_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            int pedidoID = Convert.ToInt32(cmbPedido.SelectedValue);

            // ✅ Verifica si ya se pagó el pedido antes de registrar la venta
            bool tienePago = logComprobantePago.Instancia.ExistePagoParaPedido(pedidoID);
            if (!tienePago)
            {
                MessageBox.Show("No se puede registrar la venta. El pedido no ha sido pagado aún.");
                return;
            }

            // ✅ Registrar la venta si hay pago
            entVenta venta = new entVenta
            {
                PedidoID = pedidoID,
                FechaVenta = DateTime.Today
            };

            bool registrado = logVenta.Instancia.RegistrarVenta(venta);
            if (registrado)
            {
                MessageBox.Show("Venta registrada correctamente.");
                ListarVentas();
            }
            else
            {
                MessageBox.Show("Error al registrar la venta.");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdVenta.Text) || !int.TryParse(txtIdVenta.Text, out int ventaID))
            {
                MessageBox.Show("Ingrese un ID de venta válido.");
                return;
            }

            try
            {
                logVenta.Instancia.AnularVenta(ventaID);
                MessageBox.Show("Venta anulada correctamente.");
                txtIdVenta.Clear();
                ListarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular la venta: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
