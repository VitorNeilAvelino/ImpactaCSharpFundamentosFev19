using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            //a = 10;
            int b = 6, c = 10, d = 13;

            //if (b == 8)
            //{

            //}

            int A = 42;

            //a = "10";
            //decimal a = 10; // C# é uma linguagem de tipos estáticos
            string nome = "Vítor";
            decimal bimestre1 = 7.1M;
            var aprovado = true;

            string @class = "3a B";

            DateTime dataNascimento = new DateTime(1970, 12, 25); //"25/12/1970";
            var dataEmbarque = Convert.ToDateTime("14/02/2019");

            var x = 0;

            object meuObjeto = new object();
            meuObjeto = "saddfasdf";
            meuObjeto = 1;
            meuObjeto = true;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            resultadoListBox.Items.Add(string.Format("c = {0}", c));
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"d / a = {d / a}");
            resultadoListBox.Items.Add($"d % a = {d % a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 5;

            resultadoListBox.Items.Add($"x = {x}");

            //x = x - 3;
            x -= 3;
            //x =- 3;

            resultadoListBox.Items.Add($"x = {x}");
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add($"a = {a}");

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pós-Incremental");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add($"a = {a}");

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (true)
            //{
            //    int a = 42;
            //}
            //a = 10;

            ExibirVariaveis();

            resultadoListBox.Items.Add($"w <= x = {w <= x}");
            resultadoListBox.Items.Add($"x == z = {x == z}");
            resultadoListBox.Items.Add($"x != z = {x != z}");
        }

        private void ExibirVariaveis()
        {
            resultadoListBox.Items.Add($"x = {x}");
            resultadoListBox.Items.Add($"w = {w}");
            resultadoListBox.Items.Add($"y = {y}");
            resultadoListBox.Items.Add($"z = {z}");
            resultadoListBox.Items.Add("------------------------------------");
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //x = 22;
            //booleanasToolStripMenuItem_Click();

            ExibirVariaveis();

            resultadoListBox.Items.Add($"w < x || y == 16 = {w < x || y == 16}");
            resultadoListBox.Items.Add($"x == z && z != x = {x == z && z != x}");
            resultadoListBox.Items.Add($"!(y > w) = {!(y > w)}");

        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;
            resultadoListBox.Items.Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}");

            ano = 2016;
            resultadoListBox.Items.Add(
                $"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}");

            string resposta = "";
            if (DateTime.IsLeapYear(ano))
                resposta = "Sim";
            //var x = 12;
            //else
            //    resposta = "Não";
        }
    }
}
