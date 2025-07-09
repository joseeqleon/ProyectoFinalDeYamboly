using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoYambolyFinal
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPedidoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPedidoID.SelectedItem is entPedido pedido)
            {
                txtEmpresa.Text = pedido.EmpresaNombre;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dtpFechaEntrega.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy.");
                return;
            }

            entComprobantePago comp = new entComprobantePago
            {
                PedidoID = Convert.ToInt32(cmbPedidoID.SelectedValue),
                MetodoPagoID = Convert.ToInt32(cmbMetodoPago.SelectedValue),
                FechaEntrega = dtpFechaEntrega.Value.Date
            };

            bool ok = logComprobantePago.Instancia.RegistrarComprobante(comp);
            MessageBox.Show(ok ? "Registrado correctamente" : "Error al registrar");
        }
        private void FormPago_Load(object sender, EventArgs e)
        {
            // Cargar combo de pedidos
            cmbPedidoID.DataSource = logPedido.Instancia.ListarPedidos();
            cmbPedidoID.DisplayMember = "PedidoID";
            cmbPedidoID.ValueMember = "PedidoID";

            // Cargar combo de métodos de pago
            cmbMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
            cmbMetodoPago.DisplayMember = "Nombre";
            cmbMetodoPago.ValueMember = "MetodoPagoID";

            // Mostrar empresa relacionada al pedido
            cmbPedidoID.SelectedIndexChanged += (s, ev) =>
            {
                if (cmbPedidoID.SelectedValue is int pedidoID)
                {
                    var pedido = logPedido.Instancia.ListarPedidos().FirstOrDefault(p => p.PedidoID == pedidoID);
                    if (pedido != null)
                    {
                        var empresa = logEmpresa.Instancia.ListarEmpresa().FirstOrDefault(emp => emp.EmpresaID == pedido.EmpresaID);
                        txtEmpresa.Text = empresa?.Nombre ?? "";
                    }
                }
            };
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvComprobantes.DataSource = logComprobantePago.Instancia.ListarComprobantes();
        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
