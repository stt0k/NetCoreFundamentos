using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = txtNombre.Text;
            mascota.Raza = txtRaza.Text;
            mascota.Edad = int.Parse(txtEdad.Text);
            mascota.Imagen = CopyImageToByteArray(Image.FromFile(openFileDialog1.FileName));
            

            // Las clases que se utilizan son de tipo stream, para escribir necesitamos la clase StreamWriter

            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            txtNombre.Text = "";
            txtRaza.Text = "";
            txtEdad.Text = "";
            pictureBox1.Image = null;
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)serializer.Deserialize(reader);
                reader.Close();
                txtNombre.Text = mascota.Nombre;
                txtRaza.Text = mascota.Raza;
                txtEdad.Text = mascota.Edad.ToString();
                pictureBox1.Image = Image.FromStream(new MemoryStream(mascota.Imagen));
            }
        }

        public static byte[] CopyImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
