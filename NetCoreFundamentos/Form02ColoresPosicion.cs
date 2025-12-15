using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posicion1 = int.Parse(txtPosicionX.Text);
            int posicion2 = int.Parse(txtPosicionY.Text);

            btnPosicion.Location = new Point(posicion1, posicion2);

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtColor1.Text);
            int verde = int.Parse(txtColor2.Text);
            int azul = int.Parse(txtColor3.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor rojo tiene que estar entre 0 y 255");
            } else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor verde tiene que estar entre 0 y 255");
            } else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor azul tiene que estar entre 0 y 255");
            } else
            {
                BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
