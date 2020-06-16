package domain;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.util.*;
import java.util.function.Consumer;

public class TodoList implements Iterable<Todo> {
    private List<Todo> list;

    public TodoList() {
        list = new LinkedList<Todo>();
    }

    public void add(String todoText) {
        list.add(new Todo(todoText));
    }

    public boolean isEmpty() {
        return list.isEmpty();
    }

    public int count() {
        return list.size();
    }

    public void remove(String todoText) {
        list.removeIf(todo -> todoText.equals(todo.text()));
    }

    public void remove(int todoIndex) {
        list.remove(todoIndex);
    }

    public void done(String todoText) {
        for (Todo todo : list) {
            if (todo.text().equals(todoText)) {
                todo.done();
            }
        }
    }

    public void done(int todoIndex) {
        list.get(todoIndex).done();
    }

    @Override
    public Iterator<Todo> iterator() {
        return list.iterator();
    }

    @Override
    public void forEach(Consumer action) {

    }

    @Override
    public Spliterator spliterator() {
        return null;
    }

    public void save(DataOutputStream output) throws IOException {
        output.writeInt(count());
        for (Todo todo : list) {
            todo.save(output);
        }
    }

    public void load(DataInputStream inputStream) throws IOException {
        int n = inputStream.readInt();
        for(int i = 0; i < n; i++) {
            Todo todo = new Todo();
            todo.load(inputStream);
            list.add(todo);
        }
    }


}
