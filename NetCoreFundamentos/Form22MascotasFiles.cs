using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFiles : Form
    {
        HelperMascotas helper;
        public Form22MascotasFiles()
        {
            InitializeComponent();
            helper = new HelperMascotas();
        }

        // Metodo para dibujar en la lista las mascotas
        private void dibujarMascotas()
        {
            lstMascotas.Items.Clear();
            foreach (Mascota mascota in helper.Mascotas)
            {
                lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            helper.Mascotas.Add(mascota);
            dibujarMascotas();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            await helper.readMascotasAsync();
            dibujarMascotas();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            await helper.writeMascotasAsync();
            lstMascotas.Items.Clear();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = helper.Mascotas[index];
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
            }
        }
    }
}
