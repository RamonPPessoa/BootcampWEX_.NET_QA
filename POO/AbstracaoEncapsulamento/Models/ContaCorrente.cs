using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta,decimal saldoInicial )
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo { get; set; }

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

                                        
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é:" + saldo);
        }
    }
}
