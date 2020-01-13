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
        private readonly ILeerArchivoTexto _LeerArchivo;
        private readonly IVisorMensajes _VisorMensaje;
        //private static readonly ICalcularTiempo _Evento = new CalcularTiempo(new CalcularAnio(), new ValidarMes(), new ValidarSemana());
        private readonly ICalcularTiempo _Calcular;

        public Func<DateTime> dtActual { get; set; }
        //public Evento(IValidarConexion ValidarConexion, IValidarFecha ValidarFecha, ILeerArchivoTexto LeerArchivoTexto, IVisorMensajes VisorMensaje, ICalcularTiempo CalcularTiempo)
        //{
        //    _ValidarConexion = ValidarConexion;
        //    _ValidarFecha = ValidarFecha;
        //    _LeerArchivo = LeerArchivoTexto;
        //    this._VisorMensaje = VisorMensaje;
        //    this._CalcularTiempo = CalcularTiempo;
        //    dtActual = () => DateTime.Now;
        //}

        public Evento(IValidarConexion ValidarConexion, ILeerArchivoTexto LeerArchivoTexto, IVisorMensajes VisorMensaje, ICalcularTiempo calcular)
        {
            _ValidarConexion = ValidarConexion;
            _LeerArchivo = LeerArchivoTexto;
            this._VisorMensaje = VisorMensaje;
            dtActual = () => DateTime.Now;
            _Calcular = calcular; 
        }

        public void MostrarInformacion(string path)
        {
            //Valida existe la conexión          
            _ValidarConexion.Validar(path);

            //Obtiene los datos
            string[] cLineas = _LeerArchivo.ObtenerDatos(path);

            ObtenerEvento(cLineas);
        }

        private void ObtenerEvento(string[] cLineas)
        {

            string cMensaje = string.Empty;
            string c1, c2;
            DateTime dtUser;
            foreach (string line in cLineas)
            {
                c1 = ValidaCadena(line, 0);
                c2 = ValidaCadena(line, 1);
                cMensaje = string.Empty;

                if (string.IsNullOrEmpty(c2))
                    continue;

                dtUser = Convert.ToDateTime(c2);

                cMensaje = _Calcular.CalcularMomentoDelTiempo(dtActual(), dtUser);
                if (!string.IsNullOrEmpty(cMensaje))
                    _VisorMensaje.MostrarMensaje(string.Format("El evento {0} {1}", c1, cMensaje));

            }
        }
        
        private string ValidaCadena(string cCadena, int pos)
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
