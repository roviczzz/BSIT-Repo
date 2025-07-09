#include <iostream>
using namespace std;
void sum(); void dif(); void pro(); void quo(); void rem(); void ave();
int num1, num2;
int main(){
    cout << "Enter two numbers: \n";
    while (!(cin >> num1 >> num2)) {cout << "Invalid input. Please enter an integer."; cin.clear(); cin.ignore();}
    sum();dif();pro();quo();rem();ave();
    return 0;
}

void sum(){ cout << endl << "Sum: " << num1+num2 << "\n"; }
void dif(){ cout << "Difference: " << num1-num2 << "\n"; }
void pro(){ cout << "Product: " << num1*num2 << "\n"; }
void quo(){ if(num1 == 0 || num2 == 0) {cout << "Error: Division by zero is not allowed \n"; return;} else cout << "Quotient: " << num1/num2 << "\n";}
void rem(){ if(num1 == 0 || num2 == 0) {cout << "Error: Cannot calculate remainder with zero \n"; return;}else cout << "Remainder: " << num1%num2 << "\n";}
void ave(){ if(num1 == 0 || num2 == 0) cout << "Average: " << (num1 + num2)/2 << "\n"; }