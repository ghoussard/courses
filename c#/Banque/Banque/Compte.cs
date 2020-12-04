using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Compte
    {
        private int _numéro;

        private Client _client;

        protected int _solde;

        public int Numéro
        {
            get => _numéro;
        }

        public Client Client
        {
            get => _client;
        }

        public int Solde
        {
            get => _solde;
        }

        public Compte(int numéro, Client client)
        {
            _numéro = numéro;
            _client = client;
            _solde = 0;
        }

        public void Déposer(int montant)
        {
            if(montant < 1)
            {
                throw new MontantInvalide();
            }

            _solde += montant;
        }

        public virtual void Retirer(int montant)
        {

            if(montant < 1)
            {
                throw new MontantInvalide();
            }

            int soldeAprèsRetrait = _solde - montant;

            if (soldeAprèsRetrait < 0)
            {
                throw new MontantExcessif();
            }

            _solde = soldeAprèsRetrait;
        }

        public override string ToString()
        {
            return "Compte numéro " + _numéro + " avec un solde de " + Solde + " euros appartenant au client " + Client.ToString();
        }
    }
}
