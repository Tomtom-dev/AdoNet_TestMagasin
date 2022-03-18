using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin1
{
    class Panier
    {
        public Panier(int id, int total, List<Produit> produit)
        {
            this.id = id;
            this.total = total;
            this.produit = produit;
        }

        public int id { get; set; }
        public int total { get; set; }
        public List<Produit> produit { get; set; }
    }
}
