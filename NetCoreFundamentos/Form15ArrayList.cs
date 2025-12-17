using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            // COLECCION GENERICA
            List<Control> botones = new List<Control>();
            // DETECTA AUTOMATICAMENTE LOS ELEMENTOS
            botones.Add(button1);
            botones.Add(button2);
            botones.Add(button3);
            botones.Add(textBox1);
            botones[0].BackColor = Color.White;

            ArrayList coleccion = new ArrayList();
            coleccion.Add(button1);
            coleccion.Add(button2);
            coleccion.Add(button3);
            // SI DESEAMOS ACCEDER A UN OBJETO Y MODIFICAR ALGUNA CARACTERISTICA
            // NECESITAMOS REALIZAR CASTING
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            // PODEMOS REALIZAR EL CASTING CON FOREACH
            foreach ( Button boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
            }

            // Y SI AGREGAMOS OTRO CONTROL QUE NO SEA UN BOTON????
            coleccion.Add(textBox1);
            // HAY QUE PONER EL CONTROL PARA EL CASTING EN TODOS LOS OBJETOS (COMODIN)
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightSalmon;
                if (boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            button1.Click += MetodoDelegado;
        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
