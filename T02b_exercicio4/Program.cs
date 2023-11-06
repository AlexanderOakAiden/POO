using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T02b_exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Prepare um algoritmo para a tarefa de trocar os valores armazenados em duas variáveis
            //(colocar o valor da variável a em b, e o valor de b em a).

            Console.WriteLine("Insira o valor de A e o valor de B:");
            Console.Write("A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("B: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Os valores trocados de A e B são:");
            var a1 = b;
            var b1 = a;

            Console.WriteLine($"A: {a1}");
            Console.WriteLine($"B: {b1}");

            Console.ReadLine();

        }
    }
}
