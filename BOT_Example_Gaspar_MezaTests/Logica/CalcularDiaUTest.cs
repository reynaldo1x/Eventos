using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class CalcularDiaUTest
    {
        [TestMethod]
        public void CalculaDia_MismoDia_MensajeCorrecto()
        {
            var DOCCalculaDia = new Mock<IValidarDia>();

            DOCCalculaDia.Setup(DOC => DOC.ValidaDia(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01))).Returns(true);
            var SUT = new CalcularDia(DOCCalculaDia.Object);

            var result = SUT.CalculaDia(new DateTime(2019, 12, 2), new DateTime(2018, 12, 01));

            Assert.AreEqual("ocurrió hace 1 día.", result);
        }
    }
}
