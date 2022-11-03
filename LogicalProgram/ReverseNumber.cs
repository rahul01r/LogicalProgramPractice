using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        int revrseNUm = 0;
        public void ReversNumber()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine()); // num=456
            while (num > 0)
            {
                int reminder = num % 10; //456%10=6 ,// 45%10 = 5 // 4%10 =4
                revrseNUm = revrseNUm * 10 + reminder; //revrseNUm=6 //6*10+5=65 //65*10+4=654
                num = num / 10; //num 456/10=45 , // 45/10= 4
            }
            Console.WriteLine(revrseNUm);

        }
    }
}
