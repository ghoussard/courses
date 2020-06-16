package composite;

public abstract class Fichier {
    String name;

    public Fichier(String name) {
        this.name = name;
    }

    public void rename(String name) {
        this.name = name;
    }

    protected String getName() {
        return name;
    }

    public abstract String tree(String prefix);
}
