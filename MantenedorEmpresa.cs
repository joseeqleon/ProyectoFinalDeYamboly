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
    public partial class MantenedorEmpresa : Form
    {
        public MantenedorEmpresa()
        {
            InitializeComponent();
            Listar();
        }
        private void Listar()
        {
            dgvEmpresas.DataSource = logEmpresa.Instancia.ListarEmpresa();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbUbigeo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarUbigeo()
        {
            cmbUbigeo.DataSource = logUbigeo.Instancia.ListarUbigeo();
            cmbUbigeo.DisplayMember = "ToString";    // Departamento / Provincia / Distrito
            cmbUbigeo.ValueMember = "UbigeoID";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string ruc = txtRUC.Text.Trim();
            entUbigeo ubigeoSeleccionado = cmbUbigeo.SelectedItem as entUbigeo;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(ruc) || ubigeoSeleccionado == null)
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            // Verificar si el RUC ya existe (como antes)
            if (logEmpresa.Instancia.ExisteRUC(ruc))
            {
                MessageBox.Show("Este RUC ya está registrado.");
                return;
            }

            var emp = new entEmpresa
            {
                Nombre = nombre,
                RUC = ruc,
                Ubigeo = ubigeoSeleccionado,
                Estado = true
            };

            logEmpresa.Instancia.InsertarEmpresa(emp);
            MessageBox.Show("Empresa registrada correctamente.");
            Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Seleccione una empresa válida.");
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string ruc = txtRUC.Text.Trim();
            entUbigeo ubigeoSeleccionado = cmbUbigeo.SelectedItem as entUbigeo;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(ruc) || ubigeoSeleccionado == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            var emp = new entEmpresa
            {
                EmpresaID = id,
                Nombre = nombre,
                RUC = ruc,
                Ubigeo = ubigeoSeleccionado,
                Estado = true
            };

            logEmpresa.Instancia.EditarEmpresa(emp);
            MessageBox.Show("Empresa modificada correctamente.");
            Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idSeleccionado = Convert.ToInt32(txtID.Text);
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta empresa?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool eliminado = logEmpresa.Instancia.EliminarEmpresa(idSeleccionado);
                if (eliminado)
                {
                    MessageBox.Show("Empresa eliminada correctamente.");
                    Listar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la empresa.");
                }
            }
        }
        private void MantenedorEmpresa_Load(object sender, EventArgs e)
        {
            CargarUbigeo();  // ✅ Cargar combo de Ubigeo
            Listar();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MantenedorEmpresa_Load_1(object sender, EventArgs e)
        {

        }
    }
}
