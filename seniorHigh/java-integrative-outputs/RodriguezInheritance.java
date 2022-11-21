// AUTHOR: Rovic Rodriguez
package Rodriguez_OOP;

public class RodriguezInheritance {
    
    public static void main(String [] args){
        
        RodriguezSUB1 kb1 = new RodriguezSUB1();
        RodriguezSUB2 kb2 = new RodriguezSUB2();
        
        // Keyboard 1
        kb1.Layout();
        kb1.Language();
        kb1.connectivity();
        kb1.keyboardSize();
        kb1.keyboardSwitch();
        
        // Keyboard 2
        kb2.Layout();
        kb2.Language();
        kb2.connectivity();
        kb2.keyboardSize();
        kb2.keyboardSwitch();

    }
    
}
