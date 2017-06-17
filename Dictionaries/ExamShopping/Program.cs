using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, int>();
            inventory = ReadFromConsoleAddToInventory(inventory);

            var forPrinting = new StringBuilder();

            // inventory = SellStocksFromInventory
            while (true)
            {
                var buyedStocks = Console.ReadLine().Split();

                if (buyedStocks[0].Equals("exam", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                var productName = buyedStocks[1];
                var productQuantity = int.Parse(buyedStocks[2]);

                if (inventory.ContainsKey(productName))
                {
                    if (inventory[productName] <= 0)
                    {
                        forPrinting.AppendLine($"{productName} out of stock");
                    }
                    else
                    {
                        inventory[productName] -= productQuantity;
                    }
                }
                else
                {
                    forPrinting.AppendLine($"{productName} doesn't exist");
                }
            }

            forPrinting = AddForPrintingRemainingInventory(inventory, forPrinting);
            PrintAnswer(forPrinting);
        }

        private static StringBuilder AddForPrintingRemainingInventory(Dictionary<string, int> inventory, StringBuilder forPrinting)
        {
            foreach (var stock in inventory)
            {
                if (stock.Value > 0)
                {
                    forPrinting.AppendLine($"{stock.Key} -> {stock.Value}");
                }
            }
            return forPrinting;
        }

        private static void PrintAnswer(StringBuilder forPrinting)
        {
            Console.WriteLine(forPrinting);
        }

        private static Dictionary<string, int> ReadFromConsoleAddToInventory(Dictionary<string, int> inventory)
        {
            while (true)
            {
                var inputStocks = Console.ReadLine().Split();

                if (inputStocks[0].Equals("shopping", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                var productName = inputStocks[1];
                var productQuantity = int.Parse(inputStocks[2]);
                if (!inventory.ContainsKey(productName))
                {
                    inventory.Add(productName, productQuantity);
                }
                else
                {
                    inventory[productName] += productQuantity;
                }
            }

            return inventory;
        }
    }
}
