package com.mycompany.rodriguezbit21;
/**
 *
 * @author student
 */
public class LinkedList {
    Node head = null;
    
    public static LinkedList insertAtTheHead(LinkedList list, int value){
    
    Node newNode = new Node(value);
    
        if (list.head == null)
            list.head = newNode;
            else{
            newNode.link = list.head;
            list.head = newNode;
        }
            return list;
    }
    
    public static LinkedList insertAtTheTail(LinkedList list, int value){
        Node newNode = new Node(value);
        newNode.data = value;
        newNode.link = null;
        

        Node currentNode = list.head;
        while (currentNode.link != null){
        currentNode = currentNode.link;
        }
        currentNode.link = newNode;
        newNode.link = null;
        return list;
    }
        
    
    
 
    public static void printLinkedList(LinkedList list){
        Node currentNode = list.head;
        System.out.println("Linked List Data : ");
        while (currentNode != null){
            System.out.println(currentNode.data + "\t");
            currentNode = currentNode.link;
        }
    }
                

    public static void main(String[] args) {
        LinkedList list = new LinkedList();
        list = insertAtTheHead(list, 5);
        list = insertAtTheTail(list, 2);
        list = insertAtTheHead(list, 3);
        printLinkedList(list);
    }
}