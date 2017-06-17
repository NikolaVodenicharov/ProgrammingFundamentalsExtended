using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var studentsGrades = new Dictionary<string, List<int>>();

        while (true)
        {
            var inputLine = Console.ReadLine()
                            .Split(new char[] { '-', '>', ',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var isTimeToEndLoop = inputLine[0].Equals("end", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToEndLoop)
            {
                break;
            }

            var studentName = inputLine[0];
            var digitOrSecondName = inputLine[1];
            bool isInputLineContainsSequenceOfNumbers = IsNumeric(digitOrSecondName);
            bool isSecondElementANameInTheDict = studentsGrades.ContainsKey(digitOrSecondName);

            if (isInputLineContainsSequenceOfNumbers || isSecondElementANameInTheDict)
            {
                studentsGrades = IfNameIsNewAddItAndInitializeList(studentsGrades, studentName);
            }
            else
            {
                continue;
            }

            if (isInputLineContainsSequenceOfNumbers)
            {

                for (int i = 1; i < inputLine.Length; i++)
                {
                    studentsGrades[studentName]
                    .Add(
                    int.Parse(
                    inputLine[i]));
                }
            }
            else if (isSecondElementANameInTheDict)
            {
                // studentsGrades[inputLine[1]] - its list of grades of existing in Dict person
                studentsGrades[studentName].AddRange(studentsGrades[inputLine[1]]);
            }
        }

        foreach (var student in studentsGrades)
        {
            Console.WriteLine("{0} === {1}"
                              , student.Key
                              , string.Join(", ", student.Value));
        }
    }

    private static Dictionary<string, List<int>> IfNameIsNewAddItAndInitializeList(Dictionary<string, List<int>> studentsGrades, string studentName)
    {
        if (!studentsGrades.ContainsKey(studentName))
        {
            studentsGrades.Add(studentName, new List<int>());
        }

        return studentsGrades;
    }

    public static bool IsNumeric(string chekingString)
    {
        foreach (char c in chekingString)
        {
            if (!char.IsDigit(c) && c != '.')
            {
                return false;
            }
        }

        return true;
    }
}

