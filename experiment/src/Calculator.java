import java.util.Scanner;

public class Calculator {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        float SP, TIA, P;
        System.out.println("---Kilometer Calculator---");

        System.out.print("Enter 1st KM: ");
        SP = sc.nextInt();
        System.out.print("Enter 2nd KM: ");
        TIA = sc.nextInt();

        float KM = SP - TIA;
        float ST = KM - 5;
        float ST1 = ST * 1.55f;
        float ST2 = ST1 + 9.00f;

        System.out.println("Conductor: " + ST2 + (" Lang po sir"));
        System.out.print("Passenger: Kuya Bayad ko: ");
        P = sc.nextFloat();

        if (ST2 < P){
            System.out.println("Conductor: Sobra po bayad niyo sir, Ito po sukli ninyo: " + (P - ST2));
        }else if (ST2 > P){
            System.out.println("Conductor: Kulang po bayad niyo sir, Kulang po ng: " + (P - ST2));
        }else if (ST2 == P){
            System.out.println("Conductor: Sakto po bayad niyo sir");
        }
    }
}

