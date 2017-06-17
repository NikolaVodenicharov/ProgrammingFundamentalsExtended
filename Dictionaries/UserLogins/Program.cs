using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernamePassword = new Dictionary<string, string>();
            usernamePassword = ReadFromConsoleAddToUsernamePassword(usernamePassword);

            var failedLoginAmount = 0;
            var forPrinting = new StringBuilder();
            
            // try to login
            while (true)
            {
                var inputLogin = Console.ReadLine()
                            .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                bool isTimeToBreakLoop = inputLogin[0].Equals("end", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToBreakLoop)
                {
                    break;
                }

                var loginUsername = inputLogin[0];
                var loginPassword = inputLogin[1];

                var isLoginSuccessfully = usernamePassword.ContainsKey(loginUsername) &&
                                          usernamePassword[loginUsername].Equals(loginPassword);

                forPrinting = AppendResultOfTryLogin(forPrinting, loginUsername, loginPassword, isLoginSuccessfully);

                failedLoginAmount = FailedLoginCounter(isLoginSuccessfully, failedLoginAmount);
            }

            forPrinting.Append($"unsuccessful login attempts: {failedLoginAmount}");

            PrintAnswer(forPrinting);
        }

        private static int FailedLoginCounter(bool isLoginSuccessfully, int failedLogin)
        {
            if (isLoginSuccessfully)
            {
                return failedLogin += 0;
            }
            else
            {
                return failedLogin += 1;
            }
        }

        private static StringBuilder AppendResultOfTryLogin(StringBuilder forPrinting, string loginUsername, string loginPassword, bool isLoginSuccessfully)
        {
            if (isLoginSuccessfully)
            {
                return forPrinting.AppendLine($"{loginUsername}: logged in successfully");
            }
            else
            {
                return forPrinting.AppendLine($"{loginUsername}: login failed");
            }
        }

        private static void PrintAnswer(StringBuilder forPrinting)
        {
            Console.WriteLine(forPrinting);
        }

        private static Dictionary<string, string> ReadFromConsoleAddToUsernamePassword(Dictionary<string, string> usernamePassword)
        {
            while (true)
            {
                var inputUsernamePassword = Console.ReadLine()
                            .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                bool isTimeToBreakLoop = inputUsernamePassword[0].Equals("login", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToBreakLoop)
                {
                    break;
                }

                var username = inputUsernamePassword[0];
                var password = inputUsernamePassword[1];
                if (!usernamePassword.ContainsKey(username))
                {
                    usernamePassword.Add(username, password);
                }
                else
                {
                    usernamePassword[username] = password;
                }
            }

            return usernamePassword;
        }
    }
}
