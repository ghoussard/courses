package tests;

import domaine.Produit;
import domaine.Stock;
import org.junit.Test;

import static org.junit.Assert.*;

public class StockTest {
    @Test
    public void test01NouveauStock() {
        Stock s = new Stock();
        assertEquals(0, s.nombreDeProduits());
        assertEquals(0.0, s.valeur(), 0.00001);
    }

    @Test
    public void test02AjoutProduit() {
        final float prix1 = 10.5f;
        final float prix2 = 8.5f;
        Stock s = new Stock();
        s.ajoute(new Produit("produit1", prix1));
        assertEquals(1, s.nombreDeProduits());
        assertEquals(10.5f, s.valeur(), 0.00001);
        s.ajoute(new Produit("produit2", prix2));
        assertEquals(2, s.nombreDeProduits());
        assertEquals(prix1 + prix2, s.valeur(), 0.00001);
    }

    @Test
    public void test03AjoutProduit() {
        final float prix1 = 10.5f;
        final int qte1 = 5;
        Stock s = new Stock();
        s.ajoute(new Produit("produit1", prix1), qte1);
        assertEquals(1, s.nombreDeProduits());
        final float prix2 = 8.5f;
        final int qte2 = 2;
        s.ajoute(new Produit("produit2", prix2), qte2);
        assertEquals(2, s.nombreDeProduits());
        assertEquals(qte1 * prix1 + qte2 * prix2, s.valeur(), 0.00001);
    }

    public void test04RetraitProduit() {
        final String nom1 = "un";
        final float prix1 = 10.5f;
        final int qte1 = 5;
        Stock s = new Stock();
        s.ajoute(new Produit(nom1, prix1), qte1);
        s.retire(nom1, 2);
        assertEquals(2, s.nombreDeProduits());
    }
}