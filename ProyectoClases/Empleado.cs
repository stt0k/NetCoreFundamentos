using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {

        public virtual int getDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Contructor EMPLEADO vacio");
            SalarioMinimo = 1600;
        }

        public int getSalarioMinimo()
        {
            return SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos, int edad) : base(nombre, apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Debug.WriteLine("Constructor EMPLEADO con tres parametros");
        }
    }
}
