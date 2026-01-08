using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            SalarioMinimo += 200;
        }

        public override int getDiasVacaciones()
        {
            int vacasEmpleado = base.getDiasVacaciones();
            Debug.WriteLine("getVacaciones() DIRECTOR");
            return vacasEmpleado + 8;
        }
    }
}
