package RodriguezGUIintroduction;

public class RodriguezMethodUI {

    // Declaration of static method
    static void LineOne(){
        System.out.println("Hello!");
        
    }
    // Declaration of public method
    public void LineTwo(){
        System.out.println("World!");

    }

    public static void main(String[] args) {
        LineOne();

        // Creation of object
        RodriguezMethodUI myObj = new RodriguezMethodUI();

        // Calling of public method
        myObj.LineTwo();
    }
    
}
