package domaine;

import javax.xml.stream.events.EndElement;
import java.lang.annotation.ElementType;
import java.util.LinkedList;
import java.util.List;

public class Stock {
    private class ElementDeStock {
        public Produit produit;
        public int quantite;
        public ElementDeStock(Produit produit, int quantite) {
            this.produit = produit;
            this.quantite = quantite;
        }
        public float valeur() {
            return produit.getPrix() * quantite;
        }
    }

    private List<ElementDeStock> contenu;

    public Stock() {
        contenu = new LinkedList<ElementDeStock>();
    }

    public int nombreDeProduits() {
        return contenu.size();
    }

    public float valeur() {
        float total = 0;
        for(ElementDeStock e : contenu) total += e.valeur();
        return total;
    }

    public void ajoute(Produit p) {
        contenu.add(new ElementDeStock(p, 1));
    }

    public void ajoute(Produit p, int quantite) {
        contenu.add(new ElementDeStock(p, quantite));
    }
    public void retire(String nomProduit, int qte) {
        for(ElementDeStock e : contenu) {
            if(nomProduit.equals(e.produit.getNom())) {
                e.quantite -= qte;
            }
        }
    }
}
