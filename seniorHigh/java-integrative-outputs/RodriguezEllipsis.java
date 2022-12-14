// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;

public class RodriguezEllipsis extends Applet {

    public void paint(Graphics g) {
        g.drawOval(90, 10, 50, 50);
        g.fillOval(50, 10, 75, 50);
        g.drawOval(250, 10, 90, 30);
        g.fillOval(320, 90, 140, 100);
        

    }
}
