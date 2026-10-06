using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reajuste

{

    internal class Program
    {

        static void Main(string[] args) // Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%//

        {

            double valor;

            double soma;

            Console.WriteLine("Digite o Valor:");
            valor = double.Parse(Console.ReadLine());


            soma = valor + (valor * 0.05);

            Console.WriteLine("\nO reajuste é de: " + soma);


        }

    }

}