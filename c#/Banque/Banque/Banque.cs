using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class Banque
    {
        private List<Client> _clients;

        private List<Compte> _comptes;

        //Indexeur
        public Compte this[int numéroDeCompte]
        {
            get => _comptes[numéroDeCompte];
            set => _comptes[numéroDeCompte] = value;
        }

        public Banque()
        {
            _clients = new List<Client>();
            _comptes = new List<Compte>();
        }

        public void Ajouter(Client client)
        {
            _clients.Add(client);
        }

        public void Ajouter(Compte compte)
        {
            _comptes.Add(compte);
        }

        public Client Client(String nom, String prénom)
        {
            Client clientRecherché = null;

            foreach(Client c in _clients)
            {
                if (c.Nom.Equals(nom) && c.Prénom.Equals(prénom))
                {
                    clientRecherché = c;
                    break;
                }
            }

            return clientRecherché;
        }

        public Compte Compte(int numéro)
        {
            Compte compteRecherché = null;

            foreach (Compte c in _comptes)
            {
                if (c.Numéro == numéro)
                {
                    compteRecherché = c;
                    break;
                }
            }

            if(compteRecherché == null)
            {
                throw new CompteInexistant();
            }

            return compteRecherché;
        }

        public void CreerCompte(int numéro, Client client)
        {
            _comptes.Add(new Compte(numéro, client));
        }
    }
}
