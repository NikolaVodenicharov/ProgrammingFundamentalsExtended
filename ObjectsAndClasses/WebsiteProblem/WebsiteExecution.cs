using System;
using System.Collections.Generic;
using System.Text;

public class Website
{
    public string host;
    public string domain;
    public List<string> queries;

    public Website (string host, string domain, List<string> queries)
    {
        this.host = host;
        this.domain = domain;
        this.queries = queries;
    }

    public override string ToString()
    {
        var format = new StringBuilder();

        // add host and domain names
        format.AppendFormat($"https://www.{this.host}.{this.domain}");

        // add queries if they exist
        if (this.queries.Count > 0)
        {
            format.Append("/query?=");
            for (int i = 0; i < this.queries.Count; i++)
            {
                if (i + 1 == this.queries.Count)
                {
                    // last querie
                    format.Append($"[{this.queries[i]}]"); 
                }
                else
                {
                    format.Append($"[{this.queries[i]}]&");
                }
            }
        }

        return format.ToString();
    }
}

class WebsiteExecution
{
    static void Main()
    {
        var websites = new List<Website>();

        while (true)
        {
            var inputInfo = Console.ReadLine();

            var isTimeToStopLoop = inputInfo.Equals("end", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToStopLoop)
            {
                break;
            }

            AddWebsiteToWebsites(websites, inputInfo);
        }

        var answer = new StringBuilder();
        AddInfoToAnswer(websites, answer);

        PrintAnswer(answer);
    }

    private static void AddWebsiteToWebsites(List<Website> websites, string inputInfo)
    {
        var splitInfoByLine = inputInfo.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var inputWebsite = new Website(splitInfoByLine[0], splitInfoByLine[1], new List<string>());
        AddQueriesToInputWebsite(splitInfoByLine, inputWebsite);

        websites.Add(inputWebsite);
    }

    private static void AddInfoToAnswer(List<Website> websites, StringBuilder answer)
    {
        foreach (var web in websites)
        {
            answer.AppendLine(web.ToString());
        }
    }

    private static void PrintAnswer(StringBuilder answer)
    {
        Console.WriteLine(answer);
    }

    private static void AddQueriesToInputWebsite(string[] splitInfoByLine, Website inputWebsite)
    {
        if (splitInfoByLine.Length == 3)
        {
            var queries = splitInfoByLine[2].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var querie in queries)
            {
                inputWebsite.queries.Add(querie);
            }
        }
    }
}