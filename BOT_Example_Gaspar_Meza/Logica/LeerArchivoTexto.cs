using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class LeerArchivoTexto : ILeerArchivoTexto
    {
        public string[] ObtenerDatos(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            return lines;
        }
    }
}
