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
    /// Summary description for ValidarAnioUTest
    /// </summary>
    [TestClass]
    public class ValidarAnioUTest
    {

        [TestMethod]
        public void ValidaAnio_MismoAnio_Verdadero()
        {
            var DOCValidarAnio = new Mock<IValidarAnio>();

            DOCValidarAnio.Setup(DOC => DOC.ValidaAnio(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarAnio();
            var result = SUT.ValidaAnio(new DateTime(2019, 12, 2), new DateTime(2019, 12, 01));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidaAnio_DiferenteAnio_Verdadero()
        {
            var DOCValidarAnio = new Mock<IValidarAnio>();

            DOCValidarAnio.Setup(DOC => DOC.ValidaAnio(new DateTime(2018, 12, 2), new DateTime(2019, 12, 01))).Returns(true);

            var SUT = new ValidarAnio();
            var result = SUT.ValidaAnio(new DateTime(2018, 12, 2), new DateTime(2019, 12, 01));

            Assert.IsFalse(result);
        }
    }
}
