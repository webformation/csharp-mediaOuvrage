using MediaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Auteur gates = new Auteur("Gates", "Bill");
            Livre l1 = new MediaLibrary.Livre("C#", "123", "Programmation",gates );
            Console.WriteLine(l1.Titre);
            foreach (var a in l1.Auteurs)
            {
                Console.WriteLine(a.Nom);
            }
            l1.Emprunter();
            Revue r1 = new MediaLibrary.Revue("Le Monde", "13 septembre 2019", "456", "Informations générales");
            Console.WriteLine(r1);
            Catalogue catalogue = new MediaLibrary.Catalogue();
            catalogue.Ajoute(l1);
            catalogue.Ajoute(l1);
            catalogue.Ajoute(new Livre("Windows","010","Système d'exploitation",gates));
            catalogue.Ajoute(r1);
            catalogue.AfficheTous();
            catalogue.AfficheLivre();
            catalogue.AfficheEmpruntable();
            Console.WriteLine(gates.getOuvrage());
            catalogue.Supprime(l1);
            Console.WriteLine(gates.getOuvrage());
        }
    }
}
