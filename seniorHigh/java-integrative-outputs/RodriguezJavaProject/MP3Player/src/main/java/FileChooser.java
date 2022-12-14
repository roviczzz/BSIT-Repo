import java.util.Scanner;
import javax.swing.JFileChooser;
/**
 *
 * @author rovic
 */
public class FileChooser {
    
    public static void main(String[] args){
        JFileChooser fc = new JFileChooser();
        fc.setCurrentDirectory(new java.io.File("C:/Users/rovic/Desktop"));
        fc.setDialogTitle("Select an mp3 file");
        fc.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
        

      
    }
    
}
