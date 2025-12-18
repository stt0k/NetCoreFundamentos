using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Control> cajas;
        List<TextBox> textbox;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            cajas = new List<Control>();
            textbox = new List<TextBox>();

            //cargar resultado de cada boton en cada textbox
            foreach (Control num in this.textbox)
            {
                
            }
        }

    }
}
