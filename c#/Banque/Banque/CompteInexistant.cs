using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteInexistant : Exception
    {
        public CompteInexistant() : base("Le compte n'existe pas")
        {
        }
    }
}
