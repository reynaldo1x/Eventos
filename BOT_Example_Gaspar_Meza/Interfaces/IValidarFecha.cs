using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Interfaces
{
    public interface IValidarFecha
    {
        string CalcularAnio(DateTime dtActual, DateTime dtUser);

        string CalcularMes(DateTime dtActual, DateTime dtUser);

        string CalcularDia(DateTime dtActual, DateTime dtUser);
    }
}
