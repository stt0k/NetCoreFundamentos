using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            botones = new List<Button>();
            panel1.Visible = false;
            txtSuma.Visible = false;
            Suma.Visible = false;

            foreach (Button btn in this.panel1.Controls)
            {
                botones.Add(btn);
                btn.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            int suma = int.Parse(txtSuma.Text);
            suma += numero;
            txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Suma.Visible = true;
            txtSuma.Visible = true;
            btnIniciarApp.Visible = false;
            Random random = new Random();
            foreach (Button boton in botones)
            {
                int aleat = random.Next(1, 100);
                boton.Text = aleat.ToString();
            }
        }
    }
}
