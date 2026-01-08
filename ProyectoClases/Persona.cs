using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    #region ENUMERACIONES
    public enum TipoGenero { Masculino = 0, Femenino = 1 }
    public enum Paises { España, Francia, Alemania, Andorra, Colombia}
    #endregion
    public class Persona
    {
        #region CONSTRUCTORES

        public Persona()
        {
            Debug.WriteLine("Contructor PERSONA vacio");
        }

        public Persona (string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parametros");
        }
        #endregion

        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return _DescripcionThis; }
            set
            {
                Random random = new Random();
                int dato = random.Next(1, 20);
                _DescripcionThis = "Descripción " + dato;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return _Genero; }
            set
            {
                if (value != TipoGenero.Femenino &&
                    value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas");
                }
                else
                {
                    _Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        private int _Edad;
        public int Edad
        {
            get { return _Edad; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }

        #endregion

        #region METODOS

        public string getNombreCompleto()
        {
            return Nombre + " " + Apellidos;
        }

        public string getNombreCompleto(bool orden)
        {
            return Apellidos + " " + Nombre;
        }

        public string getNombreCompleto(int num1)
        {
            return (Nombre + " " + Apellidos).ToUpper();
        }

        public string getNombreCompleto( int num1, int num2)
        {
            return getNombreCompleto().ToLower();
        }

        public void getNombreCompleto(string dato)
        {

        }
        #endregion
    }
}
