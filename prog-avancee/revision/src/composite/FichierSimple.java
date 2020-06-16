package composite;

public class FichierSimple extends Fichier {
    public FichierSimple(String name) {
        super(name);
    }

    @Override
    public String tree(String prefix) {
        return this.name + "\n";
    }
}
