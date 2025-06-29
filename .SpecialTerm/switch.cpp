// Programmed by: Rodriguez, Rovic M. | BIT33
#include <iostream>
#include <cctype>
using namespace std;

int main() {
    char inp;

    cout << "Month of the Year Identifier using character \n";
    cout << "Type a character: ";
    cin >> inp;

    switch(inp){
        case 'J':
            cout << "January";
            break;
        case 'L':
            cout << "July";
            break;
        case 'F':
            cout << "February";
            break;
        case 'G':
            cout << "August";
            break;
        case 'M':
            cout << "March";
            break;
        case 'S':
            cout << "September";
            break;
        case 'A':
            cout << "April";
            break;
        case 'O':
            cout << "October";
            break;
        case 'Y':
            cout << "May";
            break;
        case 'N':
            cout << "November";
            break;
        case 'U':
            cout << "June";
            break;
        case 'D':
            cout << "December";
            break;
            default:
        cout << "No Month Equal";
        }

    return 0;
}