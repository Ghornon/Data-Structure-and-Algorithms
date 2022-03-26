using System;
using ClassLibrary;

namespace Data_Structure_and_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char[] arguments = { 'a', 'b', 'c', 'd' };
                double[] values = new double[4];
                
                for (int i = 0; i < arguments.Length; i++)
                {
                    Console.Write($"Enter {arguments[i]}: ");
                    string line = Console.ReadLine();
                    values[i] = double.Parse(line);
                }

                var equation = new CubicEquation(values[0], values[1], values[2], values[3]);

                Console.WriteLine(equation);

            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
