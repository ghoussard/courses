using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class MontantExcessif : Exception
    {
        public MontantExcessif() : base("Impossible d'effectuer l'opération : Montant Excessif")
        {
        }
    }
}
