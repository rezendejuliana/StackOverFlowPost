using System;

namespace StackOverFlowPost
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string title = "My new Post about life! S2";
            string description = "This post is about life and stuf...";
            Post post = new Post(description, title);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
           // post.DownVote();
            Console.WriteLine(post.SeePost());
            Console.WriteLine(post.SeeVotes());



        }
    }
}
