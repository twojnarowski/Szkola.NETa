//1

string firstName;
string lastName;
int age;
char sex;
string pesel;
int workerNumber;

//2

char char1 = 'a';
char char2 = 'b';
char char3 = 'c';
Console.WriteLine($"{char3} {char2} {char1}");

//3

double width;
double height;

if (double.TryParse(Console.ReadLine(), out width) && double.TryParse(Console.ReadLine(), out height))
{
    double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
}

//4

int a = 10;
string b = "Szkoła Dotneta";
double c = 12.5;

//5

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
int.TryParse(Console.ReadLine(), out workerNumber);
Console.WriteLine("Podaj swój numer telefonu:");
string phoneNumber = Console.ReadLine();
Console.WriteLine("Podaj swój adres email:");
string emailAddress = Console.ReadLine();
Console.WriteLine("Podaj swój wzrost w metrach:");
double.TryParse(Console.ReadLine(), out double personHeight);
Console.WriteLine("Podaj swoją wagę w kilogramach:");
double.TryParse(Console.ReadLine(), out double personWeight);