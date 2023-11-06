using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02b_exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Especifique um algoritmo e faça a sua implementação, para converter uma temperatura
            //fornecida em graus Fahrenheit para graus Celsius, sabendo que:
            //C = 5/9 * (F - 32)

            Console.WriteLine("Insira o valor em graus Fahrenheit:");
            float f = float.Parse(Console.ReadLine());

            float c = (5.0f / 9.0f )*(f - 32.0f);
                
                //(5 / 9) * (f - 32);

            Console.WriteLine("O valor em graus Celsius  é:\n" + c);



            Console.ReadLine();

        }
    }
}
