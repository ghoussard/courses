package counter;

class Counter {
    private int count;

    public void increment() {
        count++;
    }

    public void reset() {
        count = 0;
    }

    public int value() {
        return count;
    }
}
