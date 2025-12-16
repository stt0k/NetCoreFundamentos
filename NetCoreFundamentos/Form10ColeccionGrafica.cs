using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = txtElemento.Text;
            lstElementos.Items.Add(elem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexSeleccionado = lstElementos.SelectedIndex;
            lstElementos.Items.RemoveAt(indexSeleccionado);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstElementos.SelectedIndex != -1)
            {
                lblIndex.Text = lstElementos.SelectedIndex.ToString();
                lblItem.Text = lstElementos.SelectedItem.ToString();
            }
            
        }
    }
}
