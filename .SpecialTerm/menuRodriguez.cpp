#include <iostream>

 using namespace std;

int main(){
char operation;
int a, b, c;

loop:
cout << "Select Operation:\n";
cout << "[A] - Addition\n";
cout << "[S] - Subtraction\n";
cout << "[M] - Multiplication\n";
cout << "[D] - Division\n";
cout << "[0] - Modulo Division\n";
cout << "[Q] - Quit \n\n";
cin >> operation;

char ch = tolower(operation);
if (ch == 'q'){
    goto quit;
}


cout << "Type number for first integer: \n";
cin >> a;
cout << "Type number for second integer: \n";
cin >> b;
cout << "Type number for third integer: \n";
cin >> c;

switch(ch){
    case 'a':
        cout << "Total Addtion: " << a+b+c << "\n";
        break;
    case 's':
        cout << "Total Subtraction: " << a-b-c << "\n";
        break;
    case 'm':
        cout << "Total Multiplication: " << a*b*c << "\n";
        break;
    case 'd':
        cout << "Total Division: " << a/b/c << "\n";
        break;
    case '0':
        cout << "Total Modulo Division: " << a%b%c << "\n";
        break;
    quit:
    case 'q':
        cout << "Quit: " << "Exiting Program\n";
        exit(0);
    default:
        cout << "\n\nCommand not recognized. Please try again\n";
        goto loop;
}

return 0;
}

