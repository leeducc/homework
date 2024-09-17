package entity;

import entity.Node;

public class LinkedList {
    Node head;
    public void insert(int data){
        Node newNode = new Node(data);
        if (head == null){
            head = newNode;

        }else{
            Node temp = head;
            while(temp.next!=null){
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }
}
