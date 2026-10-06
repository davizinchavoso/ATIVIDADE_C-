using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    internal class Program //FAÇA UM ALGORITMO QUE LEIA O VALOR DO SALARIO MINIMO E O VALOR DO SALARIO DE UM USUARIO,CALCULE QUANTOS SALARIOS MINIMOS//
    {
        static void Main(string[] args)
        {
            double salario;
            int quantidade;

            Console.Write("Digite o seu salário: R$ ");
            salario = double.Parse(Console.ReadLine());

            quantidade = (int)(salario / 1518);

            Console.WriteLine("Você ganha " + quantidade + " salários mínimos.");


        }

    }
}
