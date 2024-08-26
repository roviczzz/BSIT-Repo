// AUTHOR: Rovic Rodriguez
package Rodriguez_OOP;

public class RodriguezEncapsulation {
    private String name;
    private String section;
    
    public String getName(){
        return name;
    }
    
    public String getSection(){
        return section;
    }
    
    public void SetName(String newName){
        name = newName;
    }
    public void SetSection(String newSection) {
        section = newSection;
    }
    
    public static void main(String [] args){
    RodriguezEncapsulation encap = new RodriguezEncapsulation();
    encap.SetName("Rovic");
    encap.SetSection("ICT21");
    
    System.out.println("Name: " + encap.getName());
    System.out.println("Section: " + encap.getSection());
    
    }
    
}
