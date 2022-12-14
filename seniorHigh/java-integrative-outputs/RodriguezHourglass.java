// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;

public class RodriguezHourglass extends Applet {

    public void paint(Graphics g) {
        int xpoints[]={30,200,30,200,30};
        int ypoints[]={30,30,200,200,30};
        int num = 5;
        g.setColor(Color.blue);
        g.drawPolygon(xpoints,ypoints,num);
        

    }
}
