using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        // Necesistamos dos metodos: Leer y escribir
        // Estos metodos deben ser asincronos
        // Se utiliza en los metodos de clase no grafica la clase TASK para metodos asincronos en vez de VOID
        // Resumen:
        // 1) Si es un void, se utiliza Task
        // 2) Si es un return, utilizamos Task<ClaseReturn>

        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);

            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
    }
}
