using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Article
{
    struct article
    {
        public string nom;
        public double prix;
        public int quantite;

        article(string nom, double prix, int quantite)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        public void Afficher()
        {
            Console.WriteLine("L'article {0} est au prix de {1}, la quantité restante est de {2}", this.nom, this.prix, this.quantite);
        }

        public void Ajouter()
        {
            this.quantite += 1;
        }

        public void Retirer()
        {
            if (this.quantite >= 1)
            {
                this.quantite -= 1;
            }
            else
            {
                Console.WriteLine("Plus aucune quantité n'est disponible.");
            }
        }
    }
}
