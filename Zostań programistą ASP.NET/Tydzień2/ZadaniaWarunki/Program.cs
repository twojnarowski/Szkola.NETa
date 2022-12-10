using System.Text;

// 1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
// one równe czy nie.
// Dane testowe:
// a: 5
// b: 5
// Rezultat w terminalu :
// 5 i 5 są równe

int a = 5;
int b = 5;

if (a == b)
{
    Console.WriteLine("5 i 5 są równe");
}

// 2.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
// jest parzysta czy nieparzysta.
// Dane testowe : 15
// Rezultat w terminalu :
// 15 jest liczbą nieparzystą

Console.Write("Podaj liczbę do sprawdzenia parzystości: ");
if (int.TryParse(Console.ReadLine(), out int numberParity))
{
    string parity;
    if (numberParity != 0)
    {
        parity = (numberParity % 2 == 0) switch
        {
            true => "parzystą",
            false => "nieparzystą"
        };
    }
    else
    {
        parity = "nieparzystą";
    }

    Console.WriteLine($"{numberParity} jest liczbą {parity}");
}

// 3.Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
// jest dodatnia czy ujemna.
// Dane testowe : 14
// Rezultat w terminalu :
// 14 jest liczbą dodatnią

Console.Write("Podaj liczbę do sprawdzenia znaku: ");
if (int.TryParse(Console.ReadLine(), out int numberSign))
{
    string sign = " jest liczbą ";
    if (numberSign != 0)
    {
        sign += (numberSign > 0) switch
        {
            true => "dodatnią",
            false => "ujemną"
        };
    }
    else
    {
        sign = " nie jest liczbą ani dodatnią, ani ujemną";
    }

    Console.WriteLine(numberSign + sign);
}

// 4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
// jest rokiem przestępnym.
// Dane testowe : 2016
// Rezultat w terminalu :
// 2016 jest rokiem przestępnym

Console.Write("Podaj rok do sprawdzenia czy jest przestępny: ");
if (int.TryParse(Console.ReadLine(), out int numberLeapYear))
{
    string @is = string.Empty;
    if (numberLeapYear % 400 == 0 || (numberLeapYear % 4 == 0 && numberLeapYear % 100 != 0))
    {
        @is = "jest";
    }
    else
    {
        @is = "nie jest";
    }

    Console.WriteLine($"{numberLeapYear} {@is} rokiem przestępnym");
}

// 5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
// uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
// prezydenta.
// Dane testowe : 21
// Rezultat w terminalu :
// Możesz zostać posłem

// poseł = 21
// senator = 30
// prezydent = 35
// premier = 21

Console.Write("Podaj swój wiek, żeby sprawdzić na jakie stanowisko możesz kandydować: ");
if (int.TryParse(Console.ReadLine(), out int numberPoliticsAge))
{
    StringBuilder response = new StringBuilder($"W wieku {numberPoliticsAge} możesz zostać ");
    if (numberPoliticsAge < 21)
    {
        response.Append("nikim");
    }

    if (numberPoliticsAge >= 21)
    {
        response.Append($"posłem lub premierem");
    }

    if (numberPoliticsAge >= 30)
    {
        response.Append($" a także senatorem");
    }

    if (numberPoliticsAge >= 35)
    {
        response.Append($" lub prezydentem");
    }

    response.Append($".");
    Console.WriteLine(response.ToString());
}

// 6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
// wymyśloną kategorię wzrostu.
// Dane testowe : 140
// Rezultat w terminalu :
// Jesteś krasnoludem

Console.Write("Podaj swój wzrost (w cm), żebym mógł Cię obrazić: ");
if (int.TryParse(Console.ReadLine(), out int numberHeight))
{
    string insult = "Twój wzrost można określić jako ";
    if (numberHeight < 140)
    {
        insult += "krasnoludzki";
    }
    else if (numberHeight < 153)
    {
        insult += "karłowaty";
    }
    else if (numberHeight < 163)
    {
        insult += "niski";
    }
    else if (numberHeight < 172)
    {
        insult += "średni";
    }
    else if (numberHeight < 178)
    {
        insult += "wysoki";
    }
    else
    {
        insult += "bardzo wysoki";
    }

    Console.WriteLine(insult);
}

// 7.Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
// która jest największa
// Dane testowe:
// 25
// 63
// 79
// Rezultat w terminalu :
// 79 jest największa z podanych

Console.WriteLine("Podaj 3 liczby, wciskając enter po każdej z nich: ");
List<int> numbers = new();
for (int i = 0; i < 3; i++)
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Podano błędne dane");
    }
}
if (numbers.Count > 0)
{
    Console.WriteLine($"{numbers.Max()} jest największą liczbą z podanych");
}

// 8.Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
// na studiach wg. Następujących kryteriów:
// Wynik z Matury z matematyki powyżej 70
// Wynik z fizyki powyżej 55
// Wynik z chemii powyżej 45
// Łączny wynik z 3 przedmiotów powyżej 180
// Albo
// Wynik z matematyki i jednego przedmiotu powyżej 150
// Dane testowe:
// Matematyka 80
// Fizyka 71
// Chemia 0
// Rezultat w terminalu :
// Kandydat dopuszczony do rekrutacji

Console.WriteLine("Podaj swoje wyniki z matury!");
Console.Write("Wynik z matematyki: ");
int.TryParse(Console.ReadLine(), out int maturaMathScore);
Console.Write("Wynik z fizyki: ");
int.TryParse(Console.ReadLine(), out int maturaPhysicsScore);
Console.Write("Wynik z chemii: ");
int.TryParse(Console.ReadLine(), out int maturaChemistryScore);
bool qualified = false;
qualified = qualified || maturaChemistryScore + maturaMathScore + maturaPhysicsScore > 180;
qualified = qualified || maturaMathScore + maturaPhysicsScore > 150;
qualified = qualified || maturaChemistryScore + maturaMathScore > 150;
Console.WriteLine($"Kandydat {(!qualified ? "nie" : "")} dopuszczony do rekrutacji");

// 9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w
// poniższych kryteriach
// Temp < 0 – cholernie piździ
// Temp 0 – 10 – zimno
// Temp 10 – 20 – chłodno
// Temp 20 – 30 – w sam raz
// Temp 30 – 40 – zaczyna być słabo, bo gorąco
// Temp >= 40 – a weź wyprowadzam się na Alaskę.
// Dane testowe : 41
// Rezultat w terminalu :
// a weź wyprowadzam się na Alaskę.

Console.Write("Podaj temperaturę w celcjuszach: ");
if (int.TryParse(Console.ReadLine(), out int numberTemperature))
{
    string reaction;
    if (numberTemperature < 0)
    {
        reaction = "cholernie piździ";
    }
    else if (numberTemperature < 10)
    {
        reaction = "zimno";
    }
    else if (numberTemperature < 20)
    {
        reaction = "chłodno";
    }
    else if (numberTemperature < 30)
    {
        reaction = "w sam raz";
    }
    else if (numberTemperature < 40)
    {
        reaction = "zaczyna być słabo, bo gorąco";
    }
    else
    {
        reaction = "a weź wyprowadzam się na Alaskę.";
    }

    Console.WriteLine(reaction);
}

// 10.Napisz program, który sprawdzi, czy z 3 podanych długości można
// stworzyć trójkąt
// Dane testowe : 40 55 65
// Rezultat w terminalu :
// Można zbudować trójkąt

Console.WriteLine("Podaj 3 długości boków trójkąta, wciskając enter po każdej z nich: ");
List<int> numbersTriangle = new();
for (int i = 0; i < 3; i++)
{
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbersTriangle.Add(number);
    }
    else
    {
        Console.WriteLine("Podano błędne dane");
    }
}

if (numbersTriangle.Count == 3)
{
    if (numbersTriangle.OrderBy(x => x).Take(2).Sum() > numbersTriangle.Max())
    {
        Console.WriteLine("Można zbudować trójkąt");
    }
    else
    {
        Console.WriteLine("Nie można zbudować trójkąta");
    }
}

// 11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
// Ocena Opis
// 6 Celujący
// 5 Bardzo dobry
// 4 Dobry
// 3 Dostateczny
// 2 Dopuszczający
// 1 Niedostateczny
// Dane testowe : 3
// Rezultat w terminalu :
// Dostateczny

Console.Write("Podaj ocenę w formie cyfry: ");
if (int.TryParse(Console.ReadLine(), out int numberGrade))
{
    string grade = numberGrade switch
    {
        6 => "Celujący",
        5 => "Bardzo dobry",
        4 => "Dobry",
        3 => "Dostateczny",
        2 => "Dopuszczający",
        1 => "Niedostateczny",
        _ => "Błędne dane"
    };

    Console.WriteLine(grade);
}

// 12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
// nazwę
// Dane testowe : 4
// Rezultat w terminalu :
// Czwartek

Console.Write("Podaj numer dnia tygodnia: ");
if (int.TryParse(Console.ReadLine(), out int numberDay))
{
    string day = numberGrade switch
    {
        1 => "Poniedziałek",
        2 => "Wtorek",
        3 => "Środa",
        4 => "Czwartek",
        5 => "Piątek",
        6 => "Sobota",
        7 => "Niedziela",
        _ => "Tydzień nie ma aż tylu dni!"
    };

    Console.WriteLine(day);
}

// 13.Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
// będzie prostym kalkulatorem
// Podaj pierwszą liczbę:
// …
// Podaj drugą liczbę:
// …
// Podaj numer operacji do wykonania:
// 1.Dodawanie
// 2.Odejmowanie
// 3.Mnożenie
// 4.Dzielenie
// …
// Twój wynik to:

Console.Write("Witaj w kalkulatorze!");
int numberCalculator1;
do
{
    Console.WriteLine("Podaj pierwszą liczbę: ");
}
while (!int.TryParse(Console.ReadLine(), out numberCalculator1));
int numberCalculator2;
do
{
    Console.WriteLine("Podaj drugą liczbę: ");
}
while (!int.TryParse(Console.ReadLine(), out numberCalculator2));
Console.WriteLine("Wybierz działanie wpisując liczbę z poniższego menu!");
Console.WriteLine(" 1.Dodawanie");
Console.WriteLine(" 2.Odejmowanie");
Console.WriteLine(" 3.Mnożenie");
Console.WriteLine(" 4.Dzielenie");
int.TryParse(Console.ReadLine(), out int numberCalculatorChosenOption);
int calculatorResult = 0;
bool calculationsComplete = false;
switch (numberCalculatorChosenOption)
{
    case 1:
        calculatorResult = numberCalculator1 + numberCalculator2;
        calculationsComplete = true;
        break;

    case 2:
        calculatorResult = numberCalculator1 - numberCalculator2;
        calculationsComplete = true;
        break;

    case 3:
        calculatorResult = numberCalculator1 * numberCalculator2;
        calculationsComplete = true;
        break;

    case 4:
        if (numberCalculator2 != 0)
        {
            calculatorResult = numberCalculator1 / numberCalculator2;
            calculationsComplete = true;
        }
        else
        {
            Console.WriteLine("Nie można dzielić przez 0!");
        }

        break;

    default:
        Console.WriteLine("Wybrano błędną operację...");
        break;
}
if (calculationsComplete)
{
    Console.WriteLine($"Twój wynik to {calculatorResult}");
}