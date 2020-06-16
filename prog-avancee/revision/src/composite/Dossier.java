package composite;

import java.util.ArrayList;

public class Dossier extends Fichier {

    private ArrayList<Fichier> fichiers;

    public Dossier(String name) {
        super(name);
        fichiers = new ArrayList<Fichier>();
    }

    public void ajouter(Fichier fichier) {
        fichiers.add(fichier);
    }

    public String tree(String prefix) {
        StringBuilder sb = new StringBuilder();

        sb.append(name + "\n");

        for(Fichier fichier : fichiers) {
            String newPrefix = prefix + '-';
            sb.append(newPrefix + " " + fichier.tree(newPrefix));
        }

        return sb.toString();
    }
}
