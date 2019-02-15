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
        }
    }
}
