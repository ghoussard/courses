package aifcc;

import java.util.ArrayList;
import java.util.List;

public class Building {

    private List<Door> doors;

    private static Building instance;

    public static Building build(String[] names) throws BuildingWithoutDoorException {
        if(instance == null) {
            instance = new Building(names);
        }

        return instance;
    }

    private Building(String[] names) throws BuildingWithoutDoorException {
        if(names.length < 1) {
            throw new BuildingWithoutDoorException("Impossible de créer un batiment sans porte");
        }

        doors = new ArrayList<Door>();
        for (String name : names) {
            doors.add(new Door(name));
        }
    }

    /**
     * @return List<String> List of building door names
     */
    public List<String> getDoorsName() {
        List<String> names = new ArrayList<String>();

        for (Door door : doors) {
           names.add(door.getName());
        }

        return names;
    }

    /**
     * Count the persons who are presents into building
     * @return int number of persons into building
     */
    public int countPersons() {
        int countPersons = 0;

        //fetch doors and accumulate balances
        for (Door door : doors) {
            countPersons += door.balance();
        }

        return countPersons;
    }

    /**
     * @return boolean true if building is empty
     */
    public boolean isEmpty() {
        return countPersons() == 0;
    }

    /**
     * Enter into building
     * @param doorName door name through which enter
     */
    public void enter(String doorName) {
        searchDoorByName(doorName).enter();
    }

    /**
     * Exit from building
     * @param doorName door name through which exit
     */
    public void exit(String doorName) throws EmptyBuildingException {
        if(countPersons() == 0) {
            throw new EmptyBuildingException("Impossible de faire sortir une personne d'un batiment vide");
        }

        searchDoorByName(doorName).exit();
    }

    /**
     * Close building
     */
    public void close() {
        for(Door door : doors) {
            door.reset();
        }
    }

    @Override
    public String toString() {
        String string = "";
        for (Door door : doors) {
            string += door.toString() + "\n";
        }
        return string;
    }

    /**
     * Search a door by it name
     * @param doorName name of the searched door
     * @return Door found door
     */
    private Door searchDoorByName(String doorName) {
        //fetch door objects and return first object with matching name
        for (Door door : doors) {
            if(door.getName().equals(doorName)) {
                return door;
            }
        }
        return null;
    }
}
