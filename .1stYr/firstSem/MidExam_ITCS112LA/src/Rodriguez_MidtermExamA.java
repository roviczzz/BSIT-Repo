/*
    MidtermExamA.class
    Directions: The command prompt for Input and Output

    Passed and Submitted by:
    Rovic M. Rodriguez | BIT11
    October 7, 2022

 */

import java.text.DecimalFormat;
import java.util.*;

public class Rodriguez_MidtermExamA {

    public static void main (String[] arg){
        Scanner inputPrice = new Scanner(System.in);
        double discount = .20;
        double price, totalDiscount, netAmount;

        System.out.print("Enter the amount of purchase: ₱");
        price = inputPrice.nextInt();
        System.out.println("Applied 20% discount!");
        System.out.println("---------------------\n");
        totalDiscount = price * discount;
        netAmount = price - totalDiscount;

        DecimalFormat D = new DecimalFormat(("#,###.00"));
        System.out.println("Discount: ₱" + D.format(totalDiscount));
        System.out.println("Net Amount: ₱" + D.format(netAmount));


    }
}
