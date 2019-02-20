using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            var valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            //valorCompra = decimal.Parse(valorCompraTextBox.Text);
            //CStr

            decimal troco = valorPago - valorCompra;

            trocoTextBox.Text = /*"R$ " + */ troco.ToString("C");

            var moedas = new List<decimal> { 1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

            foreach (var moeda in moedas)
            {
                var quantidade = (int)(troco / moeda);
                troco %= moeda;
                moedasListView.Items[moedas.IndexOf(moeda)].Text = quantidade.ToString();
            }

            ////ToDo: trocar por estrutura de repetição.
            //var moedas1 = (int)troco;
            ////troco = troco - moedas1;
            ////troco -= moedas1;
            ////troco = troco % 1;
            //troco %= 1;

            //var moedas050 = (int)(troco / 0.5m);
            //troco %= 0.5m;

            //var moedas025 = (int)(troco / 0.25m);
            //troco %= 0.25m;

            //var moedas010 = (int)(troco / 0.1m);
            //troco %= 0.1m;

            //var moedas005 = (int)(troco / 0.05m);
            //troco %= 0.05m;

            //var moedas001 = (int)(troco / 0.01m);
            //troco %= 0.01m;

            //moedasListView.Items[0].Text = moedas1.ToString();
            //moedasListView.Items[1].Text = moedas050.ToString();
            //moedasListView.Items[2].Text = moedas025.ToString();
            //moedasListView.Items[3].Text = moedas010.ToString();
            //moedasListView.Items[4].Text = moedas005.ToString();
            //moedasListView.Items[5].Text = moedas001.ToString();
        }
    }
}
