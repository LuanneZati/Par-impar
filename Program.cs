//Algoritmo que solicita a entrada de um número e calcule se o número é ímpar ou par

using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParImpar parImpar = new ParImpar();
            Console.Write("Enter a number: ");
            parImpar.Number = Convert.ToDouble(Console.ReadLine());
            parImpar.DefineParidade();
        }
    }
    
}