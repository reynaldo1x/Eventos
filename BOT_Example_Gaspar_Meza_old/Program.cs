using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT_Example_Gaspar_Meza
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "example.txt");
            string[] lines = null;
            string print = string.Empty, c1 = string.Empty, c2 = string.Empty;
            string[] cCadena = new string[2];
            DateTime time, tNow = DateTime.Now;

            try
            {
                lines = System.IO.File.ReadAllLines(ruta);
            }
            catch (Exception)
            {
                Console.WriteLine("Ruta invalida");
                Console.ReadLine();
                return;
            }
            
           
            foreach (string line in lines)
            {
                print = string.Empty;
                c1 = line.Split(',')[0];
                c2 = line.Split(',')[1];
                   
                if (!string.IsNullOrEmpty(c1))
                    print = "Evento " + c1;

                if (!string.IsNullOrEmpty(c2))
                {
                    try
                    {
                        time = Convert.ToDateTime(c2);

                        if (time == tNow.Date)
                            c2 = "Ocurrio ahora";

                        if (time.Month == tNow.Date.Month)
                        {
                            if (time < tNow.Date)
                                c2 = "Ocurrio hace dias";
                            if (time == tNow.Date)
                                c2 = "Ocurrio hoy";
                            if (time > tNow.Date)
                                c2 = "Aún no ocurre";
                        }
                        else
                        {
                            if (time.Month < tNow.Date.Month)
                            {
                                c2 = "Ocurrio hace meses";
                            }
                            else
                            {
                                if (time.Month - tNow.Date.Month == 1)
                                    c2 = " ocurre en un mes";

                                if (time.Month - tNow.Date.Month > 1)
                                    c2 = " ocurre en " + (time.Month - tNow.Date.Month).ToString() + " meses";                                  
                            }
                        }                           
                    }
                    catch (Exception)
                    {
                        c2 = ".. sin fecha";
                    }                  
                }
                else
                {
                    c2 = ".. sin fecha";
                }

                print += " " + c2;
                Console.WriteLine("\t" + print);
                    
            }
            Console.ReadLine();
        }
    }
}
