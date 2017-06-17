using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BankAccount
{
    public string bank;
    public string name;
    public decimal balance;

    public BankAccount(string bank, string name, decimal balance)
    {
        this.bank = bank;
        this.name = name;
        this.balance = balance;
    }
}

class OptimizedBankingSystem
{
    static void Main()
    {
        var accountsKeeper = new List<BankAccount>();
        ReadFromConsoleAddToAccountsKeeper(accountsKeeper);

        var answer = new StringBuilder();
        AddInfoToAnswer(accountsKeeper, answer);

        PrintAnswer(answer);
    }

    private static void PrintAnswer(StringBuilder answer)
    {
        Console.WriteLine(answer);
    }

    private static void AddInfoToAnswer(List<BankAccount> accountsKeeper, StringBuilder answer)
    {
        foreach (var acc in accountsKeeper
                            .OrderByDescending(b => b.balance)
                            .ThenBy(L => L.bank.Length))
        {
            answer.AppendLine($"{acc.name} -> {acc.balance} ({acc.bank})");
        }
    }

    private static void ReadFromConsoleAddToAccountsKeeper(List<BankAccount> accountsKeeper)
    {
        while (true)
        {
            var inputInfo = Console.ReadLine();

            var isTimeToStopLoop = inputInfo.Equals("end", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToStopLoop)
            {
                break;
            }

            AddToAccountsKeeper(accountsKeeper, inputInfo);
        }
    }

    private static void AddToAccountsKeeper(List<BankAccount> accountsKeeper, string inputInfo)
    {
        var splitedInfo = inputInfo.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

        var inputAccount = new BankAccount(splitedInfo[0],
                                           splitedInfo[1],
                                           decimal.Parse(splitedInfo[2]));
        accountsKeeper.Add(inputAccount);
    }
}
