import composite.Dossier;
import composite.Fichier;
import composite.FichierSimple;
import fabrique.FabriqueVoiture;
import fabrique.Ferrari;
import fabrique.Peugeot;
import fabrique.Voiture;
import singleton.Launcher;
import visiteur.*;

import java.util.LinkedList;

public class Main
{
    // SINGLETON
//    public static void main(String[] args) {
//        Launcher launcher = Launcher.getLauncher("test");
//        Launcher launcher2 = Launcher.getLauncher("test2");
//        System.out.println(launcher);
//        System.out.println(launcher2);
//    }

    // FABRIQUE
//    public static void main(String[] args) throws Exception {
//        String marque = "renault";
//        String immatriculation = "GAHHAJJZ";
//
//        Voiture voiture = FabriqueVoiture.construireVoiture(marque, immatriculation);
//
//        System.out.println(voiture);
//    }

//    public static void main(String[] args) {
//        // Création du premier mot : Ave
//        LinkedList<Character> characters1 = new LinkedList<>();
//        characters1.add('A');
//        characters1.add('v');
//        characters1.add('e');
//
//        Mot mot1 = new Mot(characters1);
//
//        // Création du deuxième mot : Brutus
//        LinkedList<Character> characters2 = new LinkedList<>();
//        characters2.add('B');
//        characters2.add('r');
//        characters2.add('u');
//        characters2.add('t');
//        characters2.add('u');
//        characters2.add('s');
//
//        Mot mot2 = new Mot(characters2);
//
//        LinkedList<Mot> mots = new LinkedList<Mot>();
//        mots.add(mot1);
//        mots.add(mot2);
//
//        Phrase phrase = new Phrase(mots);
//
//        Humain humain = new Humain();
//        HumainBruyant humainB = new HumainBruyant();
//        HumainSilencieux humainSilencieux = new HumainSilencieux();
//
//        phrase.seDit(humain);
//        System.out.println();
//        phrase.seDit(humainB);
//        System.out.println();
//        phrase.seDit(humainSilencieux);
//    }

    public static void main(String[] args) {
        Dossier root = new Dossier("/");
            Dossier etc = new Dossier("etc");
                Dossier test = new Dossier("test");
                    FichierSimple testf = new FichierSimple("test.conf");
            FichierSimple coucou = new FichierSimple("coucou.txt");


        test.ajouter(testf);
        etc.ajouter(test);

        etc.ajouter(new FichierSimple("test2.jpg"));

        root.ajouter(etc);
        root.ajouter(coucou);

        System.out.println(root.tree(""));
    }
}
