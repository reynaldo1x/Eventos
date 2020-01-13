using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class ValidarAnio : IValidarAnio
    {
        public bool ValidaAnio(DateTime dtFecha1, DateTime dtFecha2)
        {
            if (dtFecha1.Date.Year == dtFecha2.Date.Year)
                return true;

            return false;
        }
    }
}
