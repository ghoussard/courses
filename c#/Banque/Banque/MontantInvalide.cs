using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class MontantInvalide : Exception
    {
        public MontantInvalide() : base("Impossible d'effectuer l'opération : Montant Invalide")
        {
        }
    }
}
