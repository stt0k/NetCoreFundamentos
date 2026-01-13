using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form24ColeccionMascotasXML : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotaslist;
        public Form24ColeccionMascotasXML()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(ColeccionMascotas));
            mascotaslist = new ColeccionMascotas();
        }

        private void dibujarMascotas()
        {
            lstMascotas.Items.Clear();
            foreach (Mascota mascota in mascotaslist)
            {
                lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascotaslist.Add(mascota);
            dibujarMascotas();
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();
        }

        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                serializer.Serialize(writer, mascotaslist);
                await writer.FlushAsync();
                writer.Close();
                lstMascotas.Items.Clear();
                mascotaslist.Clear();
            }
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                mascotaslist = (ColeccionMascotas)serializer.Deserialize(reader);
                reader.Close();
                dibujarMascotas();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = mascotaslist[index];
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
                txtEdad.Text = mascota.Edad.ToString();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Abrir el openfile para seleccionar la imagen
            openFileDialog1.ShowDialog();
            // Recuperamos la ruta de la imagen
            string path = openFileDialog1.FileName;
            // Dibujamos la imagne en el form
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
