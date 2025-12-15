using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(txtFecha.Text);

            if (chkFormato.Checked == true)
            {
                txtFecha.Text = fecha.ToLongDateString();
            } else
            {
                txtFecha.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncremento_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(txtIncremento.Text);
            DateTime fecha = DateTime.Parse(txtFecha.Text);

            if (rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            } else if (rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            } else if (rdbAnyos.Checked == true)
            {
                fecha = fecha.AddYears(incremento);
            }
             txtFechaFinal.Text = fecha.ToString();
        }
    }
}
