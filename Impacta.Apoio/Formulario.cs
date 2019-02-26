using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Apoio
{
    public class Formulario
    {
        public bool Validar(Form formulario, ErrorProvider provedorErro)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }

                provedorErro.SetError(controle, "");

                if (controle.Tag.ToString().Contains("*") &&
                    controle.Text == string.Empty)
                {
                    DefinirErro(provedorErro, controle, "Campo obrigatório.");
                }
                else
                {
                    ValidarTipoDado(controle, provedorErro);
                }
            }

            return FormularioEstahSemErros(formulario, provedorErro);
        }

        private bool FormularioEstahSemErros(Form formulario, ErrorProvider provedorErro)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (provedorErro.GetError(controle) != string.Empty)
                {
                    return false;
                }                
            }

            return true;
        }

        private static void DefinirErro(ErrorProvider provedorErro, Control controle, 
            string mensagem)
        {
            provedorErro.SetError(controle, mensagem);
            controle.Focus();
        }

        private void ValidarTipoDado(Control controle, ErrorProvider provedorErro)
        {
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                //+: 1 - muitos
                //*: 0 - muitos
                //?: 0 ou 1
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))
                {
                    DefinirErro(provedorErro, controle, "Digite a placa no formato AAA-0000");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (!Regex.IsMatch(controle.Text, @"[0-9]{4}"))
                {
                    DefinirErro(provedorErro, controle, "Digite o ano com 4 dígitos.");
                }
            }
        }
    }
}