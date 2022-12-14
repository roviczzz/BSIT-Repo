// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;
import javax.swing.JFrame;

public class RodriguezApplet extends Applet {
    
   
    public void paint(Graphics g) {
        g.setColor(Color.blue);
        g.drawString("This is running on an APPLET Window", 10,20);
        
    }
}

