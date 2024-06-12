using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Article
    {
        private static int counter = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Article(string title, string text, User author)
        {
            Id = ++counter;
            Title = title;
            Text = text;
            Author = author;
        }

        public void AddComment (Comment comment)
        {
            Comments.Add(comment);
        }

        public void EditArticle(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public void DeleteArticle(Comment comment)
        {
            Comments.Remove(comment);
        }
    }
}
