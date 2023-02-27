import javax.swing.*;
import java.text.DecimalFormat;
import java.util.Scanner;

public class lee {

    public static void main(String[] args){

        Scanner in = new Scanner (System.in);
        int sn,y,nlu,lus,ofn,tf,ovf;
        String n,c,s;
        System.out.println("Name"); n = in.nextLine();
        System.out.println("Student Number");
        sn = in.nextInt();
        System.out.println("Course");c = in.next();
        System.out.println("Sex");s = in.next();
        System.out.println("Year"); y = in.nextInt();
        System.out.println("Number of Lecture Units"); nlu = in.nextInt();
        System.out.println("Number of Laboratory Units: "); lus = in.nextInt();
        System.out.println("===========");
        tf = lus *348;
        System.out.println("Name"+ n);
        System.out.println("Student Number" + sn);
        System.out.println("Course" + c);
        System.out.println("Sex"+ s);
        System.out.println("Year"+ y);
        System.out.println("No. of Lecture Units"+ nlu);
        System.out.println("No. of Laboratory Unit    "+tf);
        System.out.println("Overall Fees" +ovf);
        System.out.println("Extras: 500");
        System.out.println("Internet Fee: 30");
        System.out.println("ID: 30");
        System.out.println("SC/DL: 23");
        System.out.println("NSTP: 150");
        System.out.println("Overall Fees:");

    

    }
}
