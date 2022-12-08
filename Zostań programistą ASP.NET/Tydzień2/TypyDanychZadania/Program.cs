// 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
// które chcesz przetrzymywać to:
// a. Imię,
// b. Nazwisko
// c. Wiek
// d. Płeć (‘m’ albo ‘k’)
// e. PESEL
// f. Numer pracownika (np. 2509324094)
// Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

string firstName;
string lastName;
int age;
char sex;
string pesel;
string workerNumber;

// 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
// odwrotnej kolejności niż zostały zadeklarowane

char char1 = 'a';
char char2 = 'b';
char char3 = 'c';
Console.WriteLine($"{char3} {char2} {char1}");

// 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
// przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

double width = 0d;
double height = 0d;

Console.Write("Proszę podać wysokość prostokąta: ");
double.TryParse(Console.ReadLine(), out height)
Console.Write("Proszę podać szerokość prostokąta: ");
double.TryParse(Console.ReadLine(), out width)
    
if ( width > 0 && height > 0 )
{
    double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
    Console.WriteLine($"Długość przekątnej: {diagonal}");
}
else
{
    Console.WriteLine("Błedne dane!");   
}

// 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
// przypiszesz im następujące wartości:
// a. 10
// b. Szkoła Dotneta
// c. 12,5
// Pamiętaj o użyciu poprawnych typów danych.

int a = 10;
string b = "Szkoła Dotneta";
double c = 12.5;

// 5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
// numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
// i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
// typDanych.Parse(odpowiedźOdUżytkownika)

Console.WriteLine("Podaj swoje imie:");
firstName = Console.ReadLine();
Console.WriteLine("Podaj swoje naziwsko:");
lastName = Console.ReadLine();
Console.WriteLine("Podaj swój wiek:");
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine("Podaj swoją płeć (M lub K):");
char.TryParse(Console.ReadLine(), out sex);
Console.WriteLine("Podaj swój PESEL:");
pesel = Console.ReadLine();
Console.WriteLine("Podaj swój numer pracowniczy:");
workerNumber = Console.ReadLine();
Console.WriteLine("Podaj swój numer telefonu:");
string phoneNumber = Console.ReadLine();
Console.WriteLine("Podaj swój adres email:");
string emailAddress = Console.ReadLine();
Console.WriteLine("Podaj swój wzrost w metrach:");
double.TryParse(Console.ReadLine(), out double personHeight);
Console.WriteLine("Podaj swoją wagę w kilogramach:");
double.TryParse(Console.ReadLine(), out double personWeight);
