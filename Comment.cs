using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Comment
    {
        public string Text { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }

        public Comment(string text, string author, int rating)
        {
            Text = text;
            Author = author;
            Rating = rating;
        }
    }
}
