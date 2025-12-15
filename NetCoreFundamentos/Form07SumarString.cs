using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoNumeros = txtNumeros.Text;

            int suma = 0;
            for ( int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];

                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }

            lblResultado.Text = "La suma es " + suma;
        }
    }
}
