using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Voiture
    {
        private String _nom;
        private int _chevaux;

        public String Nom
        {
            get => _nom;
            set
            {
                if(value.Length > 0)
                {
                    _nom = value;
                }
            }
        }

        public int Chevaux
        {
            get => _chevaux;
            set
            {
                if (value > 0)
                {
                    _chevaux = value;
                }
            }
        }

        public Voiture(String nom, int chevaux)
        {
            _nom = nom;
            _chevaux = chevaux;
        }

        public override String ToString()
        {
            return _nom + "(ch: " + _chevaux + ")";
        }

    }
}
