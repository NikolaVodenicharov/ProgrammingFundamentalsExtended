using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] inputText = File.ReadAllLines("../../Input.txt"); // by default the console search file in ../bin/Debug, so we go up 2 levels

        //File.WriteAllLines("../../Output.txt", inputText);
        File.AppendAllLines("../../Output.txt", inputText);     // if doesnt exist, created it and add some information.
        File.Create("../../createdFile.txt");
        //File.Delete("../../createdFile.txt");
        //File.Copy()
        Console.WriteLine(File.Exists("../../Output.txt"));

        FileInfo file = new FileInfo("../../Input.txt");

        Console.WriteLine(file.Name);
        Console.WriteLine(file.CreationTime);

        Directory.CreateDirectory("../../DeleteThatFolder");
    }
}

