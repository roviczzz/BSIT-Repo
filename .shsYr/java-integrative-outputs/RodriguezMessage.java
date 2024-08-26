// AUTHOR: Rovic Rodriguez
package Rodriguez_OOP;

public class RodriguezMessage {
    
    public static void main(String[] args){
        color();
        color2();
    
    }
    
    public static void color() {
        System.out.println("RED");
    
    }
    
    public static void color2() {
        System.out.println("BLUE");
        RodriguezMessage.color();
    }
}
