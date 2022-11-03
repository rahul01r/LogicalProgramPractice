using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Factorial
    {
        public void Fact()
        {
            Console.WriteLine("Enter a number to find a fator");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + "");
                    num = num / i;
                }
            }
        }
    }
}
