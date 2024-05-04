using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDotnet.Models
{
    public class Pessoa
    {
        public int? idade { get; set; }
        public string? nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Olá! Meu nome é "+ nome +", e tenho " + idade + " anos de idade");
        }

    }
}