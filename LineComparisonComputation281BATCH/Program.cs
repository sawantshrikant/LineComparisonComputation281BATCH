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

        double length1 = CalculateLineLength(x1, y1, x2, y2);

        double a1 = 1;
        double b1 = 2;
        double a2 = 5;
        double b2 = 7;

        double length2 = CalculateLineLength(a1, b1, a2, b2);

        Console.WriteLine("The Length of Line 1 is: " + length1);
        Console.WriteLine("The Length of Line 2 is: " + length2);

        // Check equality using the equals method
        bool areEqual = length1.Equals(length2);
        Console.WriteLine("Are the lines equal? " + areEqual);
    }

    private static double CalculateLineLength(double x1, double y1, double x2, double y2)
    {
        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return length;
    }
}
