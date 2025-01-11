using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhaadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float SalTotal, SalExce, hrTra = 150, hrExce, Pagamento;
            Console.WriteLine("Informe sua quantidade de horas trabalhadas: ");
            hrExce = float.Parse(Console.ReadLine());
            SalTotal = hrTra * 20;
            SalExce = (hrExce - hrTra) * 30;
            Console.WriteLine($"Seu sálario é: {SalTotal:C}");

            Console.WriteLine($"Suas horas excedidas são: {SalExce:C}");
            Pagamento = SalExce + SalTotal;
            Console.WriteLine($"Seu salário este mês é: {Pagamento:C}");

            Console.ReadKey();
        }
    }
}
