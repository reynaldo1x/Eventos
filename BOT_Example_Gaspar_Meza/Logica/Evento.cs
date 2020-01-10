using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class Evento : IEvento
    {
        private readonly IValidarConexion _ValidarConexion;
        private readonly IValidarFecha _ValidarFecha;
        private readonly ILeerArchivoTexto _LeerArchivo;
        public static DateTime dtActual, dtUser;

        public Evento(ValidarConexion ValidarConexion, ValidarFecha ValidarFecha, LeerArchivoTexto LeerArchivoTexto)
        {
            _ValidarConexion = ValidarConexion;
            _ValidarFecha = ValidarFecha;
            _LeerArchivo = LeerArchivoTexto;
        }

        public void MostrarInformacion()
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "example.txt");

            //Valida existe la conexión          
            _ValidarConexion.Validar(ruta);

            //Obtiene los datos
            string[] cLineas = _LeerArchivo.ObtenerDatos(ruta);

            ObtenerEvento(cLineas);
        }

        public void ObtenerEvento(string[] cLineas)
        {
            string cMensaje = string.Empty;
            string c1, c2;

            foreach (string line in cLineas)
            {
                c1 = ValidaCadena(line, 0);
                c2 = ValidaCadena(line, 1);
                cMensaje = string.Empty;

                if (string.IsNullOrEmpty(c2))
                    continue;

                dtUser = Convert.ToDateTime(c2);

                cMensaje = _ValidarFecha.CalcularAnio(dtActual, dtUser);
                if (!string.IsNullOrEmpty(cMensaje))
                    Console.WriteLine(string.Format("El evento {0} {1}", c1, cMensaje));

                cMensaje = _ValidarFecha.CalcularMes(dtActual, dtUser);
                if (!string.IsNullOrEmpty(cMensaje))
                    Console.WriteLine(string.Format("El evento {0} {1}", c1, cMensaje));

                cMensaje = _ValidarFecha.CalcularDia(dtActual, dtUser);
                if (!string.IsNullOrEmpty(cMensaje))
                    Console.WriteLine(string.Format("El evento {0} {1}", c1, cMensaje));
            }
        }

        public string ValidaCadena(string cCadena, int pos)
        {
            string cInfo = string.Empty;

            try
            {
                cInfo = cCadena.Split(',')[pos];
            }
            catch (Exception)
            {
                cInfo = string.Empty;
            }

            return cInfo;
        }
    }
}
