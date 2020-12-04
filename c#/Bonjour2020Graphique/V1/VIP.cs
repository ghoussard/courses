using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    class VIP : Personne
    {
        private string titre;
        public VIP(String sonTitre, String sonNom) : base(sonNom) {
            titre = sonTitre;
        }
        public override String ToString() {
            return titre + " " + nom;
        }
        public override String Salut() {
            return "Bien le bonjour " + titre + " " + nom + " !";
        }
    }
}
