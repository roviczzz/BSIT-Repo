#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main() {
    string name;
    char type;
    double bill, discount = 0, vat = 0, finalAmount, payment, change;

    cout << "Enter customer name: ";
    getline(cin, name);
    
    cout << "Enter total bill (₱): ";
    cin >> bill;

    cout << "Enter customer type (R/M/S): ";
    cin >> type;

    type = toupper(type);
    if (type == 'M') {
        if (bill >= 2000) {
            discount = 0.15;
            cout << "Applying 15% member discount..." << endl;
        } else if (bill >= 1000) {
            discount = 0.10;
            cout << "Applying 10% member discount..." << endl;
        } else if (bill >= 500) {
            discount = 0.05;
            cout << "Applying 5% member discount..." << endl;
        } else {
            discount = 0.0;
            cout << "No discount applied." << endl;
        }
    } else if (type == 'S') {
        discount = 0.12;
        cout << "Applying 12% senior discount (VAT exempt)..." << endl;
    } else if (type == 'R') {
        discount = 0.0;
        cout << "No discount applied." << endl;
    } else {
        cout << "Invalid customer type. Exiting program." << endl;
        return 1;
    }

    double discountedAmount = bill - (bill * discount);

    if (type != 'S') {
        vat = discountedAmount * 0.12;
    }

    finalAmount = discountedAmount + vat;

    cout << fixed << setprecision(2);
    cout << "VAT: ₱" << vat << endl;
    cout << "Final amount due: ₱" << finalAmount << endl;
    
    cout << "Enter payment (₱): ";
    cin >> payment;

    if (payment < finalAmount) {
        cout << "Error: Insufficient payment. Transaction canceled." << endl;
        return 1;
    }

    change = payment - finalAmount;

    cout << "\n------- RECEIPT -------\n";
    cout << "Customer Name: " << name << endl;
    cout << "Customer Type: ";
        if (type == 'R') cout << "Regular" << endl;
            else if (type == 'M') cout << "Member" << endl;
            else if (type == 'S') cout << "Senior Citizen" << endl;
            else cout << "" << endl;
    cout << "Original Bill: ₱" << bill << endl;
    cout << "Discount Applied: ₱" << bill * discount << endl;
    cout << "Amount after discount: ₱" << discountedAmount << endl;
    cout << "VAT: ₱" << vat << endl;
    cout << "Total Due: ₱" << finalAmount << endl;
    cout << "Payment Received: ₱" << payment << endl;
    cout << "Change: ₱" << change << endl;
    cout << "------------------------\n";

    if (finalAmount >= 2000)
        cout << "Thank you for your big purchase, " << name << "!" << endl;
    else
        cout << "Thank you for your purchase, " << name << "!" << endl;

    return 0;
}