using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Interfaces
{
    public interface IValidarAnio
    {
        bool ValidaAnio(DateTime dtActual, DateTime dtUser);
    }
}
