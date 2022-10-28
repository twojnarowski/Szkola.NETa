namespace Algorytm10
{
    internal static class Program
    {
        private static readonly char _dot = '.';
        private static readonly char _x = 'x';
        private static readonly char _Q = 'Q';

        public static void Main()
        {
            char[,] chessBoard = GenerateChessBoard();
            PrintChessBoard(chessBoard);
            (int queenPositionX, int queenPositionY) = GetPositionFromUser();
            chessBoard = MarkUnsafePostions(chessBoard, queenPositionX, queenPositionY);
            PrintChessBoard(chessBoard);
            GetSafePositions(chessBoard);
        }

        public static char[,] GenerateChessBoard()
        {
            char[,] chessBoard = new char[8, 8];
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    chessBoard[i, j] = _dot;
                }
            }

            return chessBoard;
        }

        public static (int, int) GetPositionFromUser()
        {
            int queenPositionX;
            int queenPositionY;
            do
            {
                queenPositionX = -1;
                queenPositionY = -1;
                Console.WriteLine("Podaj pozycję królowej w zapisie szachowym (np. a1):");
                string queenPositionInput = Console.ReadLine() ?? string.Empty;
                if (queenPositionInput.Length >= 2)
                {
                    char yTemp = queenPositionInput[0];
                    char xTemp = queenPositionInput[1];
                    queenPositionY = char.ToLower(yTemp) switch
                    {
                        'a' => 0,
                        'b' => 1,
                        'c' => 2,
                        'd' => 3,
                        'e' => 4,
                        'f' => 5,
                        'g' => 6,
                        'h' => 7,
                        _ => -1,
                    };
                    if (char.IsDigit(xTemp))
                    {
                        queenPositionX = 8 - Convert.ToInt32(xTemp.ToString());
                    }
                }
            }
            while (queenPositionX is < 0 or > 7 || queenPositionY is < 0 or > 7);

            return (queenPositionX, queenPositionY);
        }

        public static char[,] SetQueen(char[,] chessBoard, int x, int y)
        {
            chessBoard[x, y] = _Q;
            return chessBoard;
        }

        private static char[,] MarkUnsafePostions(char[,] chessBoard, int queenPositionX, int queenPositionY)
        {
            for (int i = 0; i < 8; i++)
            {
                chessBoard[queenPositionX, i] = _x;
                chessBoard[i, queenPositionY] = _x;

                if (queenPositionX + i < 8 && queenPositionY + i < 8)
                {
                    chessBoard[queenPositionX + i, queenPositionY + i] = _x;
                }

                if (queenPositionX - i >= 0 && queenPositionY - i >= 0)
                {
                    chessBoard[queenPositionX - i, queenPositionY - i] = _x;
                }

                if (queenPositionX - i >= 0 && queenPositionY + i < 8)
                {
                    chessBoard[queenPositionX - i, queenPositionY + i] = _x;
                }

                if (queenPositionX + i < 8 && queenPositionY - i >= 0)
                {
                    chessBoard[queenPositionX + i, queenPositionY - i] = _x;
                }
            }

            chessBoard = SetQueen(chessBoard, queenPositionX, queenPositionY);

            return chessBoard;
        }

        private static void PrintChessBoard(char[,] chessBoard)
        {
            Console.WriteLine("== Szachownica ==");
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    Console.Write($"{chessBoard[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        private static void GetSafePositions(char[,] chessBoard)
        {
            Console.WriteLine("Znalezione bezpieczne pozycje: ");

            List<string> safePositions = new ();
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    if (chessBoard[i, j] == _dot)
                    {
                        string letter = j switch
                        {
                            0 => "a",
                            1 => "b",
                            2 => "c",
                            3 => "d",
                            4 => "e",
                            5 => "f",
                            6 => "g",
                            7 => "h",
                            _ => " ",
                        };
                        safePositions.Add($"[{letter}{8 - i}]");
                    }
                }
            }

            foreach (string str in safePositions.OrderBy(x => x))
            {
                Console.Write(str);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}