package fabrique;

public class FabriqueVoiture {

    public static Voiture construireVoiture(String marque, String immatriculation) throws Exception {
        Voiture voiture = null;

        switch (marque) {
            case "ferrari":
                voiture = new Ferrari(immatriculation);
                break;
            case "peugeot":
                voiture = new Peugeot(immatriculation);
                break;
            default:
                throw new Exception("elle existe pas ta voiture connard");
        }

        return voiture;
    }
}
