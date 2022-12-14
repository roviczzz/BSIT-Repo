// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;

public class RodriguezRectangles extends Applet {

    public void paint(Graphics g) {
        g.drawRect(25, 10, 60, 50);
        g.fillRect(190, 10, 60, 50);
        g.drawRoundRect(190, 10, 60, 10, 15, 15);
        g.fillRoundRect(70, 45, 140, 250, 30, 40);
        

    }
}
