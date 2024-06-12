using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Blog
    {
        private List<Article> articles = new List<Article>();

        public void AddArticle(Article article)
        {
            articles.Add(article);
        }

        public List<Article> GetAllArticles()
        {
            return articles;
        }

        public Article GetArticleById(int id)
        {
            return articles.FirstOrDefault(a => a.Id == id);
        }

        public void RemoveArticle(int id)
        {
            var article = GetArticleById(id);
            if (article != null)
            {
                articles.Remove(article);
            }
        }
    }
}
