using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDotnet.Common.Models
{
    public class LacoDoWhile
    {
        public void Soma()
        {
            int numero = 0, soma = 0;
            do
            {
                Console.WriteLine("Digite um numero para somar e depois digite 0 para calcular");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;
            }while(numero != 0);

            Console.WriteLine($"Total da soma dios numeros digitados é: {soma}");

        }
    }
}