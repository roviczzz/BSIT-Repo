// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.*;

public class RodriguezAppletColor extends Applet {

    public void paint(Graphics g) {
        Color c1 = new Color(150,100,100);
        Color c2 = new Color(190,90,100);
        Color c3 = new Color(255,0,255);
        g.setColor(c1);
        g.drawLine(0,0,25,100);
        g.drawLine(0,100,40,0);
        g.setColor(c2);
        g.drawLine(20,25,250,180);
        g.drawLine(95,90,400,400);
        g.setColor(c3);
        g.drawLine(50,150,400,40);
        g.drawLine(5,290,80,19);
        g.setColor(Color.blue);
        g.drawOval(90,10,50,50);
        g.fillOval(10, 90, 140, 100);
        g.setColor(Color.magenta);
        g.drawOval(250,10,90,30);
        g.drawRect(10,10,60,50);
        g.setColor(Color.cyan);
        g.fillRect(150, 10, 60, 50);
        g.drawRoundRect(200, 10, 60, 50, 15, 15);
        
        

    }
}
