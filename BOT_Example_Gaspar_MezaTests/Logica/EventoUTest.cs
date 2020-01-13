using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BOT_Example_Gaspar_Meza.Interfaces;
using Moq;
using BOT_Example_Gaspar_Meza.Logica;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    /// <summary>
    /// Summary description for EventoUTest
    /// </summary>
    [TestClass]
    public class EventoUTest
    {

        [TestMethod]
        public void ObtenerEvento_DiaPasado_MensajeCorrecto()
        {
            //Arrange
            var DOCValidarConexion = new Mock<IValidarConexion>();
            var DOCCalcularTiemppo = new Mock<ICalcularTiempo>();
            var DOCLeerArchivo = new Mock<ILeerArchivoTexto>();
            var DOCVisorMensajes = new Mock<IVisorMensajes>();
         
            DOCLeerArchivo.Setup(DOC => DOC.ObtenerDatos(It.IsAny<string>())).Returns(new string[] { "Ayer, 2019/12/01"});
            DOCCalcularTiemppo.Setup(DOC => DOC.CalcularMomentoDelTiempo(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01) )).Returns("Ayer");
            //DOCValidarFecha.Setup(DOC=>DOC.CalcularDia(new DateTime(2019,12,2), new DateTime(2019,12,01))).Returns("Ayer");
            DOCVisorMensajes.Setup(DOC => DOC.MostrarMensaje($"El evento Ayer Ayer"));
            
            var SUT = new Evento(DOCValidarConexion.Object, DOCLeerArchivo.Object, DOCVisorMensajes.Object, DOCCalcularTiemppo.Object);
            SUT.dtActual = () => new DateTime(2019, 12, 2);

            //Act
            SUT.MostrarInformacion("example.txt");

            //Assert
            DOCVisorMensajes.Verify(DOC => DOC.MostrarMensaje($"El evento Ayer Ayer"), Times.Once);
           

        }
    }
}
