using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleTableau
{
    public enum ArticleEnum
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }
    public struct Article
    {
        private string nomArticle;
        private double prixArticle;
        private int quantiteArticle;
        private ArticleEnum _typeArticleEnum;

        public Article(string nomArticle, double prixArticle, int quantiteArticle, ArticleEnum typeArticleEnum)
        {
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.quantiteArticle = quantiteArticle;
            this._typeArticleEnum = typeArticleEnum;
        }


        public void Afficher()
        {
            Console.WriteLine("[Affichage Article]");
            Console.WriteLine("Nom de l'article : " + nomArticle);
            Console.WriteLine("Prix de l'article : " + prixArticle + " euros");
            Console.WriteLine("Quantité de l'Article : " + quantiteArticle);

            if (_typeArticleEnum == ArticleEnum.Alimentaire)
            {
                Console.WriteLine("Type de l'article : Alimentaire");
            }

            if (_typeArticleEnum == ArticleEnum.Droguerie)
            {
                Console.WriteLine("Type de l'article : Droguerie");
            }

            if (_typeArticleEnum == ArticleEnum.Habillement)
            {
                Console.WriteLine("Type de l'article : Habillement");
            }

            if (_typeArticleEnum == ArticleEnum.Loisir)
            {
                Console.WriteLine("Type de l'article : Loisir");
            }

        }

        public void Ajouter()
        {
            quantiteArticle++;
            Console.WriteLine("[Ajout Article]");
        }

        public void Retirer()
        {
            if (quantiteArticle != 0)
            {
                quantiteArticle--;
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Vous avez supprimez un article, il reste " + quantiteArticle + " unité de l'article " + nomArticle);
            }
            else
            {
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Erreur : Il n'y a plus d'article disponnible");
            }

        }
    }
}
