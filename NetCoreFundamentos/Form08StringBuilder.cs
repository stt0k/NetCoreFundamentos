using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            krono.Start();

            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO Stopwatch COTNIENE UA SERIE DE PROPIEDADES 
            // PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: "
            + krono.Elapsed.Seconds
            + ", Milisegundos: "
            + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE STRINGBUILDER
            StringBuilder cadena = new StringBuilder();
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;
            krono.Start();

            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO Stopwatch COTNIENE UA SERIE DE PROPIEDADES 
            // PARA COMPROBAR EL TIEMPO ENTRE EL PROCESO
            this.lblTiempo.Text = "Segundos: "
            + krono.Elapsed.Seconds
            + ", Milisegundos: "
            + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
