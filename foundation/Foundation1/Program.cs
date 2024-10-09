using System;
using System.Collections.Generic;
using Foundation1;

namespace Foundation1
{
    //Comment class to represent individual comments
    class Comment
    {
        public string CommenterName { get; private set;}
        public string CommentText { get; private set;}

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }

        public void DisplayComment()
        {
            Console.WriteLine($"{CommenterName}: {CommentText}");
        }
    }
    class Video
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int LengthInSeconds { get; private set; }
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>();
        }
        //Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        //Method to get the number of comments
        public int GetCommentCount()
        {
            return Comments.Count;
        }

        //Method to display video information and the comments
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
            Console.WriteLine("Comments: ");
            foreach (var comment in Comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine( new string('-', 40)); //Seperator
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Create Video Objects
        Video video1 = new Video("Learning C#", "John Smith", 600);
        Video video2 = new Video("Advanced C# Concepts", "Jane Doe", 800);
        Video video3 = new Video("Introduction to C#", "Bob Doe", 500);
        Video video4 = new Video("C# for Beginners", "Alice Smith", 350);

        //Add comments to video1
        video1.AddComment(new Comment("UserA", "Great introduction! "));
        video1.AddComment(new Comment("UserB", "I learned a lot! "));
        video1.AddComment(new Comment("UserC", "Looking for more information! "));

        //Add comments to video2
        video2.AddComment(new Comment("UserD", "I'm learning C#! "));
        video2.AddComment(new Comment("UserE", "I can't wait to learn more! "));
        video2.AddComment(new Comment("UserF", "Thanks for sharing! "));

        //Add comments to video3
        video3.AddComment(new Comment("UserG", "Great video! "));
        video3.AddComment(new Comment("UserH", "I'm enjoying the content! "));
        video3.AddComment(new Comment("UserI", "I'm looking forward to more videos! "));

        //Add comments to video4
        video4.AddComment(new Comment("UserJ", "I'm learning C#! "));
        video4.AddComment(new Comment("UserK", "I can't wait to learn more! "));
        video4.AddComment(new Comment("UserL", "Thanks for sharing! "));

        //Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        //Iterate through the list and display information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}