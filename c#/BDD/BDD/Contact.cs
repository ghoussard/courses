using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD
{
    class Contact
    {
        private int _id;
        private String _nom;
        private String _prenom;
        private String _téléphone;

        public Contact(int id, String nom, String prenom, String téléphone)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _téléphone = téléphone;
        }

        public int Id { get => _id; set => _id = value; }

        public string Nom { get => _nom; set => _nom = value; }

        public string Prenom { get => _prenom; set => _prenom = value; }

        public string Téléphone { get => _téléphone; set => _téléphone = value; }

        public override String ToString()
        {
            return _nom + " " + _prenom;
        }
    }
}
