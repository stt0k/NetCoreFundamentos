using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anyo = int.Parse(txtAnyo.Text);
            string[] semana = { "Sabado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };


            if (mes == 1)
            {
                mes = 13;
                anyo--;
            }
            if (mes == 2)
            {
                mes = 14;
                anyo--;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);

            lblResultado.Text = semana[op7];
        }
    }
}
