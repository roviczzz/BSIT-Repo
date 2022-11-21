// AUTHOR: Rovic Rodriguez 
package Rodriguez_OOP;

public class RodriguezOverloading {
    
    public void print(int num){
        System.out.println("int datatype goes here");
        System.out.println("int: " + num);
        System.out.println("");
    }
    public void print(double num) {
        System.out.println("double datatype goes here");
        System.out.println("double: " + num);
        System.out.println("");
    }
    public void print(String text) {
        System.out.println("String datatype goes here");
        System.out.println("String: " + text);
        System.out.println("");
    }
    public void print(int num1,int num2) {
        System.out.println("two int datatype goes here");
        System.out.println("int: " + num1 + " int: " + num2 );
        System.out.println("");
    }
    
}
