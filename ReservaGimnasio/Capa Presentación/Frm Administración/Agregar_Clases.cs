using ReservaGimnasio.Capa_de_Datos.Clases;
using ReservaGimnasio.Capa_de_Negocio;
using ReservaGimnasio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaGimnasio.Capa_Presentación
{
    public partial class AgregarClases : Form
    {
        // Propiedades para el modo edición
        public bool ModoEdicion { get; set; } = false;
        public int IdClaseAModificar { get; set; } = 0;
        private ClaseBL claseBL = new ClaseBL();

        public AgregarClases()
        {
            InitializeComponent();
            CargarComboxes();
        }

        private void AgregarClases_Load(object sender, EventArgs e)
        {
            // Cambiar el título del formulario según el modo
            if (ModoEdicion)
            {
                this.Text = "Modificar Clase";
                btnGuardar.Text = "Actualizar";
            }
        }

        private void CargarComboxes()
        {
            var listadoEntrenadores = new List<String>(new[] { "Rocky Balboa", "El Depredador", "Jose Luis", "Castor Troy", "John Clements", "Jonathan travolta", "Yordi el NiñoP" });
            var listadoArea = new List<String>(new[] { "CrossFit", "HIIT (High-Intensity Interval Training", "Circuitos, Pesas libres", "Máquinas de musculación", "Powerlifting", "Spinning", "Step aeróbico", "Caminadora", "Elípticas" });
            cmbEntrenadores.Items.AddRange(listadoEntrenadores.ToArray());
            cmbSalon.Items.AddRange(listadoArea.ToArray());
        }

        // Método para cargar los datos de una clase existente
        public void CargarDatosClase(DataRowView fila)
        {
            if (fila != null)
            {
                txtNombreClase.Text = fila["Nombre"].ToString();

                // Seleccionar el entrenador en el combobox
                string entrenador = fila["Entrenador"].ToString();
                for (int i = 0; i < cmbEntrenadores.Items.Count; i++)
                {
                    if (cmbEntrenadores.Items[i].ToString() == entrenador)
                    {
                        cmbEntrenadores.SelectedIndex = i;
                        break;
                    }
                }

                // Establecer capacidad máxima
                nudCapacidad.Value = Convert.ToDecimal(fila["CapacidadMaxima"]);

                // Establecer duración
                nudDuracion.Value = Convert.ToDecimal(fila["Duracion"]);

                // Seleccionar el salón en el combobox
                string salon = fila["Salon"].ToString();
                for (int i = 0; i < cmbSalon.Items.Count; i++)
                {
                    if (cmbSalon.Items[i].ToString() == salon)
                    {
                        cmbSalon.SelectedIndex = i;
                        break;
                    }
                }

                // Establecer fechas
                dtpFechaInicio.Value = Convert.ToDateTime(fila["FechaInicio"]);
                dtpFechaFinal.Value = Convert.ToDateTime(fila["FechaFin"]);

                // Marcar los días seleccionados
                string diasString = fila["Dias"].ToString();
                string[] dias = diasString.Split(',');

                chkLunes.Checked = dias.Contains("Lunes");
                chkMartes.Checked = dias.Contains("Martes");
                chkMiercoles.Checked = dias.Contains("Miércoles");
                chkJueves.Checked = dias.Contains("Jueves");
                chkViernes.Checked = dias.Contains("Viernes");
                chkSabado.Checked = dias.Contains("Sábados");

                // Establecer recurrencia
                string recurrencia = fila["Recurrencia"].ToString();
                if (recurrencia == "Única")
                    rdbUnica.Checked = true;
                else if (recurrencia == "Diaria")
                    rdbDiaria.Checked = true;
                else if (recurrencia == "Semanal")
                    rdbSemanal.Checked = true;
            }
        }

        private void LimpiarFormulario()
        {
            // Limpiar los controles después de guardar
            txtNombreClase.Clear();
            cmbEntrenadores.SelectedIndex = -1;
            nudCapacidad.Value = 0;
            nudDuracion.Value = 0;
            cmbSalon.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFinal.Value = DateTime.Today;
            chkLunes.Checked = false;
            chkMartes.Checked = false;
            chkMiercoles.Checked = false;
            chkJueves.Checked = false;
            chkViernes.Checked = false;
            chkSabado.Checked = false;
            rdbUnica.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya ingresado un nombre de clase
                if (string.IsNullOrEmpty(txtNombreClase.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar un nombre para la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreClase.Focus();
                    return;
                }

                // Validar que se haya seleccionado un entrenador
                if (cmbEntrenadores.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un entrenador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbEntrenadores.Focus();
                    return;
                }

                // Validar que se haya seleccionado un salón/área
                if (cmbSalon.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un salón o área.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSalon.Focus();
                    return;
                }

                // Crear la lista de días seleccionados
                List<string> diasSeleccionados = new List<string>();
                if (chkLunes.Checked) diasSeleccionados.Add("Lunes");
                if (chkMartes.Checked) diasSeleccionados.Add("Martes");
                if (chkMiercoles.Checked) diasSeleccionados.Add("Miércoles");
                if (chkJueves.Checked) diasSeleccionados.Add("Jueves");
                if (chkViernes.Checked) diasSeleccionados.Add("Viernes");
                if (chkSabado.Checked) diasSeleccionados.Add("Sábados");

                // Validar que se haya seleccionado al menos un día (si no es una clase única)
                if (!rdbUnica.Checked && diasSeleccionados.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un día de la semana para clases recurrentes.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determinar la recurrencia
                string recurrencia = "Única";
                if (rdbDiaria.Checked) recurrencia = "Diaria";
                else if (rdbSemanal.Checked) recurrencia = "Semanal";

                // Crear el objeto ClaseEnti con los datos del formulario
                ClaseEnti clase = new ClaseEnti
                {
                    Nombre = txtNombreClase.Text.Trim(),
                    Entrenador = cmbEntrenadores.SelectedItem.ToString(),
                    CapacidadMaxima = Convert.ToInt32(nudCapacidad.Value),
                    Duracion = Convert.ToInt32(nudDuracion.Value),
                    Salon = cmbSalon.SelectedItem.ToString(),
                    FechaInicio = dtpFechaInicio.Value.Date,
                    FechaFin = dtpFechaFinal.Value.Date,
                    Dias = diasSeleccionados,
                    Recurrencia = recurrencia
                };
                Console.WriteLine(clase.Entrenador.ToString());
                bool resultado = false;

                if (ModoEdicion)
                {
                    // Modificar clase existente
                    resultado = claseBL.ModificarClase(IdClaseAModificar, clase);

                    if (resultado)
                    {
                        MessageBox.Show("¡La clase se ha actualizado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la clase.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Guardar nueva clase
                    resultado = claseBL.GuardarClase(clase);

                    if (resultado)
                    {
                        MessageBox.Show("¡La clase se ha guardado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la clase.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}