using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class Auteur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Document> Titres { get; set; }

        public Auteur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            Titres = new List<Document>();
        }
        public void ajoute(Document d)
        {
            if (!Titres.Contains(d))
            {
                Titres.Add(d);
            }
        }
        public void supprime(Document d)
        {
            Titres.Remove(d);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Prenom);
            sb.Append(" ");
            sb.Append(Nom);
            return sb.ToString();
        }
        public string getOuvrage( )
        {
            StringBuilder sb = new StringBuilder("\nListe des ouvrages de ");
            sb.Append(Prenom);
            sb.Append(" ");
            sb.Append(Nom);
            sb.Append(" : ");
            string separ = "";
            foreach (var o in Titres)
            {
                sb.Append(separ);
                sb.Append(o.Titre);
                separ = " - ";
            }
            return sb.ToString();
        }
    }
}
