using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public abstract class Document : IDisposable
    {
        // a faire : gestion des conditions de validité (code obligaire, titre obligatoire ....
        public string Titre { get; set; }
        public string Code { get; set; }
        public string Categorie { get; set; }
        public Document(string Titre, string Code, string Categorie)
        {
            this.Titre = Titre;
            this.Code = Code;
            this.Categorie = Categorie;
        }

        public override bool Equals(object obj)
        {
            var document = obj as Document;
            return document != null &&
                   Titre == document.Titre &&
                   Code == document.Code &&
                   Categorie == document.Categorie;
        }

        public override int GetHashCode()
        {
            var hashCode = -1433783421;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Categorie);
            return hashCode;
        }
        public abstract void Dispose();
    }
}
