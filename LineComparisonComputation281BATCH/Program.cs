using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program!");

        // Prompt the user to enter coordinates
        Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        double length = CalculateLineLength(x1, y1, x2, y2);

        Console.WriteLine("The Length of Line is: " + length);
    }

    private static double CalculateLineLength(int x1, int y1, int x2, int y2)
    {
        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return length;
    }
}

