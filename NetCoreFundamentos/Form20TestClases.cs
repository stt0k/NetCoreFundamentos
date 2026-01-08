using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Reyes";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Masculino;
            persona.Nacionalidad = Paises.Andorra;

            lstClases.Items.Add("Nombre: " + persona.Nombre
                + ", Apellidos: " + persona.Apellidos
                + ", Edad: " + persona.Edad
                + ", Genero: " + persona.Genero);

            lstClases.Items.Add(persona.getNombreCompleto(true));

            persona.Domicilio.Calle = "Avenida Enero";
            persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28003;

            lstClases.Items.Add("Direccion: "
                + persona.Domicilio.Calle + ", "
                + persona.Domicilio.Ciudad + ", "
                + persona.Domicilio.CodigoPostal);

            persona[0] = "prueba 1";
            persona[1] = "prueba 2";
            persona[2] = "prueba 3";
            persona[3] = "prueba 4";


        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            // Empleado emp = new Empleado("Nombre", "Apellido");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            lstClases.Items.Add("Vacas Empleado: " + emp.getDiasVacaciones());
            lstClases.Items.Add("Empleado: " + emp.getNombreCompleto());
            lstClases.Items.Add("Salario: " + emp.getSalarioMinimo());

            Director director = new Director();
            director.Nombre = "Dire";
            director.Apellidos = "Dire";
            lstClases.Items.Add("Vacas Director: " + director.getDiasVacaciones());
            lstClases.Items.Add("Director: " + director.getNombreCompleto());
            lstClases.Items.Add("Salario: " + director.getSalarioMinimo());
        }
    }
}
