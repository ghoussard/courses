package fabrique;

public class Ferrari extends Voiture {

    public Ferrari(String imatriculation) {
        this.imatriculation = imatriculation;
        this.patate = 1000;
    }

    @Override
    void rouler() {
        System.out.println("vroum vroum");
    }
}
