using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class HTMLContentExecution
{
    static void Main()
    {
        string title = string.Empty;
        var tagContent = new List<string>();

        while (true)
        {
            var input = Console.ReadLine().Split();

            if (input[0].Equals("Exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (input[0].Equals("title", StringComparison.OrdinalIgnoreCase))
            {
                title = input[1];
            }
            else
            {
                tagContent.Add($"\t<{input[0]}>{input[1]}</{input[0]}>");
            }
        }

        var formatedInfo = new StringBuilder();
        formatedInfo.AppendLine("<!DOCTYPE html>");
        formatedInfo.AppendLine("<html>");
        formatedInfo.AppendLine("<head>");
        if (title != string.Empty)
        {
            formatedInfo.AppendLine($"\t<title>{title}</title>");
        }
        formatedInfo.AppendLine("</head>");
        formatedInfo.AppendLine("<body>");
        if (tagContent.Count > 0)
        {
            foreach (var line in tagContent)
            {
                formatedInfo.AppendLine(line);
            }
        }
        formatedInfo.AppendLine("</body>");
        formatedInfo.AppendLine("</html>");

        //Console.WriteLine(formatedInfo.ToString().Trim());
        File.WriteAllText("index.html", formatedInfo.ToString().Trim());
    }
}