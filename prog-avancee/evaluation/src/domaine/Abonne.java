package domaine;

public class Abonne {
    private String name;

    private Releve releve;

    public Abonne(String name) {
        this.name = name;
        this.releve = new Releve();
    }

    public Mesure getDerniereMesureNotifiee() {
        return releve.getMesure(releve.getNombreMesures() - 1);
    }

    public Releve getReleve() {
        return releve;
    }

    public int getNombreDeNotifications() {
        return releve.getNombreMesures();
    }

    public String getName() {
        return name;
    }

    public void notifier(StationMeteo stationMeteo) {
        releve.ajouterMesure(stationMeteo.getDerniereMesure());
    }
}
