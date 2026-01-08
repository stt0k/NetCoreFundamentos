using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Contructor sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {
            Calle = calle;
            Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con dos parámetros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            Calle = calle;
            Ciudad = ciudad;
            CodigoPostal = cp;
            Debug.WriteLine("Constructor DIRECCION con tres parámetros");
        }
    }
}
