using System;
using System.Collections.Generic;
using System.IO;

class UserDatabaseExecution
{
    static void Main(string[] args)
    {
        var users = new Dictionary<string, string>();
        ReadUsersDataFromFile(users);

        bool isThereLogedUser = false;
        while (true)
        {
            string[] input = Console.ReadLine().Split();

            if (input[0].Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (input[0].Equals("register", StringComparison.OrdinalIgnoreCase))
            {
                RegisterUser(users, input);
            }
            else if (input[0].Equals("login", StringComparison.OrdinalIgnoreCase))
            {
                isThereLogedUser = Login(users, isThereLogedUser, input);
            }
            else if (input[0].Equals("logout", StringComparison.OrdinalIgnoreCase))
            {
                isThereLogedUser = Logout(isThereLogedUser);
            }
        }

        AddUsersDataToFile(users);
    }

    private static void ReadUsersDataFromFile(Dictionary<string, string> users)
    {
        bool isFileExist = File.Exists("users.txt");

        if (isFileExist)
        {
            string[] usersInfo = File.ReadAllLines("users.txt");
            foreach (var info in usersInfo)
            {
                string[] namePassword = info.Split();
                users.Add(namePassword[0], namePassword[1]);
            }
        }
    }

    private static void AddUsersDataToFile(Dictionary<string, string> users)
    {
        File.Delete("users.txt");
        foreach (var user in users)
        {
            File.AppendAllText("users.txt", $"{user.Key} {user.Value}" + Environment.NewLine);
        }
    }

    private static bool Login(Dictionary<string, string> users, bool isThereLogedUser, string[] input)
    {
        bool isUserExist = users.ContainsKey(input[1]);

        if (isThereLogedUser)
        {
            Console.WriteLine("There is already a logged in user.");
        }
        else if (isUserExist)   // isUser exist & !isThereLogedUser
        {
            bool isPaswordMatch = users[input[1]].Equals(input[2]);

            if (isPaswordMatch)
            {
                isThereLogedUser = true;
            }
            else
            {
                Console.WriteLine("The password you entered is incorrect.");
            }
        }
        else if(!isUserExist)   // else
        {
            Console.WriteLine("There is no user with the given username.");
        }

        return isThereLogedUser;
    }

    private static bool Logout(bool isThereLogedUser)
    {
        if (isThereLogedUser)
        {
            isThereLogedUser = false;
        }
        else
        {
            Console.WriteLine("There is no currently logged in user.");
        }

        return isThereLogedUser;
    }

    private static void RegisterUser(Dictionary<string, string> users, string[] input)
    {
        bool arePasswordsMatch = input[2].Equals(input[3]); // password and confirm password
        bool isUserNotExist = !users.ContainsKey(input[1]);

        if (arePasswordsMatch & isUserNotExist)
        {
            users.Add(input[1], input[2]);
        }
        else if (!isUserNotExist)
        {
            Console.WriteLine("The given username already exists.");
        }
        else if (!arePasswordsMatch)
        {
            Console.WriteLine("The two passwords must match.");
        }
    }
}
