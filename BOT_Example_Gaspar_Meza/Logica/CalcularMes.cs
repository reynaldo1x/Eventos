using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class CalcularMes
    {
        private readonly IValidarMes _ValidarMes;

        public CalcularMes(IValidarMes ValidarMes)
        {
            _ValidarMes = ValidarMes;
        }

        public string CalculaMes(DateTime dtFecha1, DateTime dtFecha2)
        {
            bool lSameTime = false;
            int iTime = 0;

            lSameTime = _ValidarMes.ValidaMes(dtFecha1, dtFecha2);

            if (!lSameTime)
            {
                iTime = dtFecha1.Date.Month - dtFecha2.Date.Month;
                if (iTime > 0)
                    return "ocurrió hace " + (iTime == 1 ? iTime + " mes." : iTime + " meses.");
                else
                { 
                    if (iTime == 0)
                        return "ocurre este mes";
                    else
                        return "ocurrirá en " + (iTime == 1 ? iTime + " mes." : iTime + " meses.");
                }
            }

            return "";
        }
    }
}
