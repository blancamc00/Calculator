namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter the operator: ");
            string opera = Console.ReadLine();
            
            Console.WriteLine("How many numbers do you want to " + opera);
            string sizeString = Console.ReadLine();
            int size = int.Parse(sizeString);

            double[] numbers = new double[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number " + (i+1));
                string temp = Console.ReadLine();
                numbers[i] = Double.Parse(temp);
            }
            
            

            double sol = numbers[0];
            if (opera == "+")
            {
                for (int i = 1; i < size; i++)
                {
                    sol += numbers[i];
                }
            }
            else if (opera == "-")
            {
                for (int i = 1; i < size; i++)
                {
                    sol -= numbers[i];
                }
            }
            else if (opera == "*")
            {
                for (int i = 1; i < size; i++)
                {
                    sol *= numbers[i];
                }
            }
            else
            { 
                for (int i = 1; i < size; i++)
                {
                    sol /= numbers[i];
                }
            }
            
            Console.WriteLine("Solution: " + sol);
        }
    }
}