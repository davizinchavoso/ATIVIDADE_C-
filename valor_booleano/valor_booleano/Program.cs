using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_booleano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor1, valor2;

            Console.Write("Digite o primeiro valor: ");
            valor1 = bool.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = bool.Parse(Console.ReadLine());

            Console.WriteLine("Ambos são verdadeiros? " + (valor1 && valor2));
            Console.WriteLine("Ambos são falsos? " + (!valor1 && !valor2));
        }
    }
}
