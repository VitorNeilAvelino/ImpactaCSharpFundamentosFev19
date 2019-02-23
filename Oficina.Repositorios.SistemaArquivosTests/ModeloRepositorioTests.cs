using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        private ModeloRepositorio repositorio = new ModeloRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            foreach (var modelo in repositorio.SelecionarPorMarca(1))
            {
                Console.WriteLine($"{modelo.Id}: {modelo.Nome} ({modelo.Marca.Nome})");
            }
        }

        [TestMethod()]
        public void SelecionarPorIdTeste()
        {
            var modelo = repositorio.Selecionar(1);

            Assert.IsTrue(modelo.Id == 1);
            Assert.IsTrue(modelo.Nome == "Fusca");
            Assert.IsTrue(modelo.Marca.Nome == "VW");

            modelo = repositorio.Selecionar(6);

            Assert.IsTrue(modelo == null);
            Assert.IsNull(modelo);
        }
    }
}