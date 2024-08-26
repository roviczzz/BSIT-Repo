// AUTHOR: Rovic Rodriguez

package rodriguezapplet;

import java.applet.Applet;
import java.awt.event.*;
import java.awt.*;

public class RodriguezAppletXor extends Applet {
    int chsX=100, chsY=100;
    public void RodriguezXOR(){
        addMouseMotionListener (new MouseMotionAdapter(){
            public void mouseMoved(MouseEvent me){
                int x = me.getX(); int y = me.getY();
                chsX = x-10; chsY = y-10;
                repaint(); } } ) ; }

    public void paint(Graphics g) {
        g.drawLine(0,0,100,200);
        g.drawLine(0,100,100,0);
        g.setColor(Color.red);
        g.drawLine(40, 25, 250, 45);
        g.drawLine(75, 20, 400, 400);
        g.setColor(Color.cyan);
        g.drawRect(10, 10, 60, 50);
        g.fillRect(90, 10, 60, 50);
        g.setColor(Color.blue);
        g.drawRoundRect(70,25,140,45,30,40);
        g.setColor(Color.magenta);
        g.drawLine(20,150,420,69);
        g.drawLine(115,290,80,19);
        // xor cross hairs
        g.setXORMode(Color.black);
        g.drawLine(chsX-10,chsY,chsX+10,chsY);
        g.drawLine(chsX, chsY-10, chsX, chsY+10);
        g.setPaintMode();
        
    } }
        