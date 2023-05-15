using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program!");

        // Line 1
        Console.WriteLine("Enter the coordinates of the first point of Line 1 (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point of Line 1 (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double length1 = CalculateLineLength(x1, y1, x2, y2);

        // Line 2
        Console.WriteLine("Enter the coordinates of the first point of Line 2 (a1, b1):");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point of Line 2 (a2, b2):");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());

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

