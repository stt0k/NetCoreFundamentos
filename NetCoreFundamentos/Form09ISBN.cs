using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09ISBN : Form
    {
        public Form09ISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string textoIsbn = this.txtISBN.Text;
            int longitudTexto = textoIsbn.Length;

            if (longitudTexto != 10)
            {
                MessageBox.Show("El ISBN debe contener exactamente 10 dígitos.");
                return;
            }
            else
            {
                int resultado = 0;
                for (int i = 0; i < longitudTexto; i++)
                {
                    char caracter = textoIsbn[i];
                    int numero = int.Parse(caracter.ToString());

                    int op = numero * (i + 1);

                    resultado += op;
                }
                if (resultado % 11 == 0)
                {
                    lblResultado.Text = "El ISBN es correcto";
                }
                else
                {
                    lblResultado.Text = ("El ISBN introducido es incorrecto.");
                }
            }
        }
    }
}
