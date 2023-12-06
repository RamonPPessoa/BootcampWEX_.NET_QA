﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_Metodo_Construtores.Models
{
     public class Pessoa

       
    {
        private string _nome;
        private int _idade;
        public string Nome 
        {
            get => _nome.ToUpper();
            
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException(" O nome não pode ser vazio");

                }
                _nome = value;

            }
        
        }

        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0(zero)");
                }
                _idade = value;
            } 
        
        }

        public  void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome},Idade: {Idade}");
        }
    }
}