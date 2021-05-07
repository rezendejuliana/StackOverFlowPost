using System;
using System.Collections.Generic;

namespace StackOverFlowPost
{
    partial class Program
    {
        public class Post
        {
            private string _title { get; set; }
            private string _description { get; set; }
            private DateTime _dateTime;
            private readonly List<int> _countVotes = new List<int>();


            public Post()
            {
                _dateTime = DateTime.Now;
            }

            public Post(string description, string title)
            {
                _title = title;
                _description = description;
                _dateTime = DateTime.Now;
            }

            public void UpVote()
            {
                _countVotes.Add(1);
            }

            public void DownVote()
            {
                _countVotes.Remove(1);

            }

            public int SeeVotes()
            {
                return _countVotes.Count;
            }

            public string SeePost()
            {
                string post = _title + "    " + _description;
                return post;
            }

        }
    }
}
