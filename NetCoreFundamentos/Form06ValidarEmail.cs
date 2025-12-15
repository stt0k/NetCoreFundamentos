using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("El email debe tener al menos un @");
                return;
            }

            if (email.StartsWith('@') || email.EndsWith('@'))
            {
                MessageBox.Show("El email no puede empezar ni acabar con un @");
                return;
            }

            if (email.Count(c => c == '@') != 1)
            {
                MessageBox.Show("El email solo puede tener un @");
                return;
            }
            if (!email.Contains("."))
            {
                MessageBox.Show("El email debe tener un punto");
                return;
            }
            if (email.LastIndexOf(".") == -1)
            {
                MessageBox.Show("El email debe de tener un punto despues de la @");
                return;
            }
            string[] emailParte = email.Split(".");

            if (emailParte[2].Count(l => l == 0) != 2 && emailParte[2].Count(l => l == 0) != 3)
            {
                MessageBox.Show("El domino del email debe de tener de 2 a 3 caracteres");
                return;
            }
        }
    }
}
