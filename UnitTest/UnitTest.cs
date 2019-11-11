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
            List<ResponseModel> atual = new List<ResponseModel>();
            List<ResponseModel> esperada = new List<ResponseModel>();

            var servico = new JurosService();
            var resultado = servico.CalcularJuros(1, 12);
            atual.Add(resultado);

            ResponseModel saida = ResponseModel.Factory.Create(true, "1,12", "");
            esperada.Add(saida);

            esperada.Should().BeEquivalentTo(atual);
        }
        [TestMethod]
        public void TestaMetodolcularValorInalido()
        {
            List<ResponseModel> atual = new List<ResponseModel>();
            List<ResponseModel> esperada = new List<ResponseModel>();

            var servico = new JurosService();
            var resultado = servico.CalcularJuros(0, 12);
            atual.Add(resultado);

            ResponseModel saida = ResponseModel.Factory.Create(false, "", "ValorInicial deve ser maior que zero.");
            esperada.Add(saida);

            esperada.Should().BeEquivalentTo(atual);
        }

        [TestMethod]
        public void TestaMetodolcularMesesInalido()
        {
            List<ResponseModel> atual = new List<ResponseModel>();
            List<ResponseModel> esperada = new List<ResponseModel>();

            var servico = new JurosService();
            var resultado = servico.CalcularJuros(1, 0);
            atual.Add(resultado);

            ResponseModel saida = ResponseModel.Factory.Create(false, "", "Meses deve ser maior que zero.");
            esperada.Add(saida);

            esperada.Should().BeEquivalentTo(atual);
        }




    }
}
