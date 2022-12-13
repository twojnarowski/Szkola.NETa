using System.Text;

// 1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

Console.Write("Liczby pierwsze: ");
for (int i = 2; i <= 100; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        Console.Write($"{i}, ");
    }
}

Console.WriteLine();

// 2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
// zakresu 0 – 1000.

int k = 0;
Console.Write("Liczby parzyste: ");
do
{
    Console.Write($"{k}, ");
    k += 2;
}
while (k <= 1000);
Console.WriteLine();

// 3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

Console.Write("Podaj ilość liczb ciągu Fibonacciego do wyliczenia: ");
double fib1 = 0;
double fib2 = 1;
if (int.TryParse(Console.ReadLine(), out int fibonacciLength))
{
    Console.Write($"Ciąg Fibonacciego: {fib1}, {fib2}, ");
    for (int i = 0; i < fibonacciLength - 2; i++)
    {
        double fib3 = fib1 + fib2;
        Console.Write($"{fib3}, ");
        fib1 = fib2;
        fib2 = fib3;
    }
}

Console.WriteLine();

// 4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
// liczby w formie jak poniżej:
// 1
// 2 3
// 4 5 6
// 7 8 9 10

Console.Write("Podaj liczbę do stworzenia piramidki: ");
if (int.TryParse(Console.ReadLine(), out int numberStairs))
{
    int i = 1;
    int loopStage = 1;
    while (i < numberStairs)
    {
        for (int j = 0; j < loopStage; j++)
        {
            if (i <= numberStairs)
            {
                Console.Write($"{i++} ");
            }
        }
        loopStage++;
        Console.WriteLine();
    }
}

// 5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

Console.Write("Sześciany liczb od 1 do 20: ");
for (int i = 1; i <= 20; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}

Console.WriteLine();

// 6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
// 1 + ½ +1 / 3 + ¼ itd.

Console.WriteLine("Suma ciągu an = 1/n dla n e {1, 20}: ");
for (int i = 1; i <= 20; i++)
{
    double sum = 0;
    for (int j = 1; j <= i; j++)
    {
        sum += (double)1 / j;
    }
    Console.WriteLine($"{i} => {sum.ToString()}");
}

// 7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
// przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
//     *
//    ***
//   *****
//  *******
// *********
//  *******
//   *****
//    ***
//     *

Console.Write("Podaj przekątną diamentu: ");
if (int.TryParse(Console.ReadLine(), out int numberDiamond))
{
    int firstRow = 1;
    if (numberDiamond % 2 == 0)
    {
        firstRow = 2;
    }

    for (int i = firstRow; i <= numberDiamond; i += 2)
    {
        for (int j = (numberDiamond - i) / 2; j >= 0; j--)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

    for (int i = numberDiamond - 2; i >= firstRow; i -= 2)
    {
        for (int j = 0; j < (numberDiamond - i + 2) / 2; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

// 8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
// Testowe dane:
// Abcdefg
// Rezultat
// Gfedcba

Console.Write("Proszę podać ciąg znaków do odwrócenia: ");
var text = Console.ReadLine();
StringBuilder reverseText = new StringBuilder();
if (text is not null)
{
    for (int i = text.Length - 1; i >= 0; i--)
    {
        reverseText.Append(text[i]);
    }
}

Console.WriteLine(reverseText.ToString());

// 9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

Console.Write("Podaj liczbę do przekonwertowania na binarną: ");
if (int.TryParse(Console.ReadLine(), out int numberDecimal))
{
    string binaryReverse = "";
    while (numberDecimal > 0)
    {
        binaryReverse += numberDecimal % 2;
        numberDecimal = numberDecimal / 2;
    }

    for (int i = binaryReverse.Length - 1; i >= 0; i--)
    {
        Console.Write(binaryReverse[i]);
    }
}

Console.WriteLine();

// 10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

int number1;
int number2;
do
{
    Console.WriteLine("Podaj dwie liczby do znalezienia ich NWW, wciskając po każdej z nich enter: ");
}
while (!int.TryParse(Console.ReadLine(), out number1) || !int.TryParse(Console.ReadLine(), out number2));

int number1multiple = number1;
int number2multiple = number2;
int number1base = 2;
int number2base = 2;
while (number1multiple != number2multiple)
{
    if (number1multiple < number2multiple)
    {
        number1multiple = number1 * number1base++;
    }
    else
    {
        number2multiple = number2 * number2base++;
    }
}

Console.WriteLine("Największa wspólna wielokrotność podanych liczb to: " + number1multiple);