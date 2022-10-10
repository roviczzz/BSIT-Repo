/*
    Laboratory Activity #4
    Rovic M. Rodriguez
    BIT11
    October 10, 2022
*/

import java.text.DecimalFormat;
import java.util.*;

public class Rodriguez_LabAct4 {

    public static void main (String[] args){
        double q1 = 9.000;
        double q2 = 10.000;
        double q3 = 10.000;
        double avg;

        System.out.println("Direction: Write a program that will get the average of 3 short quizzes in your Programming class.");
        System.out.println("Laboratory Activity #1 score: 9/15");
        System.out.println("Laboratory Activity #2 (F2F Onsite) score: 10/10");
        System.out.println("Laboratory Activity #3 (F2F Onsite) score: 10/10");
        avg = (q1 + q2 + q3)/3;

        DecimalFormat df = new DecimalFormat("##.###");
        System.out.print("Your average is: " + df.format(avg));




    }

}
