using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class ValidarMes : IValidarMes
    {
        public bool ValidaMes(DateTime dtFecha1, DateTime dtFecha2)
        {
            if (dtFecha1.Date.Month == dtFecha2.Date.Month)
                return true;

            return false;
        }
    }
}
