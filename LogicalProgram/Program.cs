﻿namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select program \n1.Fibonacci series\n2 Given Number is Perfect or Not\n3.Enter the number to check either its Prime num or not\n4. Reverse Number\n5.CCoupan Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.FibonoccSeriesNumber();
                        break;
                    case 2:
                       PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.PerfectNum();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();    
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.RevNumber();
                        break ; 
                    case 5:
                        CoupanNumber coupanNumber = new CoupanNumber();
                        coupanNumber.DistnictCoupanNumber();
                        break;
                }
            }
        }
    }
}