namespace Algorytm9
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new();
            foreach (string arg in args)
            {
                string sign = arg[0] == '-' ? "-" : string.Empty;
                string safeString = new(arg.Where(w => char.IsDigit(w)).ToArray());
                safeString = sign + safeString;
                if (safeString.Length > 0)
                {
                    int number = int.Parse(safeString);
                    numbers.Add(number);
                }
            }

            Console.Write("Given numbers: ");
            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            List<int> sortedNumbers = DivideAndConquer(numbers);

            Console.Write("Sorted numbers: ");
            sortedNumbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }

        public static List<int> DivideAndConquer(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                return numbers;
            }
            else
            {
                List<int> firstHalf = numbers.Take(numbers.Count / 2).ToList();
                List<int> secondHalf = numbers.TakeLast(numbers.Count - firstHalf.Count).ToList();
                List<int> left = DivideAndConquer(firstHalf);
                List<int> right = DivideAndConquer(secondHalf);
                List<int> result = new();
                while (left.Count != 0 || right.Count != 0)
                {
                    if (left.Count > 0 && right.Count > 0)
                    {
                        int smaller;
                        if (left.First() < right.First())
                        {
                            smaller = left.First();
                            left.Remove(smaller);
                        }
                        else
                        {
                            smaller = right.First();
                            right.Remove(smaller);
                        }

                        result = result.Append(smaller).ToList();
                    }
                    else
                    {
                        while (left.Any())
                        {
                            result = result.Append(left.First()).ToList();
                            left.Remove(left.First());
                        }
                        while (right.Any())
                        {
                            result = result.Append(right.First()).ToList();
                            right.Remove(right.First());
                        }
                    }
                }

                return result;
            }
        }
    }
}