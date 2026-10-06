using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args) //faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores//
        {
            int A, B, C;

            Console.Write("digite o valor de A: ");

            A = int.Parse(Console.ReadLine());

            Console.Write("digite o valor de B: ");

            B = int.Parse(Console.ReadLine());

            if (A == B)

            {

                C = A * B;

            }

            else
            {

                C = A * B;

            }

            Console.WriteLine("o valor de C é: " + C);

        }

    }

}
        