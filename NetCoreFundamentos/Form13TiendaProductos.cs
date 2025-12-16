using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string elem = txtElemento.Text;
            if (lstTienda.Items.Contains(elem))
            {
                MessageBox.Show("No puedes tener productos repetidos");
            } else
            {
                lstTienda.Items.Add(elem);
                txtElemento.Focus();
                txtElemento.SelectAll();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar en orden inverso para no alterar los índices
            int numSeleccionados = lstTienda.SelectedIndices.Count - 1;
            for (int i = numSeleccionados; i >= 0; i--)
            {
                int index = lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            lstAlmacen.Items.AddRange(lstTienda.SelectedItems);
            int prodSeleccionados = lstTienda.SelectedIndices.Count - 1;
            for (int i = prodSeleccionados; i >= 0; i--)
            {
                int index = lstTienda.SelectedIndices[i];
                lstAlmacen.Items.Add(lstTienda.Items[index]);
                lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            lstAlmacen.Items.AddRange(lstTienda.Items);
            lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (lstAlmacen.SelectedIndex > 0)
            {
                int selectedIndex = lstAlmacen.SelectedIndex;
                string prodSelect = lstAlmacen.SelectedItems.ToString();
                lstAlmacen.Items.RemoveAt(selectedIndex);
                lstAlmacen.Items.Insert(selectedIndex - 1, prodSelect);
                lstAlmacen.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                btnSubir.Enabled = false;
                MessageBox.Show("No puedes subir mas");
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (lstAlmacen.SelectedIndex < lstAlmacen.Items.Count - 1 && lstAlmacen.SelectedIndex != -1)
            {
                int selectedIndex = lstAlmacen.SelectedIndex;
                string prodSelect = lstAlmacen.SelectedItems.ToString();
                lstAlmacen.Items.RemoveAt(selectedIndex);
                lstAlmacen.Items.Insert(selectedIndex + 1, prodSelect);
                lstAlmacen.SelectedIndex = selectedIndex + 1;
            }
            else
            {
                btnBajar.Enabled = false;
                MessageBox.Show("No puedes bajar mas");
            }
        }
    }
}
