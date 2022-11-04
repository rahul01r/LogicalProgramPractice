using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public  class ReverseNumber
    {
        int revrseNUm = 0;
        public void RevNumber()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int reminder = num % 10;
                revrseNUm = revrseNUm * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine("Reverse number: " +revrseNUm);

        }
    }
}
