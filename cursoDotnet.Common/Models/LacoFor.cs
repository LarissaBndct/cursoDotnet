using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoDotnet.Common.Models
{
    public class LacoFor
    {
        public void Tabuada(int tabuada)
        {

            for(int contador = 0; contador <=10; contador++)
            {
                Console.WriteLine($"{tabuada} x {contador} = {tabuada * contador}");
            }
        }

    }
}