package domaine;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;

public class Releve implements Iterable<Mesure> {
    private List<Mesure> mesures;

    public Releve() {
        this.mesures = new LinkedList<>();
    }

    public void ajouterMesure(Mesure mesure) {
        mesures.add(mesure);
    }

    public int getNombreMesures() {
        return mesures.size();
    }

    public Mesure getMesure(int numero) {
        Mesure mesure = null;
        if(numero >= 0) {
            mesure = mesures.get(numero);
        }
        return mesure;
    }

    public void vider() {
        mesures.clear();
    }

    public Iterator<Mesure> iterator() {
        return mesures.iterator();
    }
}
