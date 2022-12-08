/*LINQ Challange #6
Mam nadzieję, że jesienna szaruga nie wpływa na Was demotywująco do działania z LINQ 🙂

Dzisiaj troszkę policzymy. Mamy tablicę liczb całkowitych:
[7, 2, 12, 5, 3, 10, 4, 9]

Zadanie polega na zsumowaniu wszystkich liczb z pominięciem wartości największej i najmniejszej.
Z powyższej tablicy powinniśmy otrzymać wynik: 38

Uwaga!
Niedozwolone jest sortowanie 🙂

Szablon do uzupełnienia:*/

private static int Sum(int[] numbers)
{
    return numbers.Sum() - numbers.Min() - numbers.Max();
}

/*Enjoy 🙂 */
