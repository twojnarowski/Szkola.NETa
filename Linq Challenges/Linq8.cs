/*LINQ Challange #8
Gdy się dotNetowiec nudzi... to rozwiązuje zadania z LINQ (tak, wiem... słabe XD).

Mamy tablicę liczb całkowitych:
[16, -9, 4, 23, 0, 15, 3]

Zadanie polega na tym, by zwrócić te elementy tablicy, które są wielokrotnością numeru indeksu w tablicy wejściowej.

Elementy należy zwrócić w formie tablicy.

Z powyższej tablicy powinniśmy otrzymać wynik:
[-9, 4, 0, 15]

Szablon do uzupełnienia:*/

private static int[] MultipleOfIndex(int[] array)
{
    return array[1..].Where(x => x % Array.IndexOf(array, x) == 0);
}

/*Uwaga
1. Pamiętajcie, że nie dzielimy przez zero 😉
2. Zero (jako element) uwzględniamy - jest to zerowa wielokrotność numeru indeksu XD

Enjoy 🙂 */