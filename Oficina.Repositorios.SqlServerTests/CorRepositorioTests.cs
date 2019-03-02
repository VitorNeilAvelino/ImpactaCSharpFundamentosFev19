using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oficina.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        private CorRepositorio repositorio = new CorRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            Assert.IsTrue(repositorio.Selecionar().Count != 0);
        }

        [TestMethod()]
        public void SelecionarPorIdTest()
        {
            Assert.IsTrue(repositorio.Selecionar(1).Nome == "Amarelo");
        }
    }
}