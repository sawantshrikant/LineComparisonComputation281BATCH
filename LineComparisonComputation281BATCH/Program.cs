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

        Line line1 = new Line(x1, y1, x2, y2);

        // Line 2
        Console.WriteLine("Enter the coordinates of the first point of Line 2 (a1, b1):");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of the second point of Line 2 (a2, b2):");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());

        Line line2 = new Line(a1, b1, a2, b2);

        double length1 = line1.CalculateLength();
        double length2 = line2.CalculateLength();

        Console.WriteLine("The Length of Line 1 is: " + length1);
        Console.WriteLine("The Length of Line 2 is: " + length2);

        // Compare line lengths
        if (length1 > length2)
        {
            Console.WriteLine("Line 1 is greater than Line 2.");
        }
        else if (length1 < length2)
        {
            Console.WriteLine("Line 1 is less than Line 2.");
        }
        else
        {
            Console.WriteLine("Line 1 is equal to Line 2.");
        }
    }
}




