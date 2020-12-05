using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempleBdD
{
    public class Contact {
        private String _nom, _prenom, _tel;
        private int _id;
        public Contact(int id, String nom, String prenom, String tel) {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _tel = tel;
        }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Telephone { get => _tel; set => _tel = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
