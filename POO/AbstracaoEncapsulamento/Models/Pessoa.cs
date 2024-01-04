using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoEncapsulamento.Models
{
    public class Pessoa
    {

        public string Nome { get; set; }

        public int Idade{ get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Ola seu nome é: {Nome} e usa idade é {Idade}");
        }
    }
}
