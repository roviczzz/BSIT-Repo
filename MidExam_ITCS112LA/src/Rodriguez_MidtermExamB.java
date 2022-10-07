/*
    MidtermExamB.class
    Directions: The dialog box for Input and Output

    Passed and Submitted by:
    Rovic M. Rodriguez | BIT11
    October 7, 2022

 */

import java.text.DecimalFormat;
import  java.util.*;
import javax.swing.*;

public class Rodriguez_MidtermExamB {

    public static void main (String[] arg){
        String inputPrice;
        double discount = .20;
        double price, totalDiscount, netAmount;

        inputPrice = JOptionPane.showInputDialog(null, "Enter the amount of purchase: ", "Question", JOptionPane.QUESTION_MESSAGE);
        price = Integer.parseInt(inputPrice);
        JOptionPane.showMessageDialog(null, "Applied 20% discount!", "Information", JOptionPane.INFORMATION_MESSAGE);
        totalDiscount = price * discount;
        netAmount = price - totalDiscount;



        DecimalFormat D = new DecimalFormat(("#,###.00"));
        JTextArea Area = new JTextArea(5, 10);
        Area.setEditable(false);
        Area.append("Discount: ₱" + D.format(totalDiscount)+ "\n");
        Area.append("Net Amount: ₱" + D.format(netAmount)+ "\n");
        JOptionPane.showMessageDialog(null, Area, "Result", JOptionPane.PLAIN_MESSAGE);


    }
}
