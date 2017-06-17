using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] upgArray = new int?[4];
            int busyPositionInUpgArray = 0;

            while (true)
            {
                string[] inputInfo = Console.ReadLine().Split(' ');

                string command = inputInfo[0];

                int num = AddValue(inputInfo);

                if (command.Equals("push"))
                {
                    upgArray = ResizeArrayWhenItsFull(upgArray, busyPositionInUpgArray);
                    AddValueToEndOfArray(upgArray, busyPositionInUpgArray, num);

                    busyPositionInUpgArray++;
                }
                else if (command.Equals("clear"))
                {
                    Array.Clear(upgArray, 0, busyPositionInUpgArray);
                    busyPositionInUpgArray = 0;
                }
                else if (command.Equals("removeAt"))
                {
                    CopyValueToNewPosition(upgArray, busyPositionInUpgArray, num);
                    NulledLastBusyPosition(upgArray, busyPositionInUpgArray);

                    busyPositionInUpgArray--;
                }
                else if (command.Equals("pop"))
                {
                    NulledLastBusyPosition(upgArray, busyPositionInUpgArray);

                    busyPositionInUpgArray--;
                }
                else if (command.Equals("end"))
                {
                    break;
                }
            }

            PrintAnswer(upgArray);
        }

        private static int AddValue(string[] inputInfo)
        {
            int num = 0;
            if (inputInfo.Length == 2)
            {
                num = int.Parse(inputInfo[1]);
            }

            return num;
        }

        private static void AddValueToEndOfArray(int?[] upgArray, int busyPositionInUpgArray, int num)
        {
            upgArray[busyPositionInUpgArray] = num; // if there are 2 busy position. index 2 is the first with null
        }

        private static void NulledLastBusyPosition(int?[] upgArray, int busyPositionInUpgArray)
        {
            upgArray[busyPositionInUpgArray - 1] = null;
        }

        private static int?[] ResizeArrayWhenItsFull(int?[] upgArray, int busyPositionInUpgArray)
        {
            if (upgArray.Length == busyPositionInUpgArray)
            {
                Array.Resize(ref upgArray, upgArray.Length * 2);
            }

            return upgArray;
        }

        private static void CopyValueToNewPosition(int?[] upgArray, int busyPositionInUpgArray, int num)
        {
            for (int i = num; i < busyPositionInUpgArray - 1; i++)
            {
                upgArray[i] = upgArray[i + 1];
            }
        }

        private static void PrintAnswer(int?[] upgArray)
        {
            if (upgArray[0] == null)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(String.Join(" ", upgArray));
            }
        }
    }
}
