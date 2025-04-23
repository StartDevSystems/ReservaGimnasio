using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ReservaGimnasio.Capa_de_Negocio;

namespace ReservaGimnasio.Capa_Presentación.Frm_Reservas
{
    public partial class Reservas_Client : Form
    {
        private readonly ClaseBL claseBL = new ClaseBL();

        public Reservas_Client()
        {
            InitializeComponent();
            pnlDetallesClase.Visible = false;
            btnConfirmarReserva.Enabled = false;
        }

        private void Reservas_Client_Load(object sender, EventArgs e)
        {
            CargarClasesDisponibles();
        }

        private void CargarClasesDisponibles()
        {
            DataTable dtClases = claseBL.MostrarTodasClases();
            dgvClasesDisponibles.DataSource = dtClases;

            // Opcional: Personalizar los nombres de las columnas (si tienes tiempo)
            if (dgvClasesDisponibles.Columns.Contains("Nombre")) dgvClasesDisponibles.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvClasesDisponibles.Columns.Contains("Entrenador")) dgvClasesDisponibles.Columns["Entrenador"].HeaderText = "Entrenador";
            if (dgvClasesDisponibles.Columns.Contains("FechaInicio")) dgvClasesDisponibles.Columns["FechaInicio"].HeaderText = "Inicio";
            if (dgvClasesDisponibles.Columns.Contains("FechaFin")) dgvClasesDisponibles.Columns["FechaFin"].HeaderText = "Fin";
            if (dgvClasesDisponibles.Columns.Contains("Duracion")) dgvClasesDisponibles.Columns["Duracion"].HeaderText = "Duración (min)";
            if (dgvClasesDisponibles.Columns.Contains("CapacidadMaxima")) dgvClasesDisponibles.Columns["CapacidadMaxima"].HeaderText = "Capacidad";
            if (dgvClasesDisponibles.Columns.Contains("Salon")) dgvClasesDisponibles.Columns["Salon"].HeaderText = "Salón";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Aquí iría la lógica para filtrar las clases
        }

        private void dgvClasesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí iría la lógica para mostrar los detalles al hacer clic
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            // Aquí iría la lógica para confirmar la reserva
        }

        private void dgvClasesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbEntrenador_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbTipoClase_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
        }

        private void pnlDetallesClase_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnConfirmarReserva_Click_1(object sender, EventArgs e)
        {
        }

        private void lblClaseNombre_Click(object sender, EventArgs e)
        {
        }

        private void lblHorario_Click(object sender, EventArgs e)
        {
        }

        private void lblEntrenador_Click(object sender, EventArgs e)
        {
        }

        private void lblSalon_Click(object sender, EventArgs e)
        {
        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {
        }

        private void lblDisponibilidad_Click(object sender, EventArgs e)
        {
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
        }
    }
}