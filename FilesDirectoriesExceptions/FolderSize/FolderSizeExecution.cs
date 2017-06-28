using System;
using System.IO;

class FolderSizeExecution
{
    static void Main()
    {
        string[] fileNames = Directory.GetFiles("../../../Resources/05. Folder Size/TestFolder");

        double filesSize = 0;

        foreach (var file in fileNames)
        {
            FileInfo info = new FileInfo(file);
            filesSize += info.Length;
        }

        Console.WriteLine(filesSize / 1024 / 1024);
    }
}