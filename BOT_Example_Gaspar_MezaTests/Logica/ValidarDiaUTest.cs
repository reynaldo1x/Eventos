using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class ValidarDiaUTest
    {
        [TestMethod]
        public void ValidaDia_MismoDia_Verdadero()
        {
            var DOCValidarDia = new Mock<IValidarDia>();

            DOCValidarDia.Setup(DOC => DOC.ValidaDia(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarDia();
            var result = SUT.ValidaDia(new DateTime(2019, 12, 2), new DateTime(2019, 12, 02));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidaDia_DiferenteDia_Verdadero()
        {
            var DOCValidarDia = new Mock<IValidarDia>();

            DOCValidarDia.Setup(DOC => DOC.ValidaDia(new DateTime(2018, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarDia();
            var result = SUT.ValidaDia(new DateTime(2018, 10, 2), new DateTime(2019, 12, 01));

            Assert.IsFalse(result);
        }
    }
}
