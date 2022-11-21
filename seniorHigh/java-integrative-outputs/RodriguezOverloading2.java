// AUTHOR: Rovic Rodriguez 
package Rodriguez_OOP;

public class RodriguezOverloading2 {
    
    public void print(int num){
        System.out.println("Input number: " + num);
        int sqrt = num * num;
        System.out.println("The square of integer " + num + " is " + sqrt);
        System.out.println("");
    }
    public void print(double num){
        System.out.println("Input number: " + num);
        double sqrt = num * num;
        System.out.println("The square of double " + num + " is " + sqrt);
        System.out.println("");
    }
    
    public static void main(String [] args){
        RodriguezOverloading2 object1 = new RodriguezOverloading2();
        
        object1.print(7);
        object1.print(7.5);
    
    }
}
