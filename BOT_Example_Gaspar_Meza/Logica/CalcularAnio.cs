using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class CalcularAnio
    {
        private readonly IValidarAnio _ValidarAnio;

        public CalcularAnio(IValidarAnio ValidarAnio)
        {
            _ValidarAnio = ValidarAnio;
        }

        public string CalculaAnio(DateTime dtFecha1, DateTime dtFecha2)
        {
            bool lSameTime = false;
            int iTime = 0;

            lSameTime = _ValidarAnio.ValidaAnio(dtFecha1, dtFecha2);

            if(!lSameTime)
            {
                iTime = dtFecha1.Date.Year - dtFecha2.Date.Year;
                if (iTime > 0)
                    return "ocurrió hace " + (iTime == 1 ? iTime + " año." : iTime + " años.");
                else
                {
                    if (iTime == 0)
                        return "ocurre este año";
                    else
                        return "ocurrirá en " + (iTime == 1 ? iTime + " año." : iTime + " años.");
                }
            }

            return "";
        }
    }
}
