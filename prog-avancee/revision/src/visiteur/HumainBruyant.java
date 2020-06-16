package visiteur;

/**
 * VISITEUR
 */
public class HumainBruyant extends Humain {
    @Override
    public void parler(Mot mot) {
        for(Character c : mot.getCharacters()) {
            System.out.print(c.toString().toUpperCase());
        }
    }
}
