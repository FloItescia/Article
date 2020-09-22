using System;
using Article;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            article article1 = new article("NBA 2K21", 69.99, 3);
            article article2 = new article("FIFA 20",20 , 1);

            article1.Afficher();
            article2.Afficher();
            article1.Ajouter();
            article2.Retirer();
            article1.Afficher();
            article2.Afficher();

            Console.WriteLine("[Creation d'un article]");
            Console.WriteLine("Nom de l'article : ");
            string nomNewArticle = Console.ReadLine();
            Console.WriteLine("Prix de l'article");
            double prixNewArticle;
            while (!double.TryParse(Console.ReadLine(), out prixNewArticle))
            {
                Console.WriteLine("Erreur : Format du prix incorrect");
            };
            Console.WriteLine("Quantité de l'article");
            int quantiteNewArticle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            article newArticle = new article(nomNewArticle, prixNewArticle, quantiteNewArticle);


            newArticle.Afficher();
        }
    }
}
