using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza.Interfaces
{
    public class ILeerArchivoCSV
    {
        public interface LeerArchivoCSV
        {
            string[] ObtenerDatos(string path);
        }
    }
}
