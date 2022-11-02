import javax.swing.*;
import java.text.DecimalFormat;

public class Finals1 {

    public static void main(String[] args){
    String midString, finalString;
    float midFloat, finalFloat, ave; //next time double

    midString = JOptionPane.showInputDialog(null,"Input Midterm Grade: ");
    midFloat = Float.parseFloat(midString);

    finalString = JOptionPane.showInputDialog(null,"Input Final Grade:");
    finalFloat = Float.parseFloat(finalString);

    ave = (midFloat + finalFloat)/2;
    DecimalFormat d = new DecimalFormat("###.##");

    if (ave >= 91)
    {
        JOptionPane.showMessageDialog(null,"Excellent = " + d.format(ave));

    } else if (ave >= 81) {
        JOptionPane.showMessageDialog(null,"Very Good = " + d.format(ave));

    } else if (ave >= 71) {
        JOptionPane.showMessageDialog(null,"Good = " + d.format(ave));
    } else if (ave >= 61) {
        JOptionPane.showMessageDialog(null,"Fair = " + d.format(ave));
    } else if (ave == 60) {
        JOptionPane.showMessageDialog(null,"Poor = " + d.format(ave));
    }
    else {
        JOptionPane.showMessageDialog(null,"Needs Improvement = " + d.format(ave));
    }

    }
}
