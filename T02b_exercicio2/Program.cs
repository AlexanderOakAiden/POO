using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02b_exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //float hh, mm, ss;

            Console.WriteLine("Escreva as hora, os minutos e os segundos:");
            float hh = float.Parse(Console.ReadLine());
            float mm = float.Parse(Console.ReadLine());
            float ss = float.Parse(Console.ReadLine());

            float segundos = (hh * 3600) + (mm * 60) + ss;



            Console.WriteLine("Tempo total em segundos: \n" + segundos);

            Console.ReadLine();

        }
    }
}
