package singleton;

public class Launcher {

    private String name;

    private static Launcher instance = null;

    private Launcher(String name) {
        this.name = name;
    }

    public static Launcher getLauncher(String name) {
        if(instance == null) {
            instance = new Launcher(name);
        }
        return instance;
    }
}
