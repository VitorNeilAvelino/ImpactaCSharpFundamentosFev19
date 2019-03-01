using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentos.Capitulo04.Frete
{
    public class Frete
    {
        public Frete(UF uf, decimal valor)
        {
            UF = uf;
            Valor = valor;

            Calcular();
        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; set; }
        public UF UF { get; set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; private set; }

        private void Calcular()
        {
            switch (UF.Sigla.ToUpper())
            {
                case "SP":
                    Percentual = 0.2m;
                    break;
                case "ES":
                case "RJ":
                    Percentual = 0.3m;
                    break;
                case "MG":
                    Percentual = 0.35m;
                    break;
                case "AM":
                    Percentual = 0.6m;
                    break;
                default:
                    Percentual = 0.75m;
                    break;
            }

            Total = (1 + Percentual) * Valor;
        }
    }
}
