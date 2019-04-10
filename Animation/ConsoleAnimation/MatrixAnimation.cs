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

        void View_1()
        {
            A[5, 3 + y] = b; A[5, 4 + y] = b; A[5, 5 + y] = b;
            A[6, 3 + y] = b; A[6, 5 + y] = b;
            A[7, 3 + y] = b; A[7, 4 + y] = b; A[7, 5 + y] = b;
            A[8, 4 + y] = b;
            A[9, 4 + y] = b;
            A[10, 2 + y] = b; A[10, 3 + y] = b; A[10, 4 + y] = b; A[10, 5 + y] = b; A[10, 6 + y] = b;
            A[11, 4 + y] = b;
            A[12, 4 + y] = b;
            A[13, 3 + y] = b; A[13, 5 + y] = b;
            A[14, 2 + y] = b; A[14, 6 + y] = b;
            y += 2;

            Console.SetCursorPosition(m, n);

        }

        void View_2()
        {

            try
            {
                A[5, 5 + z] = b; A[5, 6 + z] = b; A[5, 7 + z] = b;
                A[6, 5 + z] = b; A[6, 7 + z] = b;
                A[7, 5 + z] = b; A[7, 6 + z] = b; A[7, 7 + z] = b;
                A[8, 6 + z] = b;
                A[9, 6 + z] = b; A[9, 8 + z] = b;
                A[10, 4 + z] = b; A[10, 5 + z] = b; A[10, 6 + z] = b; A[10, 7 + z] = b;
                A[11, 6 + z] = b;
                A[12, 6 + z] = b;
                A[13, 5 + z] = b; A[13, 7 + z] = b; A[13, 8 + z] = b;
                A[14, 4 + z] = b;
                z += 2;

                Console.SetCursorPosition(m, n);

            }
            catch (Exception)
            {
                y = 0;
                z = 0;

            }
        }

        void Show()
        {

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(A[i, j]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(m, n);
        }
        void ShowEmpty()
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = ' ';

                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(m, n);
        }

        public void Showmatrix(object o)
        {

            View_1();
            for (int i = 0; i < 3; i++) { Show(); }
            ShowEmpty();
            View_2();
            Show();
            ShowEmpty();

        }
    }
}
