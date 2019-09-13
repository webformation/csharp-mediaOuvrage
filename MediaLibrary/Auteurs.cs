using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class Auteurs
    {
        Predicate<Auteur>  CompareAuteur;
        List<Auteur> auteurs = new List<Auteur>();
        public void ajout(Auteur a)
        {
            auteurs.Add(a);
        }
        public Auteur trouve(String nomcherche, string prenomcherche)
        {
             bool egal(Auteur a)
            {
                return nomcherche == a.Nom && prenomcherche == a.Prenom;
            }
            CompareAuteur = egal;
            return auteurs.Find(CompareAuteur);
        }
        public Auteur search(String nomcherche, string prenomcherche)
        {
            return auteurs.Find(x => nomcherche == x.Nom && prenomcherche == x.Prenom );
        }



    }
}
