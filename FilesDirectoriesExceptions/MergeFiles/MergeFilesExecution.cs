using System;
using System.IO;
using System.Collections.Generic;

class MergeFilesExecution
{
    static void Main()
    {
        string[] inputText1 = File.ReadAllLines("../../../Resources/04. Merge Files/FileOne.txt");
        string[] inputText2 = File.ReadAllLines("../../../Resources/04. Merge Files/FileTwo.txt");

        List<string> mergedText = new List<string>();

        for (int i = 0; i < inputText1.Length; i++)
        {
            mergedText.Add(inputText1[i]);
            mergedText.Add(inputText2[i]);
        }

        File.AppendAllLines("../../../MergeFiles/Output.txt", mergedText);
    }
}
