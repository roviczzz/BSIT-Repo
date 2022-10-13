/*
 Scanner & java input statements

*/

import java.io.*;
import java.lang.*;
import java.util.Scanner;

public class scannerInputStatement {

    public static void main (String[] args){
        System.out.println("InputStreamReader | Input Number: ");
        //InputStreamReader object - enables to input values
        InputStreamReader is = new InputStreamReader(System.in);

        //BufferedReader object - stores the value from InputStreamReader object (is)
        BufferedReader br = new BufferedReader(is);

        //readLine - variable = object of BufferedReader (br) + .readLine();
        String var1;
        try {
            var1 = br.readLine();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

        //Integer.parseInt() - convert string to integer, variable int (num1) = Integer.parseInt + variable string (var1)
        int num1;
        num1 = Integer.parseInt(var1);

        System.out.println("InputStreamReader | Output: " + num1 + "\n \n");


        int num2;
        //Scanner object
        Scanner sc = new Scanner(System.in);

        System.out.println("Scanner | Input Number: ");
        num2 = sc.nextInt();

        System.out.println("Scanner | Output: " + num2);





    }
}
