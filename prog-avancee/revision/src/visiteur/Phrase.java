package visiteur;

import java.util.LinkedList;

public class Phrase implements Parlable {
    private LinkedList<Mot> mots;

    public Phrase(LinkedList<Mot> mots) {
        this.mots = mots;
    }

    public LinkedList<Mot> getMots() {
        return mots;
    }

    @Override
    public void seDit(Parleur parleur) {
        parleur.parler(this);
    }
}
