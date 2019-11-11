using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApi.Models;
using WebApi.Services;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestaMetodolcularJurosValido()
        {


            var servico = new JurosService();
            var resultado = servico.CalcularJuros(1, 12);
            atual.Add(resultado);

            ResponseModel saida =  ResponseModel.Factory.Create(true, "1,12", "");
            esperada.Add(saida);
            
            esperada.Should().BeEquivalentTo(atual);
        }


    }
}
