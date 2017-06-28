using System;
using System.IO;

class FilterExtensionsExecution
{
    static void Main()
    {
        string searchedExtensionType = "." + Console.ReadLine();

        string[] fileNames = Directory.GetFiles("../../../Exercises-Resource/01. Filter-Extensions/input");

        foreach (var file in fileNames)
        {
            FileInfo info = new FileInfo(file);
            if (info.Extension.Equals(searchedExtensionType))
            {
                Console.WriteLine(info.Name);
            }
        }
    }
}