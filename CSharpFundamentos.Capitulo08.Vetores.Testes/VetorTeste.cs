using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.Capitulo08.Vetores.Testes
{
    [TestClass]
    public class VetorTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];
            inteiros[0] = 34;
            inteiros[1] = 21;
            inteiros[4] = 42;

            decimal[] decimais = new decimal[] { 8, 3.7m, 2.9m, 7.89m };

            decimal[] outroDecimais = { 2.1m, 2.36m, 10 };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            for (int i = 0; i < decimais.Length; i++)
            {
                Console.WriteLine(decimais[i]);
            }
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 0.8m};

            Array.Resize(ref decimais, 5);

            decimais[3] = 1.59m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 15.63m, 0.5m, 1, 0.8m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.5m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 15.63m, 0.5m, 1, 0.8m };

            Console.WriteLine(Media(decimais));
        }

        private decimal Media(decimal valor1, decimal valor2)
        {
            return (valor1 + valor2) / 2;
        }

        private decimal Media(decimal[] valores)
        {
            var soma = 0m;

            foreach (var @decimal in valores)
            {
                soma += @decimal;
            }

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    soma += valores[i];
            //}

            return soma / valores.Length;
        }
    }
}
