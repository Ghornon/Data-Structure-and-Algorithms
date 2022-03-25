using System;
using ClassLibrary;

namespace Data_Structure_and_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // dhelta > 0
            Console.WriteLine(new CubicEquation(1, 2, 3, 4));

            // dhelta < 0
            Console.WriteLine(new CubicEquation(2, 9, 13, 6));
            Console.WriteLine(new CubicEquation(1, -5, -2, 24));

            // dhelta == 0
            Console.WriteLine(new CubicEquation(1, 0, 0, 0));

            Console.WriteLine(new CubicEquation(0, 2, 3, 4));
        }
    }
}
