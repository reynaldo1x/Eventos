using System;
using BOT_Example_Gaspar_Meza.Interfaces;
using BOT_Example_Gaspar_Meza.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BOT_Example_Gaspar_MezaTests.Logica
{
    [TestClass]
    public class ValidarMesUTest
    {
        [TestMethod]
        public void ValidaMes_MismoMes_Verdadero()
        {
            var DOCValidarMes = new Mock<IValidarMes>();

            DOCValidarMes.Setup(DOC => DOC.ValidaMes(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarMes();
            var result = SUT.ValidaMes(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidaMes_DiferenteMes_Verdadero()
        {
            var DOCValidarMes = new Mock<IValidarMes>();

            DOCValidarMes.Setup(DOC => DOC.ValidaMes(new DateTime(2018, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarMes();
            var result = SUT.ValidaMes(new DateTime(2018, 10, 2), new DateTime(2019, 12, 01));

            Assert.IsFalse(result);
        }
    }
}
