using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                int listaNumeros = random.Next(1, 100);
                lstNumeros.Items.Add(listaNumeros);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaTotalPares = 0;
            int sumaTotalImpares = 0;
            foreach (int num in lstNumeros.Items)
            {
                sumaTotal += num;

                if ( num % 2 == 0)
                {
                    sumaTotalPares += num;
                } else
                {
                    sumaTotalImpares += num;
                }
            }
            txtSuma.Text = sumaTotal.ToString();
            txtSumaImpares.Text = sumaTotalImpares.ToString();
            txtSumaPares.Text = sumaTotalPares.ToString();
        }
    }
}
