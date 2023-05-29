namespace Day6Programs
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
                Console.WriteLine("Welcome to Basic C# programs");
                Console.WriteLine("Please choose any one program from below option");
                Console.WriteLine("1.Perfect Number\n2.Fibonacci Series\n3.Reverse a Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter The Number");
                        int p = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber.Check1(p);
                        break;
                    case 2:
                        Console.WriteLine("Please enter how many series you want to generate");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries.GenerateFibonacciNumb(n);
                        break;
                    case 3:
                        Console.WriteLine("Enter The Number To Reverse");
                        int r = Convert.ToInt32(Console.ReadLine());
                        ReverseNumber.Check2(r);
                        break;
                    default:
                        Console.WriteLine("please choose existing programs");
                        break;




                }
        }
        
    }
}