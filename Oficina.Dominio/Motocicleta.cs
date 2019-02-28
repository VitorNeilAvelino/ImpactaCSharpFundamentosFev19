using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{
    public class Motocicleta : Veiculo
    {
        public TipoMotocicleta Tipo { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
