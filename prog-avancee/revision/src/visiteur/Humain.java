package visiteur;

/**
 * VISITEUR
 */
public class Humain implements Parleur {
    @Override
    public void parler(Phrase phrase) {
        for (Mot mot : phrase.getMots())  {
            parler(mot);
            System.out.print(" ");
        }
    }

    @Override
    public void parler(Mot mot) {
        for(Character c : mot.getCharacters()) {
            System.out.print(c.toString());
        }
    }
}
