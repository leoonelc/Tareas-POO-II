using System;
using System.Windows.Forms;

namespace Gestion_De_Tareas_Pendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Gestión de Tareas Pendientes";
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text.Trim());
                txtTarea.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, escribe una tarea.");
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            if (lstTareas.Items.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas limpiar toda la lista?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    lstTareas.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("La lista ya está vacía.");
            }
        }
    }
}
