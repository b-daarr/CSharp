namespace P04
{
    internal class Program
    {

        public static bool Logic_Gates(bool a, bool b, string operators)
        {
            switch (operators)
            {
                case "and":
                    return a & b;
                case "or":
                    return a | b;
                case "nand":
                    return !(a & b);
                case "nor":
                    return !(a | b);
                case "xor":
                    return a ^ b;
                case "xnor":
                    return !(a ^ b);
                default:
                    throw new NotSupportedException();
            }
        }

        public static bool BN(bool b, string operators)
        {
            switch (operators)
            {
                case "not":
                    return !b;
                case "buffer":
                    return b;
                default:
                    throw new NotSupportedException();
            }
        }

        static void Main(string[] args)
        {
            // Logic Gates
            bool opMode;
            Console.Write("Binary {b} or Unary {u} ?: ");
            string mode = Console.ReadLine();
            mode = mode.ToLower();

            switch (mode)
            {
                case "b":
                    opMode = true; break;
                case "u":
                    opMode = false; break;
                default:
                    throw new NotSupportedException();
            }

            if (opMode)
            {
                Console.Write("Binary mode - Enter first logic: ");
                bool i = bool.Parse(Console.ReadLine());
                Console.Write("Binary mode - Enter logic operator {and, or, nand, nor, xor, xnor}: ");
                string operators = Console.ReadLine();
                operators = operators.ToLower();
                Console.Write("Binary mode - Enter second logic: ");
                bool o = bool.Parse(Console.ReadLine());

                Console.WriteLine("Result: " + Logic_Gates(i, o, operators));
            }
            else
            {
                Console.Write("Unary mode - Enter logic: ");
                bool i = bool.Parse(Console.ReadLine());
                Console.Write("Unary mode - Enter logic operator {not, buffer}: ");
                string operators = Console.ReadLine();
                operators = operators.ToLower();

                Console.WriteLine("Result: " + BN(i, operators));
            }

            Console.ReadKey();
        }
    }
}
