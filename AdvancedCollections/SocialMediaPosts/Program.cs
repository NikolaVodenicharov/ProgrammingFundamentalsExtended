using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var postNameNumberOfLikesAndDislikes = new Dictionary<string, List<int>>();
            var postNameComentatorNameComment = new Dictionary<string, Dictionary<string, List<string>>>();
            ReadFromConsoleAddToCollections(postNameNumberOfLikesAndDislikes, postNameComentatorNameComment);

            var formatedAnswer = new StringBuilder();
            AddInformationToFormatedAnswer(postNameNumberOfLikesAndDislikes, postNameComentatorNameComment, formatedAnswer);

            PrintAnswer(formatedAnswer);
        }

        private static void ReadFromConsoleAddToCollections(Dictionary<string, List<int>> postNameNumberOfLikesAndDislikes, Dictionary<string, Dictionary<string, List<string>>> postNameComentatorNameComment)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                var isTimeToStopLoop = inputLine.Equals("drop the media", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var splitedInput = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = splitedInput[0];
                var postName = splitedInput[1];

                if (command.Equals("post"))
                {
                    IfKeyDoesntExistAddItAndInitializeList(postNameNumberOfLikesAndDislikes, postName);
                }
                else if (command.Equals("like"))
                {
                    AddOneLikeToPost(postNameNumberOfLikesAndDislikes, postName);

                }
                else if (command.Equals("dislike"))
                {
                    AddOneDislikeToPost(postNameNumberOfLikesAndDislikes, postName);
                }
                else if (command.Equals("comment"))
                {
                    DeclareInitialazieAddComment(postNameComentatorNameComment, splitedInput, postName);
                }
            }
        }

        private static void AddInformationToFormatedAnswer(Dictionary<string, List<int>> postNameNumberOfLikesAndDislikes, Dictionary<string, Dictionary<string, List<string>>> postNameComentatorNameComment, StringBuilder formatedAnswer)
        {
            foreach (var post in postNameNumberOfLikesAndDislikes)
            {
                formatedAnswer.AppendFormat("Post: {0} | Likes: {1} | Dislikes: {2}"
                                            + Environment.NewLine
                                            , post.Key
                                            , post.Value[0]
                                            , post.Value[1]);
                formatedAnswer.AppendLine("Comments:");
                AddCommentsToFormatedAnswer(postNameComentatorNameComment, formatedAnswer, post);
            }
        }

        private static void PrintAnswer(StringBuilder formatedAnswer)
        {
            Console.WriteLine(formatedAnswer);
        }

        private static void AddCommentsToFormatedAnswer(Dictionary<string, Dictionary<string, List<string>>> postNameComentatorNameComment, StringBuilder formatedAnswer, KeyValuePair<string, List<int>> post)
        {
            if (!postNameComentatorNameComment.ContainsKey(post.Key))
            {
                formatedAnswer.AppendLine("None");
            }
            else
            {
                foreach (var ComentatorNameComment in postNameComentatorNameComment[post.Key])
                {
                    formatedAnswer.AppendFormat("*  {0}: {1}"
                                                + Environment.NewLine
                                                , ComentatorNameComment.Key
                                                , string.Join(" ", ComentatorNameComment.Value));
                }
            }
        }

        private static void DeclareInitialazieAddComment(Dictionary<string, Dictionary<string, List<string>>> postNameComentatorNameComment, string[] splitedInput, string postName)
        {
            if (!postNameComentatorNameComment.ContainsKey(postName))
            {
                postNameComentatorNameComment.Add(postName, new Dictionary<string, List<string>>());
            }

            var comentatorName = splitedInput[2];

            if (!postNameComentatorNameComment[postName].ContainsKey(comentatorName))
            {
                postNameComentatorNameComment[postName].Add(comentatorName, new List<string>());
            }

            for (int i = 3; i < splitedInput.Length; i++)
            {
                postNameComentatorNameComment[postName][comentatorName].Add(splitedInput[i]);
            }
        }

        private static void AddOneDislikeToPost(Dictionary<string, List<int>> collection, string key)
        {
            collection[key][1] += 1;
        }

        private static void AddOneLikeToPost(Dictionary<string, List<int>> collection, string key)
        {
            collection[key][0] += 1;
        }

        private static void IfKeyDoesntExistAddItAndInitializeList(Dictionary<string, List<int>> collection, string key)
        {
            if (!collection.ContainsKey(key))
            {
                collection.Add(key, new List<int>());
            }

            collection[key].Add(0); // likes
            collection[key].Add(0); // dislikes
        }
    }
}
