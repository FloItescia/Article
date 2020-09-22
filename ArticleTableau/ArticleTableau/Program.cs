using System;

namespace ArticleTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            var article1 = new Article("NBA 2K21", 69.99, 2, ArticleEnum.Loisir);
            var article2 = new Article("Pomme", 1, 50, ArticleEnum.Alimentaire);
            var article3 = new Article("Veste", 60, 6, ArticleEnum.Habillement);

            var tableauArticle = new Article[] { article1, article2, article3 };

            for (int i = 0; i < tableauArticle.Length; i++)
            {
                tableauArticle[i].Afficher();
            }

            Console.WriteLine("[Modification quantitée Veste]");
            tableauArticle[2].Retirer();
            tableauArticle[2].Afficher();
        }
    }
}
