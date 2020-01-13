using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class CalcularTiempo : ICalcularTiempo
    {
        /*
        private readonly ICalcularAnio _CalcularAnio;
        private readonly IValidarMes _ValidarMes;
        private readonly IValidarSemana _ValidarSemana;
        private readonly IValidarDia _ValidarDia;
        private readonly IValidarHora _ValidarHora;

        public CalcularTiempo(ICalcularAnio CalcularAnio, IValidarMes ValidarMes, IValidarSemana ValidarSemana, IValidarDia ValidarDia, IValidarHora ValidarHora)
        {
            this._CalcularAnio = CalcularAnio;
            this._ValidarMes = ValidarMes;
            this._ValidarSemana = ValidarSemana;
            this._ValidarDia = ValidarDia;
            this._ValidarHora = ValidarHora;
        }
        */

        public string CalcularMomentoDelTiempo(DateTime dtFecha1, DateTime dtFecha2)
        {
            CalcularAnio calcularAnio = new CalcularAnio(new ValidarAnio());
            CalcularMes calcularMes = new CalcularMes(new ValidarMes());
            CalcularDia calcularDia = new CalcularDia(new ValidarDia());
            string cAnio, cMes, cDia = string.Empty;

            cAnio = calcularAnio.CalculaAnio(dtFecha1, dtFecha2);
            cMes = calcularMes.CalculaMes(dtFecha1, dtFecha2);
            cDia = calcularDia.CalculaDia(dtFecha1, dtFecha2);

            return cAnio + " " + " " + cMes + " " + cDia;
        }
      
    }
}
