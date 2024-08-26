package RodriguezGUIintroduction;

public class RodriguezConstructorUI {
    // Declaration of int
    int prime1, prime2, prime3;

    // Assigning values to int from public
    public RodriguezConstructorUI() {
        prime1 = 2;
        prime2 = 3;
        prime3 = 5;
    }

    public static void main(String[] args) {

        // Creation of object to call public method
        RodriguezConstructorUI myObj = new RodriguezConstructorUI();

        // Output with the created object
        System.out.println("The examples of prime numbers are: " + myObj.prime1 + ", "
        + myObj.prime2 +", and "+ myObj.prime3);
    }
}
