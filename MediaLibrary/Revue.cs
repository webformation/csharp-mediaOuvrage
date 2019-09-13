using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    public class Revue : Document
    {
        public string Numero { get; set; } 
        public Revue(string Titre, string Numero, string Code, string Categorie) : base(Titre, Code, Categorie)
        {
            this.Numero = Numero;
        }

        public override bool Equals(object obj)
        {
            var revue = obj as Revue;
            return revue != null &&
                   base.Equals(obj) &&
                   Numero == revue.Numero;
        }

        public override int GetHashCode()
        {
            var hashCode = -984159805;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Numero);
            return hashCode;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Titre);
            sb.Append(", ");
            sb.Append(Numero);
            return sb.ToString();
        }
        public override void  Dispose() { }
    }
}
