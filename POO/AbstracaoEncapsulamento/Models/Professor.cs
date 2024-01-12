using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Models
{
    public class Professor : Pessoa
    {

        public decimal Salario { get; set; }


        public override void Apresentar() 
        {
            Console.WriteLine($"Sou o(a) professor(a) {Nome},tenho {Idade} e ganho {Salario}");
        }

   
    }
}
