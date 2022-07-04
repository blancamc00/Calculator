namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Enter first number");
            string firstNumberString = Console.ReadLine();
            double firstNumber = Double.Parse(firstNumberString);
            
            Console.WriteLine("Enter second number");
            string secondNumberString = Console.ReadLine();
            double secondNumber = Double.Parse(secondNumberString);

            double sol = firstNumber * secondNumber;
            Console.WriteLine("Solution: " + sol);
        }
    }
}