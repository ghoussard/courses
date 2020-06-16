package domaine;

public class Mesure {

    private long horodatage;

    private double temperature;

    private double tauxHumidite;

    private double pression;

    public Mesure(long horodatage, double temperature, double tauxHumidite, double pression) {
        this.horodatage = horodatage;
        this.temperature = temperature;
        this.tauxHumidite = tauxHumidite;
        this.pression = pression;
    }

    public long getHorodatage() {
        return horodatage;
    }

    public double getTemperature() {
        return temperature;
    }

    public double getTauxHumidite() {
        return tauxHumidite;
    }

    public double getPression() {
        return pression;
    }

    @Override
    public String toString() {
        return "Mesure{" +
                "horodatage=" + horodatage +
                ", temperature=" + temperature +
                ", tauxHumidite=" + tauxHumidite +
                ", pression=" + pression +
                '}';
    }
}
