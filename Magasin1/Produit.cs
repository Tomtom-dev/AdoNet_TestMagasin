using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin1
{
    class Produit
    {
        public Produit(int id, string nom, int prix, int stock)
            {
                this.id = id;
                this.nom = nom;
                this.prix = prix;
                this.stock = stock;        
            }

        public int id { get; set; }
        public string nom { get; set; }
        public int prix { get; set; }
        public int stock { get; set; }
    }
}
