package visiteur;

import java.util.LinkedList;

public class Mot implements Parlable {
    private LinkedList<Character> characters;

    public Mot(LinkedList<Character> characters) {
        this.characters = characters;
    }

    public LinkedList<Character> getCharacters() {
        return characters;
    }

    @Override
    public void seDit(Parleur parleur) {
        parleur.parler(this);
    }
}
