using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

{
    
}
public class Video

{
    private string _Title;
    private string _Author;
    private int _VideoLength;
    private List<Comment> comments;
    

    public Video(string title, string author, int video )
    {
        _Title = title;
        _Author = author;
        _VideoLength = video;
        comments = new List<Comment>();
    
    }
     public void AddComment(Comment comment)
   {
     comments.Add(comment);
   }
     public int GetCommentCount()
    {
        return comments.Count;
    }
    public void DisplayVideo()

    {
        Console.WriteLine($"Title: {_Title}");
        Console.WriteLine($"Author: {_Author}");
        Console.WriteLine($"Length: {_VideoLength} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($" Comment {comment}");
        }
        Console.WriteLine();
    }
        

}