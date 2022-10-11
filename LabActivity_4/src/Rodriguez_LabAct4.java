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
        double q1 = 10, q2 = 28, q3 = 8;
        double avg;

        System.out.println("Direction: Write a program that will get the average of 3 short quizzes in your Programming class.");
        System.out.println("Short quiz #1 score: 10/10");
        System.out.println("Long Exam Score (F2F) score: 28/35");
        System.out.println("Short quiz #2 score: 8/10");
        avg = (q1 + q2 + q3)/3;

        DecimalFormat df = new DecimalFormat("##.###");
        System.out.print("Your average is: " + df.format(avg));




    }

}
