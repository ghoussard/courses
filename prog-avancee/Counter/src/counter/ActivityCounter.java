package counter;

public class ActivityCounter extends Counter {
    private static final float MIN_STEP = 0.5f;
    private static final float MAX_STEP = 0.8f;

    private float stepLength;

    public ActivityCounter() {
        super();
        stepLength = 0.64f;
    }

    public void setStepLength(float stepLength) throws InvalidStepLengthValueException {
        if(stepLength < MIN_STEP) {
            throw new InvalidStepLengthValueException("La valeur de pas ne doit pas être inférieure à " + MIN_STEP + " mètre");
        } else if(stepLength > MAX_STEP) {
            throw new InvalidStepLengthValueException("La valeur de pas ne doit pas être supérieure à " + MAX_STEP + " mètre");
        }

        this.stepLength = stepLength;
    }

    public float distance() {
        return value() * stepLength;
    }
}
