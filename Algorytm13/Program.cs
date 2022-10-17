namespace Algorytm13
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                double res = 0;
                switch (args[2])
                {
                    case "+":
                        res = double.Parse(args[0]) + double.Parse(args[1]);
                        Console.WriteLine(res);
                        break;

                    case "-":
                        res = double.Parse(args[0]) - double.Parse(args[1]);
                        Console.WriteLine(res);
                        break;

                    case "/":
                        if (double.Parse(args[1]) != 0)
                        {
                            res = double.Parse(args[0]) / double.Parse(args[1]);
                            Console.WriteLine(res);
                        }
                        break;

                    case "*":
                        res = double.Parse(args[0]) * double.Parse(args[1]);
                        Console.WriteLine(res);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}