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
            int color1 = int.Parse(txtColor1.Text);
            int color2 = int.Parse(txtColor2.Text);
            int color3 = int.Parse(txtColor3.Text);

            BackColor = Color.FromArgb(color1, color2, color3);
        }
    }
}
