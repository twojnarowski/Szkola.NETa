/*LINQ Challange #2
Pobawimy się jeszcze liczbami 🙂 Będziemy szukać dzielników 🔍 
Mamy podaną liczbę całkowitą n.
Należy zwrócić ilość liczb z zakresu od 1 do n, które dzielą liczbę n bez reszty 🙂

var input = 16;
Oczekiwany rezultat:
5 -> (1, 2, 4, 8, 16)
Szablon na szybki start:*/

private static int Dividers(int input)
    {
        return Enumerable.Range(1, input).Where(x => input%x == 0).Count();
    }
    
/*Zwracamy ilość! 
Enjoy 🙂*/