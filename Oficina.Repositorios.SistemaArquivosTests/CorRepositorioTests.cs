using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private CorRepositorio repositorio = new CorRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            var cores = repositorio.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor.Id} - {cor.Nome}");
            }
        }

        [TestMethod()]
        public void SelecionarPorIdTeste()
        {
            var cor = repositorio.Selecionar(1);

            Assert.AreEqual(cor.Id, 1);
            Assert.IsTrue(cor.Nome == "Preto");

            cor = repositorio.Selecionar(5);

            Assert.IsNull(cor);
        }
    }
}