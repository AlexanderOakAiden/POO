using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02b_exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coordenadas de dois pontos cartesianos
            Console.WriteLine("Insira a coordenada X e Y do ponto1:");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a coordenada X e Y do ponto2:");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            float distancia = (y2 - y1) * (x2 - x1) + (x2 - x1) * (x2 - x1);

            Console.WriteLine("A distancia entre o ponto1 e o ponto2 é:\n" + distancia);

            Console.ReadLine();
        }
    }
}
