using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProyectoClases
{
    public interface IFactura
    {
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }

        void calcularIva();

        void metodoPrueba(int prueba);
    }
}
