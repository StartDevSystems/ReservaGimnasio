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
//pnlDetallesClase.Visible = false;
            btnConfirmarReserva.Enabled = false;
        }

        private void CargarCombos()
        {
            var listaDias = new List<string>(new[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" }).ToArray();
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


// Make sure this is inside your Reservas_Client class

private void dgvClasesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Check if the click is on a valid row (not the header)
        if (e.RowIndex >= 0)
        {
            // Check if the click occurred in the 'btnReservar' column
            // It's safer to check by column name than index, in case the order changes.
            if (this.dgvClasesDisponibles.Columns[e.ColumnIndex].Name == "btnReservar")
            {
                // Get the clicked row
                DataGridViewRow fila = dgvClasesDisponibles.Rows[e.RowIndex];

                // --- Action to perform when the 'Reservar' button is clicked ---

                // 1. Get the necessary information from the row.
                //    Make sure to handle potential null values and convert types correctly.
                //    Using 'ClaseID' which is likely the primary key for the class.
                int claseId = -1; // Default/invalid value

                // Safely try to parse the ClaseID
                if (fila.Cells["ClaseID"].Value != null &&
                    int.TryParse(fila.Cells["ClaseID"].Value.ToString(), out int parsedId))
                {
                    claseId = parsedId;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID de la clase seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop processing if ID is invalid
                }

                // You can also get other details if needed for confirmation or processing
                string nombreClase = fila.Cells["NombreClase"].Value?.ToString() ?? "N/A";
                string horario = fila.Cells["Horario"].Value?.ToString() ?? "N/A";
                string entrenador = fila.Cells["Entrenador"].Value?.ToString() ?? "N/A";
                // Add any other fields you might need...

                // 2. Implement the reservation logic (or start the process)
                //    For example, show a confirmation message:
                DialogResult confirmResult = MessageBox.Show(
                    $"¿Está seguro que desea reservar la clase '{nombreClase}' con {entrenador} a las {horario}?",
                    "Confirmar Reserva",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // --- PLACEHOLDER: Add your actual reservation code here ---
                    // This is where you would call a method to save the reservation
                    // to your database or business logic layer, passing the claseId
                    // and potentially the client's ID (which you might have stored elsewhere).
                    // Example:
                    // bool exito = GestorReservas.CrearReserva(this.clienteActualId, claseId);
                    // if(exito) {
                    //     MessageBox.Show("¡Clase reservada con éxito!", "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //     // Optional: Refresh the grid to show updated availability
                    //     CargarClasesDisponibles(); // Assuming you have a method like this
                    // } else {
                    //     MessageBox.Show("No se pudo completar la reserva. Intente nuevamente.", "Error de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // }

                    // For now, just show a message indicating the action would happen
                    MessageBox.Show($"Acción: Reservar clase con ID: {claseId}\nNombre: {nombreClase}", "Reserva Iniciada (Simulación)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Potentially update UI, e.g., refresh the grid or disable the button
                }
                // else: User clicked No, do nothing.
            }
            // Optional: Handle clicks on other cells if needed (e.g., selecting the row)
            // else
            // {
            //     // Code to execute if a cell other than the button is clicked
            //     // For example, maybe just ensure the row is selected
            //     if (!dgvClasesDisponibles.Rows[e.RowIndex].Selected)
            //     {
            //        dgvClasesDisponibles.ClearSelection(); // Optional: clear previous selection
            //        dgvClasesDisponibles.Rows[e.RowIndex].Selected = true;
            //     }
            // }
        }
    }

    // --- Make sure you have declared the event handler in your Form's constructor ---
    // or in the InitializeComponent method (which your designer file already does):
    // this.dgvClasesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasesDisponibles_CellContentClick);

    private void btnConfirmarReserva_Click_1(object sender, EventArgs e)
        {

        }
    }
}