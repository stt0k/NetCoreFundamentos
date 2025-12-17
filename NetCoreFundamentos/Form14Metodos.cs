using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN WRAPPER POR VALOR
        void GetDobleValor(int numero)
        {
            numero = numero * 2;
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Aqua;
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            GetDobleValor(num);
            lblResultado.Text = num.ToString();
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            CambiarColor(btnDobleReferencia);
            CambiarColor(btnDobleValor);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            GetDobleReferencia(ref num);
            lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true; 
            }
        }
    }
}
