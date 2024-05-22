using System.ComponentModel;
using cursoDotnet.Common.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

//declarando um novo array e depois copiando o array antigo para o novo

 int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
 Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// //redimensionar array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

//percorrendo array com o for
Console.WriteLine("Percorrendo o array com o for");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº{contador} = {arrayInteiros[contador]}");
}




























// Console.WriteLine("Percorrendo o array com Foreach");
// int contadorForeach = 0;
// //percorrendo array com o foreach
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº{contadorForeach} = {valor}");
//     contadorForeach++;
// }






















// string opcao;
// while (true)
// {
// Console.Clear();
// Console.WriteLine("Digite uma opção");
// Console.WriteLine("1 - Cadastrar cliente");
// Console.WriteLine("2 - Buscar cliente");
// Console.WriteLine("3 - Apagar cliente");
// Console.WriteLine("4 - Encerrar");

// opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.Write("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }

// }
































// LacoFor lacoFor = new LacoFor();
// lacoFor.Tabuada(3);

// LacoWhile lacoWhile = new LacoWhile();
// lacoWhile.Tabuada(4);

// LacoDoWhile lacoDoWhile  = new LacoDoWhile();
// lacoDoWhile.Soma();



























// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando 10 em 1");
// // outras maneiras de incrementar: 
// // numero = numero + 1;
// // numero += 1;
// numero++;    
// Console.WriteLine(numero);

// //Em outro cenário
// int numero2 = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando 10 em 2");
// numero2 += 2;
// // outra maneira: 
// // numero2 = numero2 + 2
// Console.WriteLine(numero2);
































// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(4);





























// Pessoa pessoa= new Pessoa();

// pessoa.nome="oi eu sou a Larissa e estou usando referencia de outro projeto";
// pessoa.idade=22;
// pessoa.Apresentar();