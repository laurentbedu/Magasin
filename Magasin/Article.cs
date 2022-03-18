using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin
{
    internal class Article
    {
        //Attributs
        private string reference = "";
        private string designation = "";
        private double prixHT = 0;
        private TxTaxe taxe = TxTaxe.Tx1;
        private Category? category;

        //Propriétés
        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHT { get => prixHT; set => prixHT = value; }
        public TxTaxe Taxe { get => taxe; set => taxe = value; }
        internal Category? Category { 
            get => category;
            set
            {
                if (category != value)
                {
                    category?.RemoveArticle(this);
                    category = value;
                    category?.AddArticle(this);
                }
            }
        }

        //Constructeurs
        public Article() { }
        public Article(string reference, string designation, double prixHT = 0, TxTaxe taxe = TxTaxe.Tx1)
        {
            Reference = reference;
            Designation = designation;
            PrixHT = prixHT;
            Taxe = taxe;

        }
        public Article(Article article)
        {
            Reference = article.Reference;
            Designation = article.Designation;
            PrixHT = article.PrixHT;
            Taxe = article.Taxe;    
        }

        public double CalculerPrixTTC()
        {
            double prixTTC = 0;
            switch (Taxe)
            {
                case TxTaxe.Tx1:
                    prixTTC = PrixHT * 1.055;
                    break;

                case TxTaxe.Tx2:
                    prixTTC = PrixHT * 1.1;
                    break;

                case TxTaxe.Tx3:
                    prixTTC = PrixHT * 1.2;
                    break;

            }
            return prixTTC;
        }
        public override string ToString()
        {
            return Designation + " (Réf:" + Reference + ") : " + PrixHT + "€HT (" + CalculerPrixTTC() + "€TTC)";
        }
    }

    internal enum TxTaxe
    {
        Tx1,
        Tx2,
        Tx3
    }
}
