using BOT_Example_Gaspar_Meza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public class Calculo : ICalculo
    {
        public ICalcularTiempo _ICalculo { get; set; }

        //public Calculo(ICalcularTiempo _CalcularTiempo)
        //{
        //    _ICalculo = _CalcularTiempo;
        //}

        public string CalcularTiempo(DateTime dtFecha1, DateTime dtFecha2)
        {
            return _ICalculo.CalcularMomentoDelTiempo(dtFecha1, dtFecha2);
        }
    }
}
