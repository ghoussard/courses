package visiteur;

/**
 * VISITEUR
 */
public class HumainSilencieux extends Humain {
    @Override
    public void parler(Mot mot) {
        for(Character c : mot.getCharacters()) {
            System.out.print(c.toString().toLowerCase());
        }
    }
}
