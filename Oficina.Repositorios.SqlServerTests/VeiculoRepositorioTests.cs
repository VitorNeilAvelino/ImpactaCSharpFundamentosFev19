using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Placa = "ABC1234";
            veiculo.Ano = 2015;
            veiculo.Cor = new Cor { Nome = "Azul" };
            veiculo.Modelo = new Modelo { Nome = "Fiesta" };

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}