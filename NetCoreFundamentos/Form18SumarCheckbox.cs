using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            checkboxes = new List<CheckBox>();
            panel1.Visible = false;
            textBox1.Visible = false;
            label1.Visible = false;

            foreach (CheckBox chk in this.panel1.Controls)
            {
                checkboxes.Add(chk);
                chk.CheckedChanged += SumarNumeros;
            } 
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox checkPulsado = (CheckBox)sender;
            int numero = int.Parse(checkPulsado.Text);
            int suma = int.Parse(textBox1.Text);

            if (checkPulsado.Checked)
            {
                suma += numero;
            } else
            {
                suma -= numero;
            }

            textBox1.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            btnIniciarApp.Visible = false;
            Random random = new Random();
            foreach (CheckBox checkbox in checkboxes)
            {
                int aleat = random.Next(1, 100);
                checkbox.Text = aleat.ToString();
            }
        }
    }
}
