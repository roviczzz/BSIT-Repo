/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.fileiorodriguez;

import java.util.*;
import java.io.*;

/**
 *
 * @author rovic
 */
public class Rodriguez_FileIO {

    public static void main(String[] args) throws FileNotFoundException{
        Scanner inFile = new Scanner (new FileReader("D:/grade.dat"));
        
        PrintWriter outFile = new PrintWriter("average.txt");
        String firstName, lastName;
        double test1, test2, test3, test4, test5, average;
        
        while (inFile.hasNext()) {
        firstName = inFile.next();
        lastName = inFile.next();
        test1 = inFile.nextDouble();
        test2 = inFile.nextDouble();
        test3 = inFile.nextDouble();
        test4 = inFile.nextDouble();
        test5 = inFile.nextDouble();
        average = (test1 + test2 + test3 + test4 + test5) /5;
        
        System.out.println(firstName + "\t" + lastName + "\t" + average); 
        outFile.println(firstName + "\t" + lastName + "\t" + average);
        }
        
        inFile.close();
        outFile.close();
    }
}
