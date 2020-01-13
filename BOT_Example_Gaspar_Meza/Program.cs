using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza
{
    class Program 
    {
        private static readonly IEvento _Evento = new Evento(new ValidarConexion(), new LeerArchivoTexto(), new VisorMensajes(), new CalcularTiempo());
        public static DateTime dtActual;
        public static string path = string.Empty;

        static void Main(string[] args)
        {
            path = Path.Combine(Environment.CurrentDirectory, "example.txt");
            dtActual = DateTime.Now.Date;
            Mostrar();
            Console.ReadLine();
        }

        public static void Mostrar()
        {
            _Evento.MostrarInformacion(path);
        }      
    }


}
