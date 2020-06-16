package domaine;

public class Equation {

    private double a;
    private double b;
    private double c;

    public Equation(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double valeurPour(double x) {
        double res = c;
        res += b * x;
        res += a * x * x;
        return res;
    }

    private double delta() {
        return b * b - 4 * a * c;
    }

    public double zero1() {
        return (-b - Math.sqrt(delta())) / (2 * a);
    }

    public double zero2() {
        return (-b + Math.sqrt(delta())) / (2 * a);
    }

    public String toString() {
        String txt = "y = ";
        txt += a + ".x^2 ";
        if(b >= 0) txt += "+ ";
        txt += b + ".x";
        if(c >= 0) txt += "+ ";
        txt += c;
        return txt;
    }

    public int nombreDeZerosReels() {
        if(a == 0) {
            if(b == 0) {
                if(c == 0) {
                    return Integer.MAX_VALUE;
                } else {
                    return 0;
                }
            } else {
                return 1;
            }
        } else {
            if(delta() > 0) {
                return 2;
            } else {
                return 0;
            }
        }
    }
}
