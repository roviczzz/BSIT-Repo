#include <iostream>
 using namespace std;

int main(){
string customerName;
char customerType;
float totalBill, discount, VAT, finalAmountDue, payment, change;

cout << "\nEnter customer name: ";
cin >> customerName;
cout << "\nEnter total bill: ₱";
cin >> totalBill;

ctype:
cout << "\nEnter customer type: (R/M/S) ";
cin >> customerType;

char ch = tolower(customerType);
if (ch != 'r' && ch != 'm' && ch != 's') {
    cout << "\nUnrecognized customer type. Please try again.";
    goto ctype;
}


switch(ch){
    case 'r':{
        discount = totalBill;
            cout << "\nNo discount applied...";
        VAT = .12 * discount;
            cout << "\nVAT: ₱" << VAT;
        finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            r1:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = payment - finalAmountDue;

        if (change < 0){
            cout << "\nInsufficient payment. Please pay";
            goto r1;
        }
        else{
            cout << "\nChange: ₱" << change;
            cout << "\nThank you for your purchase! " << customerName;

        }
    break; }

    case 'm':{
        if (totalBill >= 500 && totalBill <= 999){
            discount = totalBill - (totalBill * .05);
                cout << "\nApplying 5% member discount...";
            VAT = .12 * discount;
                cout << "\nVAT: ₱" << VAT << "\n";
                finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            m1:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = finalAmountDue - payment;

        if (change < 0){
            cout << "\nInsufficient payment.";
            goto m1;
        }
        else{
            cout << "\nChange: ₱" << change;
            cout << "\nThank you for your purchase! " << customerName;

        }
            break;}
        
        else if (totalBill >= 1000 && totalBill <= 1999){
            discount = totalBill - (totalBill * .10);
            cout << "\nApplying 10% member discount...";
            VAT = .12 * discount;
            cout << "\nVAT: ₱" << VAT;
            finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            m2:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = finalAmountDue - payment;

        if (change < 0){
            cout << "\nInsufficient payment.";
            goto m2;
        }
        else{
            cout << "\nChange: ₱"<< change;
            cout << "\nThank you for your purchase! " << customerName;

        }
            break;}
        
        else if (totalBill >= 2000){
            discount = totalBill - (totalBill * .15);
            cout << "\nApplying 15% member discount...";
            VAT = .12 * discount;
            cout << "\nVAT: ₱" << VAT << "\n";
            finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            m3:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = finalAmountDue - payment;

        if (change < 0){
            cout << "\nInsufficient payment.";
            goto m3;
        }
        else{
            cout << "\nChange: ₱"<< change;
            cout << "\nThank you for your purchase! " << customerName;

        }
            break;}
        
        else {
            discount = totalBill;
            cout << "\nNo discount applied...";
            VAT = .12 * discount;
            cout << "\nVAT: ₱" << VAT << "\n";
            finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            m4:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = finalAmountDue - payment;

        if (change < 0){
            cout << "\nInsufficient payment.";
            goto m4;
        }
        else{
            cout << "\nChange: ₱"<< change;
            cout << "\nThank you for your purchase! " << customerName;

        }
            break;
        }
    case 's':
        discount = totalBill - (totalBill * .12);
            cout << "\nApplying 12% senior citizen discount...";
            cout << "\nNo VAT applied";
            finalAmountDue = discount + VAT;
            cout << "\nFinal amount due: ₱" << finalAmountDue;
            s1:
            cout << "\nEnter payment: ₱";
            cin >> payment;
        change = finalAmountDue - payment;

        if (change < 0){
            cout << "\nInsufficient payment.";
            goto s1;
        }
        else{
            cout << "\nChange: ₱"<< change;
            cout << "\nThank you for your purchase! " << customerName;

        }
            break;
    default:
        cout << "Error.";
        break;
}

return 0;
}
}

