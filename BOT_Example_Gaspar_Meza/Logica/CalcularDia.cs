using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class CalcularDia
    {
        private readonly IValidarDia _ValidarDia;

        public CalcularDia(IValidarDia ValidarDia)
        {
            _ValidarDia = ValidarDia;
        }

        public string CalculaDia(DateTime dtFecha1, DateTime dtFecha2)
        {
            bool lSameTime = false;
            int iTime = 0;

            lSameTime = _ValidarDia.ValidaDia(dtFecha1, dtFecha2);

            if (!lSameTime)
            {
                iTime = dtFecha1.Date.Day - dtFecha2.Date.Day;
                if (iTime > 0)
                    return "ocurrió hace " + (iTime == 1 ? iTime + " día." : iTime + " días.");
                else
                    return "ocurrirá en " + (iTime == 1 ? iTime + " día." : iTime + " días.");
            }

            return "";
        }
    }
}
