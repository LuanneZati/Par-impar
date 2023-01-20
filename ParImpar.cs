using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class ParImpar
    {
        private double number;
        public double Number{  set { number = value; } }

        public void DefineParidade()
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is par.");
            }
            else
            {
                Console.WriteLine($"{number} is impar.");
            }
        }
    }
}
