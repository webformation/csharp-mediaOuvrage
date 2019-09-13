using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class Livre : Document, IEmpruntable
    {
        private bool disponible = true;
        public List<Auteur> Auteurs { get; set; }
        public Livre(string Titre, string Code, string Categorie, params Auteur[] auteurs) : base(Titre, Code, Categorie)
        {
            Auteurs = new List<Auteur>();
            foreach (Auteur a in auteurs)
            {
                Auteurs.Add(a);
                a.ajoute(this);
            }
        }
        public override void Dispose()
        {
            foreach (Auteur a in Auteurs)
            {
                a.supprime(this);
            }
        }

        public bool IsDisponible()
        {
            return disponible;
        }

        public bool Emprunter()
        {
            if (disponible)
            {
                Console.WriteLine("L'emprunt de {0} est enregistré ", Titre);
                disponible = false;
                return true;
            }
            return false;
        }
        public bool Rendre()
        {
            Console.WriteLine("Le retour de {0} est enregistré ", Titre);
            disponible = true;
            return true;
        }

        public override bool Equals(object obj)
        {
            var livre = obj as Livre;
            return livre != null &&
                   base.Equals(obj) &&
                   disponible == livre.disponible &&
                   EqualityComparer<List<Auteur>>.Default.Equals(Auteurs, livre.Auteurs);
        }

        public override int GetHashCode()
        {
            var hashCode = 1408498298;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + disponible.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Auteur>>.Default.GetHashCode(Auteurs);
            return hashCode;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Titre);
            sb.Append(", ");
            string separ = "";
            foreach (var a in Auteurs)
            {
                sb.Append(separ);
                sb.Append(a);
                separ = "-";
            }
            sb.Append(", ");
            sb.Append(Categorie);
            sb.Append(", ");
            sb.Append(Code);
            return sb.ToString();
        }
    }
}
