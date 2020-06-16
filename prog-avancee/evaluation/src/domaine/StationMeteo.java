package domaine;

import java.util.LinkedList;
import java.util.List;

public class StationMeteo {
    private static class Capteur {
        public static Mesure faireUneMesure() {
            // System.currentTimeMillis() retourne un timestamp en millisecondes, il faut le diviser par 1000 pour l'avoir en secondes
            long horodatage = System.currentTimeMillis() / 1000;
            // Valeurs aléatoires pour que des mesures différentes soient mesurées à chaque appel
            double temperature = 25 + Math.random() * 15;
            double tauxHumidite = Math.random() * 75;
            double pression = 5 + Math.random() * 15;

            return new Mesure(horodatage, temperature, tauxHumidite, pression);
        }
    }

    private String name;

    private Releve releve;

    private List<Abonne> abonnes;

    public StationMeteo(String name) {
        this.name = name;
        this.releve = new Releve();
        this.abonnes = new LinkedList<>();
    }

    public String getName() {
        return name;
    }

    public Releve getReleve() {
        return releve;
    }

    public void ajouterUnAbonne(Abonne abonne) {
        abonnes.add(abonne);
    }

    public void retirerUnAbonne(String nomAbonne) {
        for (Abonne abonne : abonnes) {
            if(abonne.getName().equals(nomAbonne)) {
                abonnes.remove(abonne);
                break;
            }
        }
    }

    public int getNombreAbonnes() {
        return abonnes.size();
    }

    private void notifier() {
        for(Abonne abonne : abonnes) {
            abonne.notifier(this);
        }
    }

    public void effectuerUneMesure() {
        Mesure nouvelleMesure = Capteur.faireUneMesure();
        releve.ajouterMesure(nouvelleMesure);
        notifier();
    }

    public Mesure getDerniereMesure() {
        return releve.getMesure(releve.getNombreMesures() - 1);
    }
}
