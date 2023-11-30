package BinaryTree;

import java.util.Scanner;

public class Rodriguez_BinaryTree {
    public static class Node {
        int data;
        Node left;
        Node right;

        public Node(int value) {

            this.data = value;
            this.left = null;
            this.right = null;
        }
    }

    public static void insertNode(Node node, int value) {

        if (value <= node.data) {
            if (node.left == null) {
                node.left = new Node(value);
                System.out.println("Inserted " + value + " at the left of " + node.data);
            } else {
                insertNode(node.left, value);
            }
        }

        if (value > node.data) {
            if (node.right == null) {
                node.right = new Node(value);
                System.out.println("Inserted " + value + " at the right of " + node.data);
            } else {
                insertNode(node.right, value);
//                insertNode(node.left, value);
            }
        }

    }

    public static void printTree(Node node) {
        if (node != null) {
            System.out.print(node.data + "-");
            printTree(node.right);
        }
    }

    public static void preOrder(Node node) {
        if (node != null) {
            System.out.print(node.data + "-");
            preOrder(node.left);
            preOrder(node.right);

        }
    }

    public static void inOrder(Node node){
        if(node != null){
            inOrder(node.left);
            System.out.print(node.data + "-");
            inOrder(node.right);

        }
    }

    public static void postOrder(Node node){
        if(node != null){
            postOrder(node.left);
            postOrder(node.right);
            System.out.print(node.data + "-");
        }
    }

    static int sum = 0;

    public static int nodeSum(Node node) {
        if (node != null) {

            int data = node.data;
            sum = sum + node.data;

            nodeSum(node.left);
            nodeSum(node.right);
        }
        return sum;
    }

    public static int countLeaf(Node node){
        if (node == null){
            return 0;
        }
        if (node.left == null && node.right == null){
            return 1;
        }
        else{
            return countLeaf(node.left) + countLeaf(node.right);
        }
    }

    public static int getLevel(Node node){
        if (node == null){
            return 0;
        }
        else{
            int leftLevel = getLevel(node.left);
            int rightLevel = getLevel(node.right);

            return Math.max(leftLevel,rightLevel) + 1;
        }
    }

    public static void main(String[] args) {
        Node root = new Node(10);
        root.left = new Node(7);
        root.right = new Node(12);
        root.left.left = new Node(21);
        root.right.right = new Node(27);
        root.left.right = new Node(3);
        Scanner sc = new Scanner(System.in);

        while(true){
            System.out.println("Binary Tree Program");
            System.out.print("Enter a value: ");
            int input = sc.nextInt();

            System.out.println();
            insertNode(root, input);

            System.out.print("preOrder: ");
            preOrder(root);

            System.out.println();
            System.out.print("inOrder: ");
            inOrder(root);

            System.out.println();
            System.out.print("postOrder: ");
            postOrder(root);

            System.out.println();
            System.out.println("Tree levels: " + getLevel(root));

            System.out.println();
            System.out.println("Sum of all values: " + nodeSum(root));

            System.out.println();
            System.out.println("Leaf count: " + countLeaf(root));

            System.out.println("Add another value? Y/N");
            char response = sc.next().charAt(0);

            if (response == 'Y'){
                System.out.println("Proceed...");
                sum = 0;
            }
            else if (response == 'N'){
                break;
            }
        }
    }
}
