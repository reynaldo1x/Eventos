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
        private static readonly IEvento _Evento = new Evento(new ValidarConexion(), new ValidarFecha(), new LeerArchivoTexto());
        public static DateTime dtActual, dtUser;

        static void Main(string[] args)
        {
            //Program p = new Program(new Evento());
            dtActual = DateTime.Now.Date;
            //_Evento.MostrarInformacion();
            Mostrar();
            Console.ReadLine();
        }

        public static void Mostrar()
        {
            _Evento.MostrarInformacion();
        }      
    }


}
