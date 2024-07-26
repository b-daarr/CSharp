namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // if, else if, else
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine("Odd number");
            }
            else
            {
                Console.WriteLine("Error");
            }

            // try, catch, finally
            try
            {
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("An error occurred");
            }
            finally
            {
                Console.WriteLine("Process was complete");
            }

            // for, for each, while, do while
            bool key = true;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The number is " + i);
            }

            char[] test = { 'a', 'b', 'c', 'd', 'e', 'f' };

            foreach (char c in test)
            {
                if (c == 'f')
                {
                    Console.WriteLine("Character is " + c);
                }
            }

            while (key)
            {
                Console.Write("Enter x for exit: ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'x' || x == 'X')
                {
                    key = false;
                }
            }

            // switch
            double fno = double.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            double sno = double.Parse(Console.ReadLine());

            double result;
            switch (operators)
            {
                case '+':
                    result = fno + sno; break;
                case '-':
                    result = fno - sno; break;
                case '*':
                    result = fno * sno; break;
                case '/':
                    result = fno / sno; break;
                case '%':
                    result = fno % sno; break;
                default:
                    result = 0; break;
            }
            Console.WriteLine(result);

            int a = 10;
            int b1 = a++;
            int b2 = ++a;

            Console.WriteLine("{0} {1}", b1 + b2);

            Console.ReadKey();
        }
    }
}
