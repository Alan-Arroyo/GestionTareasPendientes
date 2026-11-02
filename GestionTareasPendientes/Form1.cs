using System;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
                txtTarea.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una tarea válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}