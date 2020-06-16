package programme;

import domaine.Equation;

public class CLI {
    public static void main(String[] args) {
        Equation eq;
        eq = new Equation(1, 2, 3);
        for(double x = 0; x < 10; x += 0.25) {
            System.out.print("avec x = " + x + ", ");
            System.out.print(eq);
            System.out.println(" vaut " + eq.valeurPour(x));
        }
        System.out.println(eq + " a " + eq.nombreDeZerosReels() + " zéros réels.");
        System.out.println(eq.zero1());
        System.out.println(eq.zero2());
    }
}
