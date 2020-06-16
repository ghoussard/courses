package aifcc;

class Door {
    private class Counter {
        private int count;

        public Counter() {
            count = 0;
        }

        public void reset() {
            count = 0;
        }

        public void increment() {
            count++;
        }

        public int getCount() {
            return count;
        }

        @Override
        public String toString() {
            return count + "";
        }
    }

    private String name;

    private Counter entries;

    private Counter exits;

    public Door(String name) {
        this.name = name;

        entries = new Counter();
        exits = new Counter();
    }

    public String getName() {
        return name;
    }

    /**
     * @return int balance between entries and exit
     */
    public int balance() {
        return entries.getCount() - exits.getCount();
    }

    /**
     * Add an entry
     */
    public void enter() {
        entries.increment();
    }

    /**
     * Add an exit
     */
    public void exit() {
        exits.increment();
    }

    /**
     * Reset entries and exits
     */
    public void reset() {
        entries.reset();
        exits.reset();
    }

    @Override
    public String toString() {
        return "porte " + name + " : " + entries + " entrée, " + exits + " sortie";
    }
}
