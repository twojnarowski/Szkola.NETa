/*LINQ Challange #7
Dzisiaj na sportowo ⚽

W tablicy znaków mamy zapisane wyniki meczów naszej drużyny:
["1:0", "2:3", "0:2", "1:1", "4:2", "0:0", "1:2", "3:3", "4:1", "0:1", "2:2"]

Zadanie polega na policzeniu punktów, które nasza drużyna zdobyła.
Założenia:
1. Nasza drużyna zawsze grała jako gospodarz (punktacja z lewej strony ":").
2. Maksymalna ilość goli, które każda z drużyn mogła strzelić to 9.
3. Punktacja za mecz, jak w piłce nożnej:
a) A > B => 3pkt.
b) A == B => 1pkt.
c) A < B => 0pkt.

Z powyższej tablicy powinniśmy otrzymać wynik: 13

Szablon do uzupełnienia:*/

private static int PointsScored(string[] scoreboard)
    {
        return scoreboard.Select(x => x = x[0] > x[2] ? "3" : x[0] < x[2] ? "0" : "1").Sum(x => int.Parse(x)); 
    }

/*Enjoy 🙂 */
