﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;

namespace CSharpFundamentos.Capitulo12.ValorReferencia.Teste
{
    [TestClass]
    public class ValorReferenciaTeste
    {
        [TestMethod]
        public void PassagemPorValorTeste()
        {
            var x = 1;

            Transformar(x);

            Assert.AreEqual(x, 1);
        }

        [TestMethod]
        public void PassagemPorReferenciaTeste()
        {
            var veiculo = new VeiculoPasseio();
            veiculo.Placa = "ads4598";

            Transformar(veiculo);

            Assert.AreEqual(veiculo.Placa, "ABC1234");
        }

        [TestMethod]
        public void PassagemPorValorUsandoRefTeste()
        {
            var x = 1;
            var data = DateTime.Now;

            TransformarRef(ref x);

            Assert.IsTrue(x == 2);
        }

        [TestMethod]
        public void EstruturaTeste()
        {
            var cliente = new Cliente();

            cliente.Id = 1;

            Transformar(cliente);

            Assert.IsTrue(cliente.Id == 1);
        }

        private void Transformar(Cliente cliente)
        {
            cliente.Id = 2;
        }

        private struct Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        private void TransformarRef(ref int x)
        {
            ++x;
        }

        private void Transformar(VeiculoPasseio veiculo)
        {
            veiculo.Placa = "abc1234";
        }

        private void Transformar(int valor)
        {
            //valor = valor + 1;
            //valor += 1;
            ++valor;
        }
    }
}