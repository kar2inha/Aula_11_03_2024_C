using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ladoA, ladoB, ladoC;

            Console.WriteLine("Insira o lado A: ");
            ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado B: ");
            ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado C: ");
            ladoC = float.Parse(Console.ReadLine());
            if ((ladoA>ladoB+ladoC)||(ladoB>ladoA+ladoC)||(ladoC>ladoB+ladoA))
            {
                Console.WriteLine("Os valores informados não formam um triângulo");
            }

            else if ((ladoA==ladoB)&&(ladoB==ladoC)&&(ladoC==ladoA))
            {
                Console.WriteLine("Tipo de triângulo: Equilátero");
            }
            else if ((ladoA!=ladoB)&&(ladoB!=ladoC)&&(ladoC!=ladoA)){
                Console.WriteLine("Tipo de triângulo: Escaleno");
            }
            else
            {
                Console.WriteLine("Tipo de triângulo: Isósceles");
            }
            Console.ReadKey();
        }
    }
}
