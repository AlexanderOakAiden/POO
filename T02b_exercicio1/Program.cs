using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02b_exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a medida da largura do quadrado:");
            float largura = float.Parse(Console.ReadLine());


            float perimetro = largura + largura + largura + largura;
            Console.WriteLine("O perimetro do quadrado é: \n" + perimetro);

            float area = largura * largura;
            Console.WriteLine("A área do quadrado é: \n" + area);

            Console.ReadLine();
        }
    }
}
