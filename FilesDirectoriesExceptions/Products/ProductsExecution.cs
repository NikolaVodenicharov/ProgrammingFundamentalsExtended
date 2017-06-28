using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class ProductsExecution
{
    static void Main()
    {
        var products = new HashSet<Product>();
        AddProductsFromPreviousSession(products);

        while (true)
        {
            var input = Console.ReadLine().Split();

            if (input[0].Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (input[0].Equals("stock", StringComparison.OrdinalIgnoreCase))
            {
                StockProducts(products);
            }
            else if (input[0].Equals("sales", StringComparison.OrdinalIgnoreCase))
            {
                PrintIncomeIfProducsAreSaled(products);
            }
            else if (input[0].Equals("analyze", StringComparison.OrdinalIgnoreCase))
            {
                AnalyzeProducts(products);
            }
            else
            {
                StoreInputProduct(products, input);
            }
        }
    }

    private static void AnalyzeProducts(HashSet<Product> products)
    {
        foreach (var product in products.OrderBy(x => x.type))
        {
            Console.WriteLine($"{product.type}, Product: {product.name}"
                              + Environment.NewLine
                              + $" Price: ${product.price}, Amount Left: {product.quantity}");
        }
    }

    private static void AddProductsFromPreviousSession(HashSet<Product> products)
    {
        if (File.Exists("storedProducts.txt"))
        {
            string[] loadingStoredProducts = File.ReadAllLines("storedProducts.txt");

            foreach (var line in loadingStoredProducts)
            {
                string[] input = line.Split();

                StoreInputProduct(products, input);
            }
        }
    }

    private static void PrintIncomeIfProducsAreSaled(HashSet<Product> products)
    {

        var incomeByType = new Dictionary<string, double>();

        foreach (var product in products)
        {
            if (!incomeByType.ContainsKey(product.type))
            {
                incomeByType.Add(product.type, 0.0);
            }

            incomeByType[product.type] += product.price * product.quantity;
        }

        foreach (var pair in incomeByType.OrderByDescending(x => x.Value)
                                         .ToDictionary(x => x.Key, x => x.Value))
        {
            Console.WriteLine($"{pair.Key}: ${pair.Value:f2}");
        }
    }

    private static void StockProducts(HashSet<Product> products)
    {
        File.Delete("storedProducts.txt");

        var forStoring = new List<string>();
        foreach (var product in products)
        {
            forStoring.Add(product.ToString());
        }
        File.WriteAllLines("storedProducts.txt", forStoring);
    }

    private static void StoreInputProduct(HashSet<Product> products, string[] input)
    {
        /*
        string name = input[0];
        string type = input[1];
        double price = double.Parse(input[2]);
        int quantity = int.Parse(input[3]);
        */

        if (products.Any(x => x.name == input[0] & x.type == input[1]))
        {
            var productForUpdate = products.SingleOrDefault(x => x.name == input[0] & x.type == input[1]); //repeated code
            productForUpdate.price = double.Parse(input[2]);
            productForUpdate.quantity = int.Parse(input[3]);
        }
        else
        {
            products.Add(new Product(input[0],
                                     input[1],
                                     double.Parse(input[2]),
                                     int.Parse(input[3])));
        }
    }
}
