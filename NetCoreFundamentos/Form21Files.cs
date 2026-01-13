using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            helper = new HelperFiles();
            Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            lstNombres.Items.Add(txtNombre.Text);
            txtNombre.SelectAll();
            txtNombre.Focus();
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = getNombresListBox();
            await helper.WriteFileAsync(Path, content);
            MessageBox.Show("Datos almacenados");
        }

        public string getNombresListBox()
        {
            string data = "";
            foreach (string name in lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            string content = await helper.ReadFileAsync(Path);
            txtContenidoFile.Text = content;
        }
    }
}
