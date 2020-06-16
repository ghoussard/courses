import counter.ActivityCounter;
import counter.InvalidStepLengthValueException;
import io.TUI;

public class Main {
    public static void main(String[] arg) {
        ActivityCounter counter = new ActivityCounter();

        do {
            int choice = TUI.Entier("Action ?\n1) Faire un pas\n2) Afficher la distance\n3) Remettre à zéro\n4) Changer la valeur de pas\n5) Quitter\n");

            switch (choice) {
                case 1:
                    counter.increment();
                    System.out.println("Nombre de pas : " + counter.value() + "\n");
                    break;
                case 2:
                    System.out.println("Distance parcourue : " + counter.distance() + "m\n");
                    break;
                case 3:
                    counter.reset();
                    System.out.println("Nombre de pas remis à zéro\n");
                    break;
                case 4:
                    float stepLength = TUI.Décimal("Quelle est la valeur d'un pas (en m) ?");
                    try {
                        counter.setStepLength(stepLength);
                        System.out.println("Valeur de pas modifiée");
                    } catch (InvalidStepLengthValueException e) {
                        System.err.println(e);
                    }
                    System.out.println();
                    break;
                case 5:
                    System.out.println("Arrêt du programme");
                    System.exit(0);
                default:
                    System.out.println("Option non reconnue\n");
                    break;
            }
        } while (true);
    }
}
