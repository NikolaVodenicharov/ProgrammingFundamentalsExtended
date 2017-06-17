using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Sale
{
    public string town;
    public string product;
    public double price;
    public double quantity;

    public Sale(string town, string product, double price, double quantity)
    {
        this.town = town;
        this.product = product;
        this.price = price;
        this.quantity = quantity;
    }
}

class SalesReport
{
    static void Main()
    {
        var sales = new List<Sale>();
        ReadFromConsoleAddToSales(sales);

        var townSales = new SortedDictionary<string, double>();
        AddInfoToTownSales(sales, townSales);

        PrintAnswer(townSales);

    }

    private static void AddInfoToTownSales(List<Sale> sales, SortedDictionary<string, double> townSales)
    {
        foreach (var sale in sales)
        {
            if (!townSales.ContainsKey(sale.town))
            {
                townSales.Add(sale.town, new double());
            }
            townSales[sale.town] += sale.quantity * sale.price;
        }
    }

    private static void PrintAnswer(SortedDictionary<string, double> townSales)
    {

        var answer = new StringBuilder();
        foreach (var pair in townSales)
        {
            answer.AppendLine($"{pair.Key} -> {pair.Value:f2}");
        }

        Console.WriteLine(answer);
    }

    private static void ReadFromConsoleAddToSales(List<Sale> sales)
    {
        var numberOfInputSales = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInputSales; i++)
        {
            var inputLine = Console.ReadLine().Split().ToArray();
            //var town = inputLine[0];
            //var product = inputLine[1];
            //var price = double.Parse(inputLine[2]);
            //var quantity = double.Parse(inputLine[3]);

            var inputSale = new Sale( inputLine[0]
                                    , inputLine[1]
                                    , double.Parse(inputLine[2])
                                    , double.Parse(inputLine[3]));
            sales.Add(inputSale);
        }
    }
}


