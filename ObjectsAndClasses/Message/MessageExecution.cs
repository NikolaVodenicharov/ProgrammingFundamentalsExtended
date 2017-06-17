using System;
using System.Collections.Generic;

public class User
{
    public string username;
    public List<Message> receivedMessages;

    public User (string username, List<Message> receivedMessages)
    {
        this.username = username;
        this.receivedMessages = receivedMessages;
    }
}

public class Message
{
    public string content;
    public User sender;

    public Message (string content, User sender)
    {
        this.content = content;
        this.sender = sender;
    }
}

class MessageExecution
{
    static void Main(string[] args)
    {
        var users = new List<User>();

        while (true)
        {
            var inputInfo = Console.ReadLine();

            var isTimeToStopLoop = inputInfo.Equals("end", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToStopLoop)
            {
                break;
            }

            var splitedInfo = inputInfo.Split();

            if (splitedInfo[0].Equals("register", StringComparison.InvariantCultureIgnoreCase))
            {
                var inputUser = new User(splitedInfo[1], new List<Message>());
                users.Add(inputUser);
            }
            else
            {
                var sender = splitedInfo[0];
                var receiver = splitedInfo[2];
                var message = splitedInfo[3];

                var inputMessage = new Message(message, )
            }
        }
    }
}

