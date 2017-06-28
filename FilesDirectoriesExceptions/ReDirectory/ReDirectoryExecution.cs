using System;
using System.IO;
using System.Collections.Generic;

class ReDirectoryExecution
{
    static void Main()
    {
        string sourcePath = "../../../Exercises-Resource/04. Re-Directory/input";
        string targetPathBase = "../../../Exercises-Resource/04. Re-Directory/Output";
        string[] filesNames = Directory.GetFiles(sourcePath);
        var extensions = new HashSet<string>();

        foreach (var file in filesNames)
        {
            var info = new FileInfo(file);
            string extension = (info.Extension).ToString().Remove(0, 1);

            string fileName = info.Name;
            string targetPath = Path.Combine(targetPathBase, extension +"s");

            if (!extensions.Contains(extension))
            {
                extensions.Add(extension);
                Directory.CreateDirectory(targetPath);
            }

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            File.Move(sourceFile, destFile);
        }


    }
}