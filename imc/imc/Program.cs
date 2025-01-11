using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura, peso, imc;

            Console.Write("Informe a sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.Write("Informe o seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18.5) {
                Console.Write("Abaixo do peso");
            }
            else if (imc <= 24.9){
                Console.Write("Peso normal");
            }
            else if(imc <= 29.9){
                Console.Write("Sobrepeso");
            }

            else if (imc <= 34.9){
                Console.Write("Obesidade grau 1");
            }

            else if (imc <= 39.9)
            {
                Console.Write("Obesidade grau 2");
            }

            else
            {
                Console.Write("Obesidade grau 3");
            }

            Console.ReadKey();
        }
    }
}
