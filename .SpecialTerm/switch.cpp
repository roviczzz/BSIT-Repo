// Programmed by: Rodriguez, Rovic M. | BIT33
#include <iostream>
#include <cctype>
using namespace std;

int main() {
    char inp;

    cout << "Month of the Year Identifier using character \n";
    cout << "Type a character: ";
    cin >> inp;

    inp = tolower(inp);

    switch(inp){
        case 'j':
            cout << "January";
            break;
        case 'l':
            cout << "July";
            break;
        case 'f':
            cout << "February";
            break;
        case 'g':
            cout << "August";
            break;
        case 'm':
            cout << "March";
            break;
        case 's':
            cout << "September";
            break;
        case 'a':
            cout << "April";
            break;
        case 'o':
            cout << "October";
            break;
        case 'y':
            cout << "May";
            break;
        case 'n':
            cout << "November";
            break;
        case 'u':
            cout << "June";
            break;
        case 'd':
            cout << "December";
            break;
            default:
        cout << "No Month Equal";
        }

    return 0;
}