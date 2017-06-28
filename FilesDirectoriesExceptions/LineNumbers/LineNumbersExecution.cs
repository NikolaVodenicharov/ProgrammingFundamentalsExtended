using System;
using System.IO;

class LineNumbersExecution
{
    static void Main()
    {
        string[] inputText = File.ReadAllLines("../../../Resources/02. Line Numbers/Input.txt");

        for (int i = 0; i < inputText.Length; i++)
        {
            File.AppendAllText("../../../Resources/02. Line Numbers/Output.txt", 
                               $"{i + 1}. " + 
                               inputText[i] + 
                               Environment.NewLine);
        }
    }
}

