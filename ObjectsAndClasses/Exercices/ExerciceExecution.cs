using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Exercice
{
    public string topic;
    public string courseName;
    public string judgeContestLink;
    public List<string> problems;

    public Exercice(string topic, string courceName, string judgeContestLik, List<string> problems)
    {
        this.topic = topic;
        this.courseName = courceName;
        this.judgeContestLink = judgeContestLik;
        this.problems = problems;
    }
}

class ExerciceExecution
{
    static void Main()
    {
        var exercices = new List<Exercice>();
        ReadFromCOnsoleAddToCollection(exercices);

        var answer = new StringBuilder();
        AddInfoToAnswer(exercices, answer);

        PrintAnswer(answer);
    }

    private static void PrintAnswer(StringBuilder answer)
    {
        Console.WriteLine(answer);
    }

    private static void AddInfoToAnswer(List<Exercice> exercices, StringBuilder answer)
    {
        foreach (var ex in exercices)
        {
            answer.AppendLine($"Exercises: {ex.topic}");
            answer.AppendLine($"Problems for exercises and homework for the \"{ex.courseName}\" course @ SoftUni.");
            answer.AppendLine($"Check your solutions here: {ex.judgeContestLink}");

            var problemCounter = 1;
            foreach (var problem in ex.problems)
            {
                answer.AppendLine($"{problemCounter}. {problem}");
                problemCounter++;
            }

        }
    }

    private static void ReadFromCOnsoleAddToCollection(List<Exercice> exercices)
    {
        while (true)
        {
            var inputInfo = Console.ReadLine();

            var isTimeToStopLoop = inputInfo.Equals("go go go");
            if (isTimeToStopLoop)
            {
                break;
            }

            Exercice inputExercice = CreateNewExercice(inputInfo);
            exercices.Add(inputExercice);
        }
    }

    private static Exercice CreateNewExercice(string inputInfo)
    {
        var splitedInfo = inputInfo.Split(new char[] { '-', '>', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var topic = splitedInfo[0];
        var courseName = splitedInfo[1];
        var judgeContestLink = splitedInfo[2];

        var problems = new List<string>();
        for (int i = 3; i < splitedInfo.Length; i++)
        {
            problems.Add(splitedInfo[i]);
        }

        var inputExercice = new Exercice(topic, courseName, judgeContestLink, problems);
        return inputExercice;
    }
}
