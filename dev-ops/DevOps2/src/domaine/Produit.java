package domaine;

public class Produit {

    private String nom;
    private float prix;

    public Produit(String nom, float prix) {
        this.nom = nom;
        this.prix = prix;
    }

    public String getNom() {
        return nom;
    }

    public float getPrix() {
        return prix;
    }

    public void changePrix(float nouveauPrix) {
        prix = nouveauPrix;
    }

    public String toString() {
        return nom + " (" + prix + ")";
    }
}
