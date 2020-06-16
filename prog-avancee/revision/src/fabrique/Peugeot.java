package fabrique;

public class Peugeot extends Voiture {
    public Peugeot(String imatriculation) {
        this.imatriculation = imatriculation;
        this.patate = 10;
    }

    @Override
    void rouler() {
        System.out.println("vroum vroum");
    }
}
