using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class ValidarDia : IValidarDia
    {
        public bool ValidaDia(DateTime dtFecha1, DateTime dtFecha2)
        {
            if (dtFecha1.Date.Day == dtFecha2.Date.Day)
                return true;

            return false;
        }
    }
}
