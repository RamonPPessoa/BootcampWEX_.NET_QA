using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Models
{
    public  class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome): base(nome)
        {

        }

        public decimal Salario { get; set; }


        public sealed override void Apresentar() 
        {
            Console.WriteLine($"Sou o(a) professor(a) {Nome},tenho {Idade} e ganho {Salario}");
        }

   
    }
}
