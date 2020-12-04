using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Client
    {

        private String _nom;

        private String _prénom;

        private String _adresse;

        public String Nom
        {
            get => _nom;
        }

        public String Prénom
        {
            get => _prénom;
        }

        public String Identité
        {
            get => Nom + " " + Prénom;
        }

        public String Adresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        public Client(String nom, String prénom)
        {
            _nom = nom;
            _prénom = prénom;
        }

        public override string ToString()
        {
            String ToString = Identité;
            if (Adresse != null) ToString += " qui habite au " + Adresse;
            return ToString;
        }
    }
}
