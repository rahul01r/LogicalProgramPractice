using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class GregorianCalendar
    {
        int m, d, y;
        public void DayOfWeek()
        {


            //calculate the day monday=1,tuesday=2,wednesday=3-------sunday=7
            Console.WriteLine("enter the month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the date");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());


            int x, y1, m1, d1;
            y1 = y - (14 - m) / 12;
            x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = m + 12 * ((14 - m) / 12) - 2;
            d1 = (d + x + 31 * m1 / 12) % 7;
            Console.WriteLine(d1);
            {
                if (d1 == 0)
                    Console.WriteLine("Sunday");
            }
            {
                if (d1 == 1)
                    Console.WriteLine("Monday");
            }

            {
                if (d1 == 2)
                    Console.WriteLine("Tuesday");
            }
            {
                if (d1 == 3)
                    Console.WriteLine("Wednesday");
            }
            {
                if (d1 == 4)
                    Console.WriteLine("Thursday");
            }
            {
                if (d1 == 5)
                    Console.WriteLine("Friday");
            }
            {
                if (d1 == 6)
                    Console.WriteLine("Saturday");
            }
        }
    }
}
