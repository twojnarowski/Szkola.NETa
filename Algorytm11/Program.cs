namespace Algorytm11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj zakodowane zdanie! [Wpisz 0 by wyjść]");
            string input;
            do
            {
                input = Console.ReadLine();
                if (input.Length > 0)
                {
                    string conv1 = Converter(input[0].ToString());
                    if (conv1 != null)
                    {
                        GetNextPossibilities(conv1, input[1..]);
                    }

                    if (input.Length >= 2)
                    {
                        string conv2 = Converter(input[0..2]);
                        if (conv2 != null)
                        {
                            GetNextPossibilities(conv2, input[2..]);
                        }
                    }
                }
            } while (input != "0");
        }

        private static void GetNextPossibilities(string converted, string input)
        {
            if (input.Length <= 1)
            {
                Console.WriteLine(converted + Converter(input));
            }
            else
            {
                string conv1 = Converter(input[0].ToString());
                if (conv1 != null)
                {
                    GetNextPossibilities(converted + conv1, input[1..]);
                }

                if (input.Length >= 2)
                {
                    string conv2 = Converter(input[0..2]);
                    if (conv2 != null)
                    {
                        GetNextPossibilities(converted + conv2, input[2..]);
                    }
                }
            }
        }

        private static string Converter(string ascii)
        {
            if (ascii is not null && ascii != string.Empty)
            {
                var number = int.Parse(ascii);
                if (number <= 26 && number >= 1)
                {
                    return ((char)(number + 96)).ToString();
                }
            }

            return null;
        }
    }
}