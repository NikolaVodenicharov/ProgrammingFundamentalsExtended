using System;
using System.IO;

class oddLinesExecution
{
    static void Main()
    {
        string[] inputText = File.ReadAllLines("../../../Resources/01. Odd Lines/Input.txt");

        for (int i = 0; i < inputText.Length; i++)
        {
            if (i % 2 == 1)
            {
                File.AppendAllText("../../../Resources/01. Odd Lines/Output.txt", inputText[i] + Environment.NewLine);
            }
        }
    }
}

