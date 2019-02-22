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
    public class MarcaRepositorioTests
    {
        private MarcaRepositorio repositorio = new MarcaRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            var marcas = repositorio.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id}:{marca.Nome}");
            }
        }

        [TestMethod()]
        public void SelecionarPorIdTeste()
        {
            var marca = repositorio.Selecionar(1);
            Assert.AreEqual(marca.Id, 1);
            Assert.IsTrue(marca.Nome == "VW");
            marca = repositorio.Selecionar(5);
            Assert.IsNull(marca);
        }
    }
}