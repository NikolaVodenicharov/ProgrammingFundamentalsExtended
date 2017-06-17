using System;
using System.Collections.Generic;
using System.Text;

public class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static double CalculateDistance(Point p1, Point p2)
    {
        var sideA = Math.Abs(p1.x - p2.x);
        var sideB = Math.Abs(p1.y - p2.y);
        var distance = Math.Sqrt(sideA * sideA + sideB * sideB);

        return distance;
    }
}

public class Box
{
    public Point upperLeft;
    public Point upperRight;
    public Point bottomLeft;
    public Point bottomRight;
    public double height
    {
        get { return Point.CalculateDistance(this.upperLeft, this.upperRight); }
    }
    public double width
    {
        get { return Point.CalculateDistance(this.upperLeft, this.bottomLeft); }
    }

    public Box (Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
    {
        this.upperLeft = upperLeft;
        this.upperRight = upperRight;
        this.bottomLeft = bottomLeft;
        this.bottomRight = bottomRight;
    }

    public double CalculatePerimeter ()
    {
        var perimeter = (this.height * 2 + this.width * 2);
        return perimeter;
    }

    public double CalculateArea()
    {
        var area = (this.width * this.height);
        return area;
    }
}

class BoxesExecution
{
    static void Main(string[] args)
    {
        var boxes = new List<Box>();

        while (true)
        {
            var inputInfo = Console.ReadLine();

            var isTimeToStopLoop = inputInfo.Equals("end", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToStopLoop)
            {
                break;
            }

            AddInputBoxToBoxes(boxes, inputInfo);
        }

        var answer = new StringBuilder();
        AddInfoToAnswer(boxes, answer);

        PrintAnswer(answer);
    }

    private static void PrintAnswer(StringBuilder answer)
    {
        Console.WriteLine(answer);
    }

    private static void AddInfoToAnswer(List<Box> boxes, StringBuilder answer)
    {
        foreach (var box in boxes)
        {
            answer.AppendLine($"Box: {box.width}, {box.height}");
            answer.AppendLine($"Perimeter: {box.CalculatePerimeter()}");
            answer.AppendLine($"Area: {box.CalculateArea()}");
        }
    }

    private static void AddInputBoxToBoxes(List<Box> boxes, string inputInfo)
    {
        var splitedInfo = inputInfo.Split(new char[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries);

        var inputBox = new Box(new Point(double.Parse(splitedInfo[0]), double.Parse(splitedInfo[1])),
                               new Point(double.Parse(splitedInfo[2]), double.Parse(splitedInfo[3])),
                               new Point(double.Parse(splitedInfo[4]), double.Parse(splitedInfo[5])),
                               new Point(double.Parse(splitedInfo[6]), double.Parse(splitedInfo[7])));
        boxes.Add(inputBox);
    }
}