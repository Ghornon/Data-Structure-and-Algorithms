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
                double[] values = new double[arguments.Length];

                Console.WriteLine($"Kalkulator równania sześcienne (trzeciego stopnia) – równanie algebraiczne postaci ax^3+bx^2+cx+d=0, przy a ≠ 0");

                for (int i = 0; i < arguments.Length; i++)
                {
                    Console.Write($"Podaj {arguments[i]}: ");
                    string line = Console.ReadLine();
                    values[i] = double.Parse(line);
                }

                var equation = new CubicEquation(values[0], values[1], values[2], values[3]);

                Console.WriteLine(equation);

            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                char[] arguments = { 'a', 'b', 'c', 'd', 'e' };
                double[] values = new double[arguments.Length];

                Console.WriteLine($"Kalkulator równania czwartego stopnia – równanie algebraiczne postaci ax4 + bx3 + cx2 + dx + h = 0, przy a ≠ 0.");

                for (int i = 0; i < arguments.Length; i++)
                {
                    Console.Write($"Podaj {arguments[i]}: ");
                    string line = Console.ReadLine();
                    values[i] = double.Parse(line);
                }

                new _4thDegreeEquation(values[0], values[1], values[2], values[3], values[4]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
