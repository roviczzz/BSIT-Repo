import javax.swing.tree.TreeNode;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Scanner;

public class RodriguezBFS {
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
            }
        }

    }

    public static void printBreadth(Node node) {
        Queue<Node> queue = new LinkedList<Node>();
        queue.add(node);
        while (!queue.isEmpty()){
            Node tempNode = queue.poll();
            System.out.print(tempNode.data + " ");

            if (tempNode.left != null){
                queue.add(tempNode.left);
            }

            if (tempNode.right != null){
                queue.add(tempNode.right);
            }
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
        Node root = new Node(81);
        Scanner sc = new Scanner(System.in);

        while(true){
            System.out.println("Binary Tree Program");

            System.out.print("Enter a value: ");
            int input = sc.nextInt();

            System.out.println();
            insertNode(root, input);
            System.out.print("\n");


            System.out.print("Breath-first traversal: ");
            printBreadth(root);

            System.out.println();
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

