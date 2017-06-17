using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageStundetGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();
            studentGrades = ReadFromConsoleAddToDictionary(studentGrades);

            var formatedAnswer = new StringBuilder();
            formatedAnswer = AddTheDataToFormatedAnswer(studentGrades, formatedAnswer);

            PrintTheAnswer(formatedAnswer);
        }

        private static StringBuilder AddTheDataToFormatedAnswer(Dictionary<string, List<double>> studentGrades, StringBuilder formatedAnswer)
        {
            foreach (var student in studentGrades)
            {
                formatedAnswer.AppendFormat("{0} -> {1} (avg: {2:f2})" + Environment.NewLine
                                , student.Key
                                , string.Join(" ", student.Value.Select(p => p.ToString("0.00")))
                                , student.Value.Average());
            }

            return formatedAnswer;
        }

        private static Dictionary<string, List<double>> ReadFromConsoleAddToDictionary(Dictionary<string, List<double>> studentGrades)
        {
            var numberOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputLines; i++)
            {
                var inputLine = Console.ReadLine().Split().ToArray();
                var studentName = inputLine[0];
                var studentGrade = double.Parse(inputLine[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<double>());
                }

                studentGrades[studentName].Add(studentGrade);
            }

            return studentGrades;
        }

        private static void PrintTheAnswer(StringBuilder formatedAnswer)
        {
            Console.WriteLine(formatedAnswer);
        }
    }
}
