using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program!");
        double x1 = 2;
        double y1 = 3;
        double x2 = 4;
        double y2 = 5;

        double length = CalculateLineLength(x1, y1, x2, y2);

        Console.WriteLine("The Length of Line is:" + length);
    }

    private static double CalculateLineLength(double x1, double y1, double x2, double y2)
    {
        double length = (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return length;
    }
}
