namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select program \n1.Fibonacci series\n2 Given Number is Perfect or Not");
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
                }
            }
        }
    }
}