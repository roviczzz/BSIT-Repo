/*
    Even or Odd
    Final Term Short Quiz

    Rovic M. Rodriguez
    BIT11
    Oct 11, 2022

 */


import java.util.Scanner;

public class Rodriguez_SQ1 {
    public static void main(String[] args){

        int num,intResult;
        String numString;

        Scanner s = new Scanner(System.in);

        System.out.println("Input number: ");
        numString = s.nextLine();
        num = Integer.parseInt(numString);

        intResult = (num % 2); //returns 0 = even, 1 = odd


        if(intResult == 0){
            System.out.println(num + " is even");

        }
        else {
            System.out.println(num + " is odd");
        }






    }
}
