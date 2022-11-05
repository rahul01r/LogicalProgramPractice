using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class TemperaturConversion
    {
        public void TempConversion()
        {
            while (true)
            {
                Console.Write("select opption \n1.Celsius to Fahrenheit \n2.Fahrenheit to Celsius");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter temperature in Celsius : ");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = ((celsius * 9) / 5) + 32;
                        Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
                        break;
                    case 2:
                        Console.Write("Enter temperature in Fahrenheit: ");
                        double fahrenheii = Convert.ToDouble(Console.ReadLine());
                        double celsiusi = ((fahrenheii - 32) * 5 / 9);
                        Console.WriteLine("The converted fahrenheit temperature is : " + celsiusi);
                        break;

                }
            }
        }
    }
}
