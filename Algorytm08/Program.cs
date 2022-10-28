using System.Text.RegularExpressions;

Console.WriteLine("Podaj zdanie do analizy! [Wpisz 0 by wyjść]");
string input;
do
{
    input = Console.ReadLine();
    Regex rx = new(@"(^[A-ZĘÓĄŚŁŻŹĆŃ]{1}([a-zęóąśłżźćń]*))(\s{1}[A-ZĘÓĄŚŁŻŹĆŃa-zęóąśłżźćń]+[:,;?!.]*)*[a-z]*[?!.]$");
    MatchCollection matches = rx.Matches(input);
    if (matches.Count == 1)
    {
        Console.WriteLine("Zdanie poprawne!");
    }
    else
    {
        Console.WriteLine("Podany tekst nie jest zdaniem!");
    }
} while (input != "0");