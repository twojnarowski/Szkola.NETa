foreach (string numer in args)
{
    Console.WriteLine(numer + " -> " + new string(numer.Where(x => char.IsDigit(x)).Count().ToString()));
}