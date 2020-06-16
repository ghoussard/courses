import domain.TodoList;
import domain.Todo;

import java.io.*;

import static utils.TUI.*;

public class Main {
    private static int index(String question, int max) {
        int index;
        do {
            index = Entier(question);
        } while (index < 0 || index > max);
        return index;
    }

    private static void afficher(TodoList pb) {
        int numero = 1;
        for (Todo todo : pb) {
            System.out.println(numero + ") " + todo);
            numero++;
        }
    }

    public static void main(String[] args) {
        TodoList todoList = new TodoList();

        try (DataInputStream input = new DataInputStream(new FileInputStream("save.todolist"))) {
            byte version = input.readByte();
            if(version != 1) throw new IOException("Version de fichier inconnue");
            todoList.load(input);
        } catch (IOException e) {
            System.err.println(e);
        }

        char choix;
        int index;

        do {
            afficher(todoList);
            choix = Caractère("a)jouter f)inir s)upprimer q)uitter ?");
            switch (choix) {
                case 'a':
                    todoList.add(Chaîne("Ajouter quoi ?"));
                    break;
                case 'f':
                    index = index("Finir quoi (numéro) ?", todoList.count());
                    if(index > 0) {
                        todoList.done(index-1);
                    }
                    break;
                case 's':
                    index = index("Supprimer quoi (numéro) ?", todoList.count());
                    if(index > 0) {
                        todoList.remove(index-1);
                    }
                default:
                    break;
            }
        } while (choix != 'q');

        try {
            DataOutputStream output = new DataOutputStream(new FileOutputStream("save.todolist"));
            output.writeByte(1);
            todoList.save(output);
        } catch (IOException e) {
            System.err.println(e);
        }
    }
}
