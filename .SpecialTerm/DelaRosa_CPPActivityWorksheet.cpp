#include <iostream>
#include <string>
#include <iomanip>
#include <cctype>
using namespace std;

int main() {
    string customerName;
    double billAmount;
    char customerType;
    double discountAmount = 0.0;
    double finalAmount = 0.0;
    double vatAmount = 0.0;
    double paymentAmount;
    double changeAmount;
    double discountedBill = 0.0;
    

    cout << "Enter customer name: ";
    getline(cin, customerName);

    cout << "Enter total bill (P): ";
    cin >> billAmount;

    while (billAmount < 0) {
        cout << "Bill amount cannot be negative. Please enter a valid amount: ";
        cin >> billAmount;
    }

    do {
        cout<<"[R] Regular"<<"\n";
        cout<<"[M] Member"<<"\n";
        cout<<"[S] Senior "<<"\n";
        cout << "Enter customer type (R/M/S): ";
        cin >> customerType;
        
        customerType = toupper(customerType);

        if (customerType != 'R' && customerType != 'M' && customerType != 'S') {
            cout << "Invalid customer type. Please enter R, M, or S." << endl;
        }
    } while (customerType != 'R' && customerType != 'M' && customerType != 'S');


    cout << "Applying discount logic..." << endl;
    if (customerType == 'M') {
        if (billAmount >= 2000) {
            discountAmount = billAmount * 0.15;
            cout << "Applying 15% member discount." << endl;
        } else if (billAmount >= 1000) {
            discountAmount = billAmount * 0.10;
            cout << "Applying 10% member discount." << endl;
        } else if (billAmount >= 500) {
            discountAmount = billAmount * 0.05;
            cout << "Applying 5% member discount." << endl;
        } else {
            cout << "No member discount applied for amounts less than P500." << endl;
        }
    } else if (customerType == 'S') {
        discountAmount = billAmount * 0.12;
        cout << "Applying 12% senior citizen discount." << endl;
    } else if (customerType == 'R') {
        cout << "No discount applied for regular customers." << endl;
    } else {
        cout << "Error: This should not be reached if input validation works correctly." << endl;
    }

    discountedBill = billAmount - discountAmount;

    if (customerType != 'S') {
        vatAmount = discountedBill * 0.12;
        cout << "VAT: P" << vatAmount << endl;
    } else {
        cout << "Senior Citizen: VAT exempt." << endl;
    }

    finalAmount = discountedBill + vatAmount;
    cout << "Final amount due: P" << finalAmount << endl;

    while (true) {
        cout << "Enter payment: P";
        cin >> paymentAmount;

        if (paymentAmount < finalAmount) {
            cout << "Error: Insufficient payment. Please pay the full amount." << endl;
        } else {
            changeAmount = paymentAmount - finalAmount;
            cout << "Change: P" << changeAmount << endl;
            break;
        }
    }

    cout << "\n--- RECEIPT ---" << endl;
    cout << "Customer Name: " << customerName << endl;
    cout << "Original Bill: P" << billAmount << endl;
    cout << "Customer Type: ";
    if (customerType == 'R') cout << "Regular";
    else if (customerType == 'M') cout << "Member";
    else if (customerType == 'S') cout << "Senior";
    else cout << "Unknown";
    cout << endl;
    cout << "Discount Applied: P" << discountAmount << endl;
    cout << "VAT Charged: P" << vatAmount << endl;
    cout << "-----------------" << endl;
    cout << "Total Due: P" << finalAmount << endl;
    cout << "Payment Received: P" << paymentAmount << endl;
    cout << "Change Given: P" << changeAmount << endl;
    cout << "-----------------" << endl;

    if (billAmount >= 2000) {
        cout << "Thank you for your large purchase, " << customerName << "! We appreciate your Transaction." << endl;
    } else if (billAmount >= 500) {
        cout << "Thank you for your purchase, " << customerName << "!" << endl;
    } else {
        cout << "Thank you for shopping with us, " << customerName << "." << endl;
    }

    return 0;
}