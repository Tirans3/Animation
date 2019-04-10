using System;

namespace ConsoleAnimation
{
    class MatrixAnimation
    {
        readonly char b = '*';
        readonly int m = Console.CursorLeft;
        readonly int n = Console.CursorTop;
                 int y = 0;
                 int z = 0;
        readonly char[,] A = new char[15, 100];

        void View_1(char[,] c)
        {
            c[5, 3 + y] = b; c[5, 4 + y] = b; c[5, 5 + y] = b;
            c[6, 3 + y] = b; c[6, 5 + y] = b;
            c[7, 3 + y] = b; c[7, 4 + y] = b; c[7, 5 + y] = b;
            c[8, 4 + y] = b;
            c[9, 4 + y] = b;
            c[10, 2 + y] = b; c[10, 3 + y] = b; c[10, 4 + y] = b; c[10, 5 + y] = b; c[10, 6 + y] = b;
            c[11, 4 + y] = b;
            c[12, 4 + y] = b;
            c[13, 3 + y] = b; c[13, 5 + y] = b;
            c[14, 2 + y] = b; c[14, 6 + y] = b;
            y += 2;

            Console.SetCursorPosition(m, n);

        }

        void View_2(char[,] c)
        {

            try
            {
                c[5, 5 + z] = b; c[5, 6 + z] = b; c[5, 7 + z] = b;
                c[6, 5 + z] = b; c[6, 7 + z] = b;
                c[7, 5 + z] = b; c[7, 6 + z] = b; c[7, 7 + z] = b;
                c[8, 6 + z] = b;
                c[9, 6 + z] = b; c[9, 8 + z] = b;
                c[10, 4 + z] = b; c[10, 5 + z] = b; c[10, 6 + z] = b; c[10, 7 + z] = b;
                c[11, 6 + z] = b;
                c[12, 6 + z] = b;
                c[13, 5 + z] = b; c[13, 7 + z] = b; c[13, 8 + z] = b;
                c[14, 4 + z] = b;
                z += 2;

                Console.SetCursorPosition(m, n);

            }
            catch (Exception)
            {
                y = 0;
                z = 0;

            }
        }
    }
}
