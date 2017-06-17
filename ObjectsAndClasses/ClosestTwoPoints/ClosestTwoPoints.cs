using System;
using System.Linq;

class ClosestTwoPoints
{
    static void Main()
    {
        var numberOfInputPoints = int.Parse(Console.ReadLine());
        var points = new Point[numberOfInputPoints];

        for (int i = 0; i < numberOfInputPoints; i++)
        {
            var readPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();
            points[i] = new Point(readPoint[0], readPoint[1]);
        }

        var closestPoints = Point.CalculateClosestTwoPoints(points);
        var distanceClosestPoints = Point.CalculateDistance(closestPoints[0], closestPoints[1]);


        Console.WriteLine($"{distanceClosestPoints:f3}");
        Console.WriteLine(closestPoints[0]);
        Console.WriteLine(closestPoints[1]);

    }
}

public class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static Point[] CalculateClosestTwoPoints(Point[] points)
    {
        var closestPoints = new Point[2];
        closestPoints[0] = points[0];
        closestPoints[1] = points[1];
        var distanceClosestPoints = Point.CalculateDistance(closestPoints[0], closestPoints[1]);

        for (int position1 = 0; position1 < points.Length - 1; position1++)
        {
            for (int position2 = position1 + 1; position2 < points.Length; position2++)
            {
                var pointA = points[position1];
                var pointB = points[position2];
                var currentDistance = Point.CalculateDistance(pointA, pointB);
                if (currentDistance < distanceClosestPoints)
                {
                    closestPoints[0] = pointA;
                    closestPoints[1] = pointB;
                    distanceClosestPoints = currentDistance;
                }
            }
        }

        return closestPoints;
    }

    public static double CalculateDistance(Point p1, Point p2)
    {
        var sideA = Math.Abs(p1.x - p2.x);
        var sideB = Math.Abs(p1.y - p2.y);
        var distance = Math.Sqrt(sideA * sideA + sideB * sideB);

        return distance;
    }

    public override string ToString()
    {
        return $"({this.x}, {this.y})".ToString();
    }

}
