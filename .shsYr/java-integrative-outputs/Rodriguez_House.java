// AUTHOR: RODRIGUEZ, ROVIC
package RodriguezApplet;

import javax.swing.JApplet;
import java.awt.*;

public class Rodriguez_House extends JApplet {

    public void paint(Graphics g){
        //HOUSE_BASE
        g.setColor(Color.YELLOW);
        g.fillRect(25, 140, 120, 100);
        
        //HOUSE_DOOR
        g.setColor(Color.blue);
        g.fillRect(100, 200, 20, 40);
        
        //HOUSE_ROOF
        g.setColor(Color.blue);
        int xpoints[] = {90, 145, 25, 145, 25};
        int ypoints[] = {25, 145, 145, 145, 25};
        int npoints = 3;

        g.fillPolygon(xpoints, ypoints, npoints);
    }
// AUTHOR: RODRIGUEZ, ROVIC
}
