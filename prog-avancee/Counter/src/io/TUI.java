package io;

import java.io.*;

public class TUI {
    private static String getString() {
        BufferedReader fe = new BufferedReader(new InputStreamReader(System.in));
        boolean erreur;
        String lu = null;
        do {
            try {
                erreur = false;
                lu = fe.readLine();
            } catch (IOException e) {
                System.out.println("Recommencez.");
                erreur = true;
            }
        } while (erreur);
        return lu;
    }
    private static char getChar() {
        String lu;
        boolean erreur;
        do {
            lu = getString();
            erreur = lu.equals("");
        } while (erreur);
        return lu.charAt(0);
    }
    private static int getInt() {
        boolean erreur;
        int lu = 0;
        do {
            try {
                erreur = false;
                lu = Integer.parseInt(getString());
            } catch (NumberFormatException e) {
                System.out.println("Veuillez entrer un entier!");
                erreur = true;
            }
        } while (erreur);
        return lu;
    }
    private static double getDouble() {
        boolean erreur;
        double lu = 0;
        do {
            try {
                erreur = false;
                lu = Double.parseDouble(getString());
            } catch (NumberFormatException e) {
                System.out.println("Veuillez entrer un nombre !");
                erreur = true;
            }
        } while (erreur);
        return lu;
    }
    private static float getFloat() {
        return (float)getDouble();
    }
    public static char Caractère(String Question) {
        System.out.print(Question);
        return getChar();
    }
    public static String Chaîne(String Question) {
        System.out.print(Question);
        return getString();
    }
    public static float Décimal(String Question) {
        System.out.print(Question);
        return getFloat();
    }
    public static int Entier(String Question) {
        System.out.print(Question);
        return getInt();
    }
    public static boolean Booléen(String Question) {
        System.out.print(Question);
        return getString().equals("oui");
    }
}