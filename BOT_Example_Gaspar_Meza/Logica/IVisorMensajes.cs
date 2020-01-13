using System;

namespace BOT_Example_Gaspar_Meza.Logica
{
    public interface IVisorMensajes
    {
        void MostrarMensaje(string Mensaje);
    }

    public class VisorMensajes : IVisorMensajes
    {
        public void MostrarMensaje(string Mensaje)
        {
            Console.WriteLine(Mensaje);
        }
    }
}