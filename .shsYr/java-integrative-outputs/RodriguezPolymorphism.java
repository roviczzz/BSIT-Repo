// AUTHOR: Rovic Rodriguez
package Rodriguez_OOP;

class Flight{
    public void Destination(){
        System.out.println("Destination 1 to Destination 2");
    }
}

class Flight1 extends Flight{
    public void Destination(){
        System.out.println("Manila to Tokyo");
    }
}

class Flight2 extends Flight{
    public void Destination(){
        System.out.println("Manila to Taipei");
    }
}

public class RodriguezPolymorphism {
    
    public static void main (String[] args){
    
    // Default Flight    
//    Flight f = new Flight();
//    f.Destination();
    
    // Flight 1
//    Flight1 f = new Flight1();
//    f.Destination();
    
    // Flight 2
    Flight2 f = new Flight2();
    f.Destination();
    }
    
}
