package domain;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;

public class Todo {
    private String text;
    private boolean done;

    public Todo() {
        text = "";
        done = false;
    }

    public Todo(String text) {
        this.text = text;
    }

    public String toString() {
        StringBuffer sb = new StringBuffer();
        sb.append(done ? "X " : " ");
        sb.append(text);
        return sb.toString();
    }

    public String text() {
        return text;
    }

    public boolean isDone() {
        return done;
    }

    public void done() {
        done = true;
    }

    public void save(DataOutputStream output) throws IOException {
        output.writeUTF(text);
        output.writeBoolean(done);
    }

    public void load(DataInputStream input) throws IOException {
        text = input.readUTF();
        done = input.readBoolean();
    }
}
