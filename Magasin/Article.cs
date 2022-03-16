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
        private string reference;
        private string designation;
        private double prixHT;
        private static double tauxTVA = 20;
        private Taxe taxe;

        //Propriétés
        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHT { get => prixHT; set => prixHT = value; }
        public static double TauxTVA { get => tauxTVA; set => tauxTVA = value; }
        public Taxe Taxe { get => taxe; set => taxe = value; }

        //Constructeurs
        public Article() { }//Constructeur par défaut
        public Article(string _reference, string _designation, double _prixHT, Taxe _taxe)//Constructeur d'initialisation
        {
            reference = _reference;
            designation = _designation;
            prixHT = _prixHT;
            taxe = _taxe;

        }
        public Article(Article article)//Constructeur de recopie
        {
            reference = article.reference;
            designation = article.designation;
            prixHT = article.prixHT;
            taxe = article.taxe;    
        }

        //Méthodes
        public double CalculerPrixTTC()
        {
            return prixHT * (1 + tauxTVA / 100);
        }
        public string AfficherArticle()
        {
            return designation + " (Réf:" + reference + ") " + prixHT + "€HT (" + CalculerPrixTTC() + "€TTC)";
        }

        public override string ToString()
        {
            return designation + " (Réf:" + reference + ") " + prixHT + "€HT (" + CalculerPrixTTC() + "€TTC)";
        }
    }

    enum Taxe
    {
        Tx5 = 5,
        Tx10 = 10,
        Tx20 = 20
    }
}
