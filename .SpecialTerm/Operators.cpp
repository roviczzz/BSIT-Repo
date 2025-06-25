#include <iostream>
 using namespace std;

int main(){
int a, b, c;

cout << "Type number for first integer: \n";
cin >> a;
cout << "Type number for second integer: \n";
cin >> b;
cout << "Type number for third integer: \n";
cin >> c;

cout << "Sum: " << a+b+c << "\n";
cout << "Difference: " << a-b-c << "\n";
cout << "Product: " << a*b*c << "\n";
cout << "Quotient: " << a/b/c << "\n";
cout << "Remainder: " << a%b%c << "\n";


return 0;
}