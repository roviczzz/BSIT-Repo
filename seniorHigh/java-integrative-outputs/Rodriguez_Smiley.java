// AUTHOR: RODRIGUEZ, ROVIC

package RodriguezApplet;

import javax.swing.JApplet;
import java.awt.*;


public class Rodriguez_Smiley extends JApplet {

    public void paint(Graphics g){
        //HEAD
        g.fillOval(25, 25, 150, 150);
        g.setColor(Color.yellow);
        g.fillOval(20, 20, 150, 150);
        
        //EYE1
        g.setColor(Color.black);
        g.fillOval(50, 70, 20, 20);
        
        //EYE2
        g.setColor(Color.black);
        g.fillOval(120, 70, 20, 20);
        
        //MOUTH
        g.fillArc(60, 100, 80, 40, 180, 180);
        
    }

}
// AUTHOR: RODRIGUEZ, ROVIC