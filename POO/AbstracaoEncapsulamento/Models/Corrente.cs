using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
