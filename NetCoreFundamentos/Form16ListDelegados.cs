using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        List<Button> botones;
        public Form16ListDelegados()
        {
            InitializeComponent();
            int contador = 0;
            botones = new List<Button>();

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
            }

            foreach (Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            textBox1.Text = contador.ToString();
            Button miboton = (Button)sender;
            miboton.BackColor = Color.Yellow;
        }
    }
}
