using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4
{
    class FabriqueEditeur
    {
        public static Editeur EditeurPour(Personne p) {
            Editeur edt;
            if (p is VIP v) {
                edt = EditeurVIP.getInstance();
                edt.Modifier(v);
            } else {
                edt = EditeurPersonne.getInstance();
                edt.Modifier(p);
            }
            return edt;
        }
    }
}
