using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class CalcularMesUTest
    {
        [TestMethod]
        public void CalculaMes_MismoDia_MensajeCorrecto()
        {
            var DOCCalculaMes = new Mock<IValidarMes>();

            DOCCalculaMes.Setup(DOC => DOC.ValidaMes(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01))).Returns(true);
            var SUT = new CalcularMes(DOCCalculaMes.Object);

            var result = SUT.CalculaMes(new DateTime(2019, 12, 2), new DateTime(2018, 12, 01));

            Assert.AreEqual("ocurre este mes", result);
        }
    }
}
