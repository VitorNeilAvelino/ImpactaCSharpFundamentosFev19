using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentos.Capitulo09.Colecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>(100);
            inteiros.Add(128);
            inteiros.Add(1);
            inteiros.Add(2);
            inteiros.Add(-96);
            inteiros.Add(0);
            inteiros.Add(3);

            List<int> maisInteiros = new List<int>() { 2, 3, 5, 90 };
            maisInteiros[0] = -56;
            //maisInteiros[4] = 100;
            maisInteiros.Add(100);

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, -2);

            inteiros.Remove(2);
            inteiros.RemoveAt(0);
            inteiros.RemoveAll(elemento => elemento == 2); // expressão lambda.

            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count - 1];
            ultimo = inteiros.Last();
            primeiro = inteiros.First();

            for (int i = 0; i < inteiros.Count; i++)
            {
                Console.WriteLine($"{i}: {inteiros[i]}");
            }

            Console.WriteLine("------------------------------");

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");
            }
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019, 12, 25), "Natal");
            feriados.Add(Convert.ToDateTime("01/01/2020"), "Ano Novo");
            feriados.Add(Convert.ToDateTime("25/01/2020"), "Aniversário de São Paulo");

            //feriados.Add(new DateTime(2019, 12, 25), "Natal 2");

            var natal = feriados[new DateTime(2019, 12, 25)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}: {feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2019, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("Natal"));
        }

        [TestMethod]
        public void StackTeste()
        {
            var pilha = new Stack<int>();
            pilha.Push(2);
            pilha.Push(5);
            pilha.Push(1);

            Assert.AreEqual(pilha.Pop(), 1);
            Assert.AreEqual(pilha.Peek(), 5);

            Console.WriteLine($"A pilha está vazia? {pilha.Count == 0}");
            //Console.WriteLine($"A pilha está vazia? {pilha.Peek() == null}");
        }

        [TestMethod]
        public void QueueTeste()
        {
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(6);
            fila.Enqueue(0);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(), 6);
            Assert.AreEqual(fila.Peek(), 0);
        }
    }
}
