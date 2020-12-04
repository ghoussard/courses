using System;

namespace Banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Banque!");

            //client
            Client client1 = new Client("Dupont", "Jean");
            Console.WriteLine(client1);
            client1.Adresse = "2 rue du Test";
            Console.WriteLine(client1);

            //compte
            Compte compte1 = new Compte(1, client1);
            Console.WriteLine(compte1);

            //dépot valide
            try
            {
                compte1.Déposer(0);
            } catch(MontantInvalide mi)
            {
                Console.WriteLine(mi.Message);
            }

            //retrait invalide
            try
            {
                compte1.Retirer(1);
            } catch(MontantExcessif me)
            {
                Console.WriteLine(me.Message);
            }

            //dépot valide
            compte1.Déposer(4);
            Console.WriteLine(compte1);
            
            //retrait valide
            compte1.Retirer(2);
            Console.WriteLine(compte1);

            //banque
            Banque banque1 = new Banque();

            //ajout client
            banque1.Ajouter(client1);

            //client existant
            Console.WriteLine(banque1.Client("Dupont", "Jean"));
            //client inexistant
            Console.WriteLine(banque1.Client("Dupont", "Grégoire"));

            //ajout compte
            banque1.Ajouter(compte1);
            //compte existant
            Console.WriteLine(banque1.Compte(1));
            //compte inexistant
            try
            {
                banque1.Compte(2);
            }
            catch (CompteInexistant ci)
            {
                Console.WriteLine(ci.Message);
            }

            //création de compte
            banque1.CreerCompte(2, client1);
            Console.WriteLine(banque1.Compte(2));

            //indexeur get
            Console.WriteLine(banque1[0]);

            //indexeur set
            Client client2 = new Client("Bon", "Jean");
            banque1[1] = new Compte(3, client2);
            Console.WriteLine(banque1[1]);

            //compte à découvert autorisé
            CompteADecouvertAutorisé compteDecouvert1 = new CompteADecouvertAutorisé(1, client1, 100);

            //retrait valide
            compteDecouvert1.Retirer(100);
            Console.WriteLine(compteDecouvert1);

            //retrait invalide
            try
            {
                compteDecouvert1.Retirer(1);
            }
            catch (MontantExcessif me)
            {
                Console.WriteLine(me.Message);
            }
        }
    }
}
