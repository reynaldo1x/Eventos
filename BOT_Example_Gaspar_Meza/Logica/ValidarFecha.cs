using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class ValidarFecha : IValidarFecha
    {
        public DateTime dtActual;
        public DateTime dtAnio;

        public string CalcularAnio(DateTime dtActual, DateTime dtUser)
        {
            if (dtActual.Date.Year == dtUser.Date.Year)
                return string.Empty;

            if (dtActual.Date.Year < dtUser.Date.Year)
                return "ocurrio años atras";

            if (dtActual.Date.Year > dtUser.Date.Year)
                return "aún no ha ocurrido";

            return string.Empty;
        }

        public string CalcularMes(DateTime dtActual, DateTime dtUser)
        {
            if (dtActual.Date.Month == dtUser.Date.Month)
                return string.Empty;

            if (dtActual.Date.Month < dtUser.Date.Month)
                return "ocurrio meses atras";

            if (dtActual.Date.Month > dtUser.Date.Month)
                return "aún no ha ocurrido";

            return string.Empty;
        }

        public string CalcularDia(DateTime dtActual, DateTime dtUser)
        {
            if (dtActual.Date.Day == dtUser.Date.Day)
                return "es hoy";

            if (dtActual.Date.Day < dtUser.Date.Day)
                return "ocurrio días atras";

            if (dtActual.Date.Day > dtUser.Date.Day)
                return "aún no ha ocurrido";

            return string.Empty;
        }
    }
}
