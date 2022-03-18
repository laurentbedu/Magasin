using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin
{
    internal class Category
    {
        private string code = "";
        private string designation = "";
        private bool enLigne = true;
        private List<Article> articles = new();

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
        public bool EnLigne { get => enLigne; set => enLigne = value; }
        internal List<Article> Articles { get => articles; }

        public Category() { }
        public Category(string code, string designation, bool enLigne = true)
        {
            Code = code;
            Designation = designation;
            EnLigne = enLigne;

        }
        public Category(Category category)
        {
            Code = category.Code;
            Designation = category.Designation;
            EnLigne = category.EnLigne;
        }

        public override string ToString()
        {
            return Designation + " (" + Code + ") : " + (EnLigne ? "en vente" : "non disponible");
        }

        public void AddArticle(Article article)
        {
            if (!Articles.Contains(article))
            {
                Articles.Add(article);
            }
            if (article.Category != this)
            {
                article.Category = this;
            }
        }

        public void RemoveArticle(Article article)
        {
            if (article != null && Articles.Contains(article))
            {
                Articles.Remove(article);
                if (article.Category == this)
                {
                    article.Category = null;
                }
            }

        }
    }
}
