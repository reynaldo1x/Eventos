using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class CalcularAnioUTest
    {
        [TestMethod]
        public void CalculaAnio_DiferenteAnio_MensajeCorrecto()
        {
            var DOCCalculaAnio = new Mock<IValidarAnio>();

            DOCCalculaAnio.Setup(DOC => DOC.ValidaAnio(new DateTime(2019, 12, 2), new DateTime(2018, 12, 01))).Returns(true);
            var SUT = new CalcularAnio(DOCCalculaAnio.Object);

            var result = SUT.CalculaAnio(new DateTime(2019, 12, 2), new DateTime(2018, 12, 01));

            //DOCCalculaAnio.Verify(DOC => DOC.ValidaAnio(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01)), Times.Once);
            Assert.AreEqual("ocurrió hace 1 año.", result);
        }
    }
}
