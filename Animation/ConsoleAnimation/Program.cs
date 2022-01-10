using System;
using System.Threading;


namespace ConsoleAnimation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int a = 0;

            MatrixAnimation ff = new MatrixAnimation();


            Timer T = new Timer(ff.ShowAnimation, 0, a, 1000);

            Console.Write("Added from Folk");

            //Adding something new
            Console.ReadLine();
        }
    }
}
