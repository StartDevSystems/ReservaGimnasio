using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservaGimnasio.Capa_de_Datos.Clases;
using ReservaGimnasio.Entidades;
using System.IO;

namespace ReservaGimnasio.Capa_Presentación
{
    public partial class Gestionar_Clases : Form
    {
        private ClaseDAL claseDAL;

        public Gestionar_Clases()
        {
            InitializeComponent();
            claseDAL = new ClaseDAL();
            CargarClases();
        }

        private void CargarClases()
        {
            // Cargar todas las clases en el DataGridView
            dataGridGestionClases.DataSource = claseDAL.MostrarTodasClases();
            // Ajustar columnas si es necesario
            dataGridGestionClases.AutoResizeColumns();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBuscarClase.Text.Trim();
            if (string.IsNullOrEmpty(nombreBusqueda))
            {
                CargarClases(); // Si no hay texto de búsqueda, cargar todas
                return;
            }

            // Realizar búsqueda por nombre
            dataGridGestionClases.DataSource = claseDAL.BuscarPorNombre(nombreBusqueda);
        }

        private void txtBuscarClase_TextChanged(object sender, EventArgs e)
        {
            // Opcional: puedes implementar búsqueda automática mientras se escribe
            // Si prefieres que la búsqueda sea solo con el botón, puedes dejar esto vacío
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscarClase.Clear();
            CargarClases();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridGestionClases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una clase para modificar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Obtener el ID de la clase seleccionada
                int idClase = Convert.ToInt32(dataGridGestionClases.SelectedRows[0].Cells["IdClase"].Value);

                // Obtener la fila seleccionada como DataRowView
                DataRowView filaSeleccionada = dataGridGestionClases.SelectedRows[0].DataBoundItem as DataRowView;

                if (filaSeleccionada != null)
                {
                    // Crear instancia del formulario AgregarClases en modo edición
                    AgregarClases formEditar = new AgregarClases();
                    formEditar.ModoEdicion = true;
                    formEditar.IdClaseAModificar = idClase;

                    // Cargar los datos de la clase seleccionada
                    formEditar.CargarDatosClase(filaSeleccionada);

                    // Mostrar el formulario como diálogo
                    if (formEditar.ShowDialog() == DialogResult.OK)
                    {
                        // Si se guardaron los cambios, actualizar la vista
                        CargarClases();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar modificar la clase: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un SaveFileDialog para elegir dónde guardar el archivo
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveDialog.Title = "Guardar como archivo de Excel";
                saveDialog.FileName = "Clases_Gimnasio.xlsx";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Aquí iría el código para exportar a Excel
                    // Puedes usar bibliotecas como EPPlus, ClosedXML o Microsoft.Office.Interop.Excel

                    // Por ahora, mostraremos un mensaje indicando que se implementaría la exportación
                    MessageBox.Show($"Se exportaría a: {saveDialog.FileName}\nFuncionalidad no implementada completamente",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridGestionClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento se dispara cuando se hace clic en una celda
            // Puedes usarlo para mostrar detalles adicionales o seleccionar la fila completa
        }
    }
}