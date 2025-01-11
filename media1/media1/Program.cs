using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor1, valor2, valor3, valor4, media;
            Console.Write("Informe o primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            valor3 = float.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor: ");
            valor4 = float.Parse(Console.ReadLine());

            media = (float) (valor1 + valor2 + valor3 + valor4) / 4;
            Console.WriteLine($"A média dos valores é: {media:F2}");

            Console.ReadKey();
        }
    }
}
