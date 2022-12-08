namespace Algorytm16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo do sprawdzenia!");
            string input = new string(Console.ReadLine().ToLower().Where(x => char.IsLetter(x)).ToArray());
            if (CheckPalindrome(input))
            {
                Console.WriteLine(input);
            }
            else
            {
                List<string> palindromes = new List<string>();
                var newInputs = AddLetters(input);
                foreach (var newInput in newInputs)
                {
                    if (CheckPalindrome(newInput))
                    {
                        palindromes.Add(newInput);
                    }
                }

                while (palindromes.Count == 0)
                {
                    newInputs = GenerateLongerInputs(newInputs);
                    foreach (var newInput in newInputs)
                    {
                        if (CheckPalindrome(newInput))
                        {
                            palindromes.Add(newInput);
                        }
                    }
                }
                var result = palindromes.OrderBy(x => x).First();
                Console.WriteLine(result);
            }
        }

        public static bool CheckPalindrome(string input)
        {
            bool palindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    palindrome = false;
                }
            }

            return palindrome;
        }

        public static List<string> AddLetters(string input)
        {
            List<string> newInputs = new();
            for (int i = 0; i <= input.Length; i++)
            {
                for (int j = 97; j <= 122; j++)
                {
                    string newInput = input[..i] + (char)j + input[i..];
                    newInputs.Add(newInput);
                }
            }

            return newInputs;
        }

        public static List<string> GenerateLongerInputs(List<string> inputs)
        {
            List<string> longerInputs = new();
            foreach (var newInput in inputs)
            {
                longerInputs.AddRange(AddLetters(newInput));
            }
            return longerInputs;
        }
    }
}