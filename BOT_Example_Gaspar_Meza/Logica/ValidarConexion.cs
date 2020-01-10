using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class ValidarConexion : IValidarConexion
    {
        public void Validar(string path)
        {
            try
            {
                System.IO.File.Exists(path);
            }
            catch (Exception)
            {
                Console.WriteLine("Ruta inválida");
                Console.ReadLine();
                return;
            }
        }
    }
}
