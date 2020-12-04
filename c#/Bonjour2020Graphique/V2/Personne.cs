using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    class Personne
    {
        protected String nom;
        public Personne(String sonNom) : base() {
            nom = sonNom;
        }
        public override String ToString() {
            return nom;
        }
        public virtual String Salut() {
            return "Bonjour " + nom + " !";
        }
        public virtual String AuRevoir() {
            return "Au revoir " + nom + " !";
        }
    }
}
