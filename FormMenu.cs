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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnRPedido_Click(object sender, EventArgs e)
        {
            FormDatosPedido rpedido = new FormDatosPedido();
            rpedido.Show();
        }

        private void btnRPago_Click(object sender, EventArgs e)
        {
            FormPago rpago = new FormPago();
            rpago.Show();
        }

        private void btnRVenta_Click(object sender, EventArgs e)
        {
            FormVentaProducto rventa = new FormVentaProducto();
            rventa.Show();
        }

        private void btnMProducto_Click(object sender, EventArgs e)
        {
            MantenedorProducto mproducto = new MantenedorProducto();
            mproducto.Show();
        }

        private void btnMEmpresa_Click(object sender, EventArgs e)
        {
            MantenedorEmpresa mempresa = new MantenedorEmpresa();
            mempresa.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
