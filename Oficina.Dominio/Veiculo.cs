using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    //ToDo: OO - Classe ou abstração.
    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        //ToDo: encapsulamento.
        private string placa;

        public string Placa
        {
            get
            {
                return placa.ToUpper();
            }

            set
            {
                placa = value.ToUpper();
            }
        }

        public Cor Cor { get; set; }
        public Modelo Modelo { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }

        protected List<string> ValidarBase()
        {
            var erros = new List<string>();

            if (Ano < 1980 || Ano - DateTime.Now.Year > 1)
            {
                erros.Add($"O ano informado ({Ano}) não é válido.");
            }

            return erros;
        }

        //ToDo: OO - polimorfismo por substituição (sobrescrita)
        public abstract List<string> Validar();
    }
}
