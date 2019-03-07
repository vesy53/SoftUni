using System;
using System.Collections.Generic;
using System.Linq;

class SocialMediaPosts
{
    static void Main(string[] args)
    {
        var postLike = new Dictionary<string, int>();
        var postDislike = new Dictionary<string, int>();
        var postComment = new Dictionary<string, Dictionary<string, string>>();

        string input = Console.ReadLine();

        while (input != "drop the media")
        {
            string[] currentInput = input
                .Split();

            string command = currentInput[0];
            string postName = currentInput[1];

            switch (command)
            {
                case "post":
                    postComment.Add(postName, new Dictionary<string, string>());
                    postLike.Add(postName, 0);
                    postDislike.Add(postName, 0);
                    break;
                case "like":
                    postLike[postName]++;
                    break;
                case "dislike":
                    postDislike[postName]++;
                    break;
                case "comment":
                    string commentatorName = currentInput[2];
                    string commentContent = string.Join(" ", currentInput.Skip(3));
                    postComment[postName].Add(commentatorName, commentContent);
                    break;
            }

            input = Console.ReadLine();
        }

        foreach (var post in postComment)
        {
            string name = post.Key;
            int likes = postLike[name];
            int dislikes = postDislike[name];
            Dictionary<string, string> comments = post.Value;

            Console.WriteLine(
                $"Post: {name} | Likes: {likes} | Dislikes: {dislikes}");
            Console.WriteLine("Comments:");

            if (comments.Count == 0)
            {
                Console.WriteLine("None");

            }

            foreach (var comment in comments)
            {
                string commentatorName = comment.Key;
                string commentContent = comment.Value;

                Console.WriteLine(
                    $"*  {commentatorName}: {commentContent}");
            }
        }
    }
}

