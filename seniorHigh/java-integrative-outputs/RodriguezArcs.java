// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;

public class RodriguezArcs extends Applet {

    public void paint(Graphics g) {
        g.drawArc(10, 40, 70, 25, 0, 90);
        g.fillArc(100, 50, 70, 70, 0, 75);
        g.drawArc(10, 255, 70, 80, 0, 175);
        g.fillArc(100, 100, 70, 69, 0, 270);
        g.drawArc(200, 60, 80, 80, 0, 250);
        

    }
}
