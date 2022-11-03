namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select program \n1.Fibonacci series\n2.Reverse the Given  Number\n3.Prime Number\n4.Palindrome Number\n5.Factroil");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.FibonoccSeriesNumber();
                        break;
                    case 2:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.ReversNumber();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();    
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        Palindrome palindrome = new Palindrome();
                        palindrome.PalindromeNum();
                        break;
                    case 5:
                        Factorial factorial = new Factorial();
                        factorial.Fact();
                        break;
                }
            }
        }
    }
}