﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4
{
    public class VIP : Personne {
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
        public override String AuRevoir() {
            return "Au revoir " + titre + " " + nom + " !";
        }
        public String Titre {
            get { return titre; } 
            set { titre = value; }
        }
    }
}
