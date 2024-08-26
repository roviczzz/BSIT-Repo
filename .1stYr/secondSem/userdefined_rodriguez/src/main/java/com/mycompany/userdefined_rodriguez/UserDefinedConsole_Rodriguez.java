/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.userdefined_rodriguez;

/**
 *
 * @author rovic
 */
import java.util.*;

public class UserDefinedConsole_Rodriguez {
    
    public static int reverse (int n){
        int out = 0;
        
        while (n != 0)
        {
            int remainder = n % 10;
            out = out * 10 + remainder;  
            n = n/10;  
        }
        return out;
    }
    
    public static void main (String args[]){
        int intIn, intOut;
        
        Scanner sc = new Scanner(System.in);
        
        System.out.print("User-Defined Method - Rodriguez BIT11 \n Input Number: ");
        intIn = sc.nextInt();
        intOut = reverse (intIn);
        
        System.out.println("Reversed Number: " + intOut);
        
        
        
    }
    
}
