using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            CargarCombos();
            pnlDetallesClase.Visible = false;
            btnConfirmarReserva.Enabled = false;
        }

        private void CargarCombos()
        {
            var listaDias = new List<string>(new[] { "Lunes, Martes, Miercoles, Jueves, Viernes" }).ToArray();
            var listadoEntrenadores = new List<string>(new[] { "Rocky Balboa", "El Depredador", "Jose Luis", "Castor Troy", "John Clements", "Jonathan travolta", "Yordi el NiñoP" }).ToArray();
            var listadoArea = new List<string>( new[] { "CrossFit", "HIIT (High-Intensity Interval Training", "Circuitos, Pesas libres", "Máquinas de musculación", "Powerlifting", "Spinning", "Step aeróbico", "Caminadora", "Elípticas" }).ToArray();

            cmbDia.Items.AddRange(listaDias);
            cmbEntrenador.Items.AddRange(listadoEntrenadores);
            cmbTipoClase.Items.AddRange(listadoArea);
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

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            // Aquí iría la lógica para filtrar las clases
            //NECESITO los dias,el entrenador y el tipo
           var itemDia = cmbDia.Text;
           var itemEntrenador= cmbEntrenador.Text;
           var itemSalon= cmbTipoClase.Text;
            if (string.IsNullOrWhiteSpace(itemDia) || string.IsNullOrWhiteSpace(itemEntrenador) || string.IsNullOrWhiteSpace(itemSalon))
            {
                MessageBox.Show("Todos los campos son requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var data = claseBL.AccionarFiltroDia_Entrenador_Salon(itemDia, itemEntrenador,itemSalon);
            dgvClasesDisponibles.DataSource = data;
        }
        //SELECIONAMOS LA CLASE luego cargamos lo datos de la clase y confirmamos la reservacion con esos datos
        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {

        }

        private void dgvClasesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClasesDisponibles.Rows[e.RowIndex];
          

                 
            }


        }
    }
}