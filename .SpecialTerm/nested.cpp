// Programmed by: Rodriguez, Rovic M. | BIT33
#include <iostream>
#include <cctype>
using namespace std;

int main() {
    char inp;

    cout << "Month of the Year Identifier using character \n";
    cout << "Type a character: ";
    cin >> inp;

        if (inp == 'J') {
        cout << "January";
        } 
        else if (inp == 'L') {
        cout << "July";
        }
        else if (inp == 'F') {
        cout << "February";
        }
        else if (inp == 'G') {
        cout << "August";
        }
        else if (inp == 'M') {
        cout << "March";
        }
        else if (inp == 'S') {
        cout << "September";
        }
        else if (inp == 'A') {
        cout << "April";
        }
        else if (inp == 'O') {
        cout << "October";
        }
        else if (inp == 'Y') {
        cout << "May";
        }
        else if (inp == 'N') {
        cout << "November";
        }
        else if (inp == 'U') {
        cout << "June";
        }
        else if (inp == 'L') { 
        cout << "December";
        }
        else {
        cout << "No Month Equal";
        }

    return 0;
}