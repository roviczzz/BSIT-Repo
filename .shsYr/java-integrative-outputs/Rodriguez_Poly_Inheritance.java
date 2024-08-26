// AUTHOR: Rovic Rodriguez
package Rodriguez_OOP;

class flightFormat{
    public void Destination(){
        System.out.println("Destination 1 to Destination 2");
    }
}

class flight1 extends flightFormat{
    public void Destination(){
        System.out.println("Manila to Tokyo");
    }
}

class flight2 extends flightFormat{
    public void Destination(){
        System.out.println("Manila to Taipei");
    }
}

public class Rodriguez_Poly_Inheritance {
    
    public static void main (String[] args){
    
    // Default Flight    
//    Flight f = new Flight();
//    f.Destination();
    
    // Flight 1
//    Flight1 f = new Flight1();
//    f.Destination();
    
    // Flight 2
    flight2 f = new flight2();
    f.Destination();
    }
    
}
