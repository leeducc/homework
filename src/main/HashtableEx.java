package main;

import java.util.Hashtable;

public class HashtableEx {
    public static void main(String[] args) {
        Hashtable<String, Integer> hashtable = new Hashtable<>();
        hashtable.put("Alice", 25);
        hashtable.put("Bob", 30);
        hashtable.put("Charlie", 28);
        hashtable.put("David", 35);
        System.out.println("Tuổi của Alice: " + hashtable.get("Alice"));

        if (hashtable.containsKey("Bob")) {
            System.out.println("Bob có trong danh sách, tuổi: " + hashtable.get("Bob"));
        }
        hashtable.remove("Charlie");
        for (String key : hashtable.keySet()) {
            System.out.println(key + ": " + hashtable.get(key));
        }
        System.out.println("Số lượng người trong Hashtable: " + hashtable.size());
    }
}


