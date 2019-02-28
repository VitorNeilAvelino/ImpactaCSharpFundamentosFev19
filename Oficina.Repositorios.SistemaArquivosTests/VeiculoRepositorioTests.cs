using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new VeiculoPasseio();
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            //veiculo.Id = 1;
            veiculo.Modelo = new ModeloRepositorio().Selecionar(3);
            veiculo.Observacao = "Observação";
            veiculo.Placa = "abc1234";

            new VeiculoRepositorio().Inserir<VeiculoPasseio>(veiculo);

            Assert.AreEqual(veiculo.Placa, "ABC1234");

            //new VeiculoRepositorio().Inserir<int>(5);
        }
    }
}