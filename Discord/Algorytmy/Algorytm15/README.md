[algorytm#15]

Przy podanych 3 liczbach od 0 do 255, które odpowiadają kolorom czerwonemu, zielonemu i niebieskiemu przekształć wartości na wartość HEX dla tego koloru.
Możesz użyć dowolnych (nawet wbudowanych w język) sposobów na zamianę. Możesz również zrobić to manualnie.

Przykłady
hexcolor(255, 99, 71) => "#FF6347"  (Tomato)
hexcolor(184, 134, 11) => "#B8860B"  (DarkGoldenrod)
hexcolor(189, 183, 107) => "#BDB76B"  (DarkKhaki)
hexcolor(0, 0, 205) => "#0000CD"  (MediumBlue)

Dodatkowa opcja: blendowanie kolorów

Przy podanych dwóch HEXach, zwróć nowy kolor na podstawie uśrednienia ich wartości RGB.

blend({"#000000", "#778899"}) => "#3C444C"
blend({"#E6E6FA", "#FF69B4", "#B0C4DE"}) => "#DCB1D9"
