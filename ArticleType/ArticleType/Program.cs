using System;

namespace ArticleType
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article("NBA 2K21", 69.99, 2, TypeArticleEnum.Loisir);
            Article article2 = new Article("Pomme", 1, 50, TypeArticleEnum.Alimentaire);

            article1.Afficher();
            article2.Afficher();
            article1.Ajouter();
            article2.Retirer();
            article1.Afficher();
            article2.Afficher();

            Console.WriteLine("Nom de l'article : ");
            string nomNewArticle = Console.ReadLine();
            Console.WriteLine("Prix de l'article");
            double prixNewArticle;
            while (!double.TryParse(Console.ReadLine(), out prixNewArticle))
            {
                Console.WriteLine("Erreur : Format du prix incorrect");
            };
            Console.WriteLine("Quantitée : ");
            int quaniteNewArticle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type : ");
            Console.WriteLine("1. Alimentaire ");
            Console.WriteLine("2. Droguerie");
            Console.WriteLine("3. Habillement");
            Console.WriteLine("4. Loisir : ");

            TypeArticleEnum typeNewArticle = (TypeArticleEnum)(Convert.ToInt32(Console.ReadLine()) - 1);


            Article newArticle = new Article(nomNewArticle, prixNewArticle, quaniteNewArticle, typeNewArticle);

            Console.WriteLine(Environment.NewLine);

            newArticle.Afficher();

        }
    }
}
