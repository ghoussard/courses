package application;

import domaine.Abonne;
import domaine.StationMeteo;

import java.util.concurrent.TimeUnit;

public class Main {
    public static void main(String[] args) {
        // on crée un nouvelle station
        StationMeteo stationMeteo = new StationMeteo("Pic du Midi");
        System.out.println("Station météo créée!");

        // on crée deux abonnés pour notre station
        Abonne gregoire = new Abonne("Grégoire");
        Abonne jacques = new Abonne("Jacques");

        System.out.print("\n");

        // pour le moment, seulement grégoire s'abonne à la station
        stationMeteo.ajouterUnAbonne(gregoire);
        System.out.println("Grégoire s'est abonné à la station!");

        // la station effectue une première mesure
        stationMeteo.effectuerUneMesure();
        System.out.println("La station a effectué une mesure!");

        // grégoire se retrouve bien notifié de la dernière mesure mais pas jacques car il n'est pas encore abonné
        System.out.print("Dernière mesure de la station météo : ");
        System.out.println(stationMeteo.getDerniereMesure());
        System.out.print("Nombre de notifications de Grégoire : ");
        System.out.println(gregoire.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Grégoire : ");
        System.out.println(gregoire.getDerniereMesureNotifiee());
        System.out.print("Nombre de notifications de Jacques : ");
        System.out.println(jacques.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Jacques : ");
        System.out.println(jacques.getDerniereMesureNotifiee());

        System.out.print("\n");

        // jacques s'abonne aussi à la station
        stationMeteo.ajouterUnAbonne(jacques);
        System.out.println("Jacques s'est abonné à la station!");

        stationMeteo.effectuerUneMesure();
        System.out.println("La station a effectué une mesure!");

        // les deux abonnés sont notifiés
        System.out.print("Dernière mesure de la station météo : ");
        System.out.println(stationMeteo.getDerniereMesure());
        System.out.print("Nombre de notifications de Grégoire : ");
        System.out.println(gregoire.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Grégoire : ");
        System.out.println(gregoire.getDerniereMesureNotifiee());
        System.out.print("Nombre de notifications de Jacques : ");
        System.out.println(jacques.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Jacques : ");
        System.out.println(jacques.getDerniereMesureNotifiee());

        System.out.print("\n");

        stationMeteo.retirerUnAbonne("Grégoire");
        System.out.println("Grégoire s'est désabonné de la station!");

        stationMeteo.effectuerUneMesure();
        System.out.println("La station a effectué une mesure!");

        // seul jacques est notifié car Grégoire s'est désabonné de la station
        System.out.print("Dernière mesure de la station météo : ");
        System.out.println(stationMeteo.getDerniereMesure());
        System.out.print("Nombre de notifications de Grégoire : ");
        System.out.println(gregoire.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Grégoire : ");
        System.out.println(gregoire.getDerniereMesureNotifiee());
        System.out.print("Nombre de notifications de Jacques : ");
        System.out.println(jacques.getNombreDeNotifications());
        System.out.print("Dernière mesure notifiée de Jacques : ");
        System.out.println(jacques.getDerniereMesureNotifiee());
    }
}
