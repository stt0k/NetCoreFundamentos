using System;
using System.Collections.Generic;
using System.Text;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            Mascotas = new List<Mascota>();
            helper = new HelperFiles();
            path = "mascotas.txt";
        }

        // Convertir el string del read a list
        private void convertirMascotasList(string data)
        {
            // Garfield,gato@Pluto,perro
            Mascotas.Clear();
            // Separamos cada mascota con el @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                // Separamos las propiedades
                string[] propiedades = stringMascota.Split(',');
                // Convertimos el string en objetos
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                Mascotas.Add(mascota);
            }
        }

        public async Task readMascotasAsync()
        {
            // Leemos el fichero de mascotas
            string data = await helper.ReadFileAsync(path);
            // Convertimos el string en list
            convertirMascotasList(data);
        }

        // Convertir coleccion a string
        private string convertirMascotasString()
        {
            // Garfield,gato@Pluto,perro
            string data = "";
            foreach (Mascota mascota in Mascotas)
            {
                // Separamos las propiedades mediante ,
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                // Separamos cada objeto string de mascota
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        public async Task writeMascotasAsync()
        {
            // Convertimos la coleccion a string
            string data = convertirMascotasString();
            // Escribimos los datos en file
            await helper.WriteFileAsync(path, data);
        }
    }
}
