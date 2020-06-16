import aifcc.Building;
import aifcc.BuildingWithoutDoorException;
import aifcc.EmptyBuildingException;
import utils.TUI;

public class Simulation {
    public static void main(String [] args) {
        try {
            Building building = Building.build(args);

            do {
                System.out.println(building);
                printPersons(building);

                menu(building);
            } while (true);
        } catch (BuildingWithoutDoorException e) {
            System.err.println(e);
            System.exit(1);
        }
    }

    private static void menu(Building building) {
        char choice = TUI.Caractère("e)ntrer s)ortir f)ermer q)uitter ?");

        switch (choice) {
            case 'e':
                enter(building);
                break;
            case 's':
                exit(building);
                break;
            case 'f':
                closeBuilding(building);
                break;
            case 'q':
                System.exit(0);
                break;
        }
    }

    private static void enter(Building building) {
        String doorName = chooseDoor(building);

        if(doorName == null) {
            return;
        }

        building.enter(doorName);
    }

    private static void exit(Building building) {
        String doorName = chooseDoor(building);

        if(doorName == null) {
            return;
        }

        try  {
            building.exit(doorName);
        } catch (EmptyBuildingException e) {
            System.err.println(e);
        }
    }

    private static void closeBuilding(Building building) {
        if(building.isEmpty()) {
            System.out.println("Fermeture du batiment...");
            building.close();
            System.out.println("Le batiment est fermé");
        } else {
            System.out.println("Le batiment n'est pas vide !");
        }
    }

    private static String chooseDoor(Building building) {
        //build question
        String question =  "Par quelle porte ?\n0) pour annuler\n";
        int i = 1;
        for (String doorName : building.getDoorsName()) {
            question += i + ") " + doorName + "\n";
            i++;
        }

        boolean error = true;
        int choice = 0;
        while (error) {
            //get choice and check if correct
            choice = TUI.Entier(question);

            if (choice >= i) {
                System.out.println("Ce choix n'est pas proposé, recommencez");
            } else {
                error = false;
            }
        }

        //return doorName corresponding to choice
        return choice != 0 ? building.getDoorsName().get(choice-1) : null;
    }

    private static void printPersons(Building building) {
        if(building.isEmpty()) {
            System.out.println("Il n'y a personne dans le batiment");
        } else {
            System.out.println("Il y a " + building.countPersons() + " personne dans le batiment");
        }
    }
}
