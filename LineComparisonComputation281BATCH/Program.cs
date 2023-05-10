public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Line Comparison Computation Program!");

        Line line1 = new Line(2, 3, 4, 5);
        Line line2 = new Line(1, 2, 5, 7);

        double length1 = line1.CalculateLength();
        double length2 = line2.CalculateLength();

        Console.WriteLine("The Length of Line 1 is: " + length1);
        Console.WriteLine("The Length of Line 2 is: " + length2);


        int comparisonResult = line1.CompareTo(line2);

        if (comparisonResult < 0)
        {
            Console.WriteLine("Line 1 is shorter than Line 2");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("Line 1 is longer than Line 2");
        }
        else
        {
            Console.WriteLine("Line 1 is equal in length to Line 2");
        }
    }
}





