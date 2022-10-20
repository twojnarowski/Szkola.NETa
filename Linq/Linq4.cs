 LINQ Challange #4
Kontynuujemy zabawy na stringach, ale wpleciemy trochę liczb 🙂

Mamy podany string, np.:
var myString = "Hello World!";

Zadanie polega na zwróceniu wszystkich znaków (w formie słownika) wraz z ilością ich wystąpień, czyli w powyższym przykładzie będzie to:
[H, 1]
[e, 1]
[l, 3]
[o, 2]
[ , 1]
[W, 1]
[r, 1]
[d, 1]
[!, 1]

Zakładamy, że do funkcji zawsze zostanie przekazany niepusty string. Spacje - jak widać powyżej - i inne znaki specjalne, też liczymy.

Do wyzwania przyjmijcie tę - jakże piękną - łacińską sentencję:
var str = "Pecunia non olet";

Szablon na szybki start:
private static Dictionary<char, int> CountCharacters(string str)
    {
        return str.Distinct().ToDictionary(x => x.ToString(), x => str.Count(y => x == y));
    }


Enjoy 🙂