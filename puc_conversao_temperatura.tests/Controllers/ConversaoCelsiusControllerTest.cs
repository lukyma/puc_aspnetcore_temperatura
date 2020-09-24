using Microsoft.VisualStudio.TestTools.UnitTesting;
using puc_conversao_temperatura.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace puc_conversao_temperatura.tests.Controllers
{
    [TestClass]
    public class ConversaoCelsiusControllerTest
    {
        [TestMethod]
        public void ConverterCelsiusToKelvin_Sucesso()
        {
            Temperatura temperatura = new Temperatura()
            {
                Valor = 30
            };

            Assert.AreEqual(303.15m, temperatura.ConvertCelsiusToKelvin());
        }
    }
}
