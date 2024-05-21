using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDotnet.Common.Models
{
    public class LacoWhile
    {
        public void Tabuada(int numero)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
                contador++;

                if (contador == 10)
                {
                    break;
                }
            }
        }
    }
}