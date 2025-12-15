using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                char caracter = (char) i;

                if (char.IsLetter(caracter) == true)
                {
                    txtLetras.Text += caracter;
                } else if (char.IsNumber(caracter) == true)
                {
                    txtNumeros.Text += caracter;
                } else if (char.IsSymbol(caracter) == true)
                {
                    txtSimbolos.Text += caracter;
                } else if (char.IsPunctuation(caracter) == true)
                {
                    txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
