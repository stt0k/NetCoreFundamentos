using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = txtElemento.Text;
            lstElementos.Items.Add(elem);
            txtElemento.Focus();
            txtElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int i in lstElementos.SelectedItems)
            {
                items += i + ",";
            }
            foreach (int i in lstElementos.SelectedIndices)
            {
                indices += i + ",";
            }
            lblIndex.Text = indices.Trim(',');
            lblItem.Text = items.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar en orden inverso para no alterar los índices
            int numSeleccionados = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numSeleccionados; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}
