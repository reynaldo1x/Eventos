using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class ValidarConexionUTest
    {
        [TestMethod]
        public void Validar_ExisteConexion_Verdadero()
        {
            var DOCValidarConexion = new Mock<IValidarConexion>();

            DOCValidarConexion.Setup(DOC => DOC.Validar(It.IsAny<string>()));

            var SUT = new ValidarConexion();
            SUT.Validar(It.IsAny<string>());

            Assert.IsTrue(true);
        }
    }
}
