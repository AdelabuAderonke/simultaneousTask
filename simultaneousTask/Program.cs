using System;

namespace simultaneousTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Coefficient of X for the first equation");
                double valueX1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Coefficient of Y for the first equation");
                double valueY1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the total of the first equation");
                double total1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Coefficient of X for the second equation");
                double valueX2 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Coefficient of Y for the second equation");
                double valueY2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the total of the second equation");

                double total2 = Double.Parse(Console.ReadLine());
                double Ycoefficient = (valueY1 * valueX2) - (valueY2 * valueX1);
                double newTotal = (total1 * valueX2) - (total2 * valueX1);
                double finalYvalue = Math.Floor(newTotal / Ycoefficient);
                double newTotal2 = total1 - (valueY1 * finalYvalue);
                double finalXvalue = Math.Floor(newTotal2 / valueX1);
                Console.WriteLine(" Y =" + finalYvalue);
                Console.WriteLine(" X = " + finalXvalue);
            }

            catch (FormatException e)
            {
                Console.WriteLine($"please enter a valid number:{e.Message}");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"Out of range:{e.Message}");
            }

        }
    }
}
