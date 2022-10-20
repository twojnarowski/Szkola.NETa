/*LINQ Challange #3
Były liczby, teraz trochę zabawy na stringach 🙂

Na wejściu mamy dwie tablice.
tab1 = {"bal", "oko", "tak"}
tab2 = {"ptak", "talon", "kolej", "balon", "tartak", "robal"}

Zadanie, które musimy wykonać, to znaleźć wyrazy z pierwszej tablicy, które zawierają się w elementach drugiej tablicy.
Powinny zostać one zwrócone w posortowanej alfabetycznie tablicy. Dla powyższych założeń powinniśmy otrzymać:
["bal", "tak"]

Uwaga! Jeśli dany wyraz z tablicy #1 zawiera się w kilku wyrazach tablicy #2, zwracamy go tylko raz!

W związku z tym, że pisać kod powinno się w języku angielskim, to jako input do zadania przyjmijcie:
var array1 = {"shake", "stop", "will", "with", "code", "is", "you", "bull", "man", "bad", "strong", "runs"};
var array2 = {"badge", "drunker", "outruns", "layout", "withdrawn", "yourself", "sharp", "transparency", "romance", "life"};

Oczekiwany rezultat:
A nie napiszę, to będzie niespodzianka 🙂

Szablon na szybki start:*/

private static string[] InArray(string[] array1, string[] array2)
    {
        return array1.Where(x => array2.Any(y => y.Contains(x))).OrderBy(x => x).ToArray();
    }

/*Enjoy 🙂*/