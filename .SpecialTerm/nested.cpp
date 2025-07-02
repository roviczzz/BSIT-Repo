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

        if (inp == 'j') {
        cout << "January";
        } 
        else if (inp == 'l') {
        cout << "July";
        }
        else if (inp == 'f') {
        cout << "February";
        }
        else if (inp == 'g') {
        cout << "August";
        }
        else if (inp == 'm') {
        cout << "March";
        }
        else if (inp == 's') {
        cout << "September";
        }
        else if (inp == 'a') {
        cout << "April";
        }
        else if (inp == 'o') {
        cout << "October";
        }
        else if (inp == 'y') {
        cout << "May";
        }
        else if (inp == 'n') {
        cout << "November";
        }
        else if (inp == 'u') {
        cout << "June";
        }
        else if (inp == 'd') { 
        cout << "December";
        }
        else {
        cout << "No Month Equal";
        }

    return 0;
}