using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        var readPoint1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var firstPoint = new Point(readPoint1[0], readPoint1[1]);

        var readPoint2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var secondPoint = new Point(readPoint2[0], readPoint2[1]);

        var distance = Point.CalculateDistance(firstPoint, secondPoint);
        Console.WriteLine($"{distance:f3}");
    }
}

public class Point
{
    public double x;
    public double y;

    public Point (double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static double CalculateDistance (Point p1, Point p2)
    {
        var sideA = Math.Abs(p1.x - p2.x);
        var sideB = Math.Abs(p1.y - p2.y);
        var distance = Math.Sqrt(sideA * sideA + sideB * sideB);

        return distance;
    }
}

