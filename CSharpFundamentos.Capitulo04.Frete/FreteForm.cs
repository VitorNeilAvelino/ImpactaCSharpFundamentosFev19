using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo04.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            var percentual = 0M;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                //case "SP":
                //    percentual = 0.2m;
                //    break;
                case "ES":
                case "RJ":
                    percentual = 0.3m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                default:
                    percentual = 0.75m;
                    break;
            }

            if (ufComboBox.Text == "SP")
            {
                percentual = 0.2m;
            }
            else if (ufComboBox.Text == "RJ")
            {
                percentual = 0.3m;
            }
            else if (ufComboBox.Text == "MG")
            {
                percentual = 0.35m;
            }
            else
            {
                percentual = 0.75m;
            }

            freteTextBox.Text = percentual.ToString("P1");
            totalLabel.Text = ((1 + percentual) * valor).ToString("C");
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text == "")
            {
                erros.Add("O campo Cliente é obrigatório.");
            }

            if (valorTextBox.Text == string.Empty)
            {
                erros.Add("O campo Valor é obrigatório.");
            }
            else
            {
                decimal valor = 0;

                if (!decimal.TryParse(valorTextBox.Text, out valor))
                {
                    erros.Add("O campo Valor está com formato inválido.");
                }
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione uma UF.");
            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Text = "";
            valorTextBox.Clear();
            freteTextBox.Text = null;
            totalLabel.Text = string.Empty;

            ufComboBox.SelectedIndex = -1;
        }
    }
}
