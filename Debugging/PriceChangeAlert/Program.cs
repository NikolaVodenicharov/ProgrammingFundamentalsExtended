using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfUpdatePrice = int.Parse(Console.ReadLine());

        double significanceThreshold = double.Parse(Console.ReadLine());

        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfUpdatePrice - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double percentOfDifferance = DifferanceInPercent(previousPrice, currentPrice);
            bool isSignificantDifference = isDiffSingnificant(percentOfDifferance, significanceThreshold);

            string message = Get(currentPrice, previousPrice, percentOfDifferance, isSignificantDifference);
            Console.WriteLine(message);

            previousPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double previousPrice, double differance, bool isSignificantDifference)
    {
        string message = string.Empty;
        if (differance == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, differance);
        }
        else if (isSignificantDifference && (differance > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, differance);
        }
        else if (isSignificantDifference && (differance < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, differance);
        return message;
    }
    private static bool isDiffSingnificant(double differance, double significanceThreshold)
    {
        if (Math.Abs(differance) >= significanceThreshold * 100)
        {
            return true;
        }
        return false;
    }

    private static double DifferanceInPercent(double previousPrice, double currentPrice)
    {
        double changePercent = (currentPrice - previousPrice) / previousPrice * 100;
        return changePercent;
    }
}
