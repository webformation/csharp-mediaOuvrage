using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class Catalogue
    {
        List<Document> fondMediatheque = new List<Document>();
        public List<Document> Liste {  get { return fondMediatheque; } }
        public void Ajoute(Document d)
        {
            if (!fondMediatheque.Contains(d))
            {
                fondMediatheque.Add(d);
            }
        }
        public void Supprime(Document d)
        {
            fondMediatheque.Remove(d);
            d.Dispose();
        }
        public void AfficheTous()
        {
            Console.WriteLine("\nListe des documents\n");
            foreach (var x in fondMediatheque)
            {
                Console.WriteLine(x);
            }
        }
        public void AfficheLivre()
        {
            Console.WriteLine("\nListe des livres\n");
            foreach (var x in fondMediatheque)
            {
                if (x is Livre) {
                    Console.WriteLine(x);
                }              
            }
        }
        public void AfficheEmpruntable()
        {
            Console.WriteLine("\nListe des livres empruntables\n");
            foreach (var x in fondMediatheque)
            {
                IEmpruntable e = x as IEmpruntable;
                if (e != null && e.IsDisponible() )
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
