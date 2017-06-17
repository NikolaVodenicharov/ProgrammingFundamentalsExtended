using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] targetCoordinate = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double targetPositionX = targetCoordinate[0];
            double targetPositionY = targetCoordinate[1];

            string[] shootingCoordinate = Console.ReadLine().Split(' ');
            double shootingPositionX = 0;
            double shootingPositionY = 0;

            for (int i = 0; i < shootingCoordinate.Length; i += 2)
            {
                string command = shootingCoordinate[i].ToLower();
                double number = double.Parse(shootingCoordinate[i + 1]);

                switch (command)
                {
                    case "up":
                        shootingPositionY += number;
                        break;
                    case "down":
                        shootingPositionY -= number;
                        break;
                    case "left":
                        shootingPositionX -= number;
                        break;
                    case "right":
                        shootingPositionX += number;
                        break;
                }
            }

            Console.WriteLine($"firing at [{shootingPositionX}, {shootingPositionY}]");
            if ((shootingPositionX == targetPositionX) && 
                (shootingPositionY == targetPositionY))
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
