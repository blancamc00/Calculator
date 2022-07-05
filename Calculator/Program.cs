namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter the first operator: ");
            string opera = Console.ReadLine();
            
            Console.WriteLine("Enter first number");
            string firstNumberString = Console.ReadLine();
            double firstNumber = Double.Parse(firstNumberString);
            
            Console.WriteLine("Enter second number");
            string secondNumberString = Console.ReadLine();
            double secondNumber = Double.Parse(secondNumberString);

            double sol;
            if (opera == "+")
            {
                sol = firstNumber + secondNumber;
            }
            else if (opera == "-")
            {
                sol = firstNumber - secondNumber;
            }
            else if (opera == "*")
            {
                sol = firstNumber * secondNumber;
            }
            else
            { 
                sol = firstNumber / secondNumber;
            }
            
            Console.WriteLine("Solution: " + sol);
        }
    }
}