#include <iostream>
using namespace std;

int main(){
    int selection;

    cout << endl << "C++ PROGRAMMING PORTFOLIO";
    cout << endl << "==========================";
    cout << endl <<"[1] - Basic IO Functions";
    cout << endl <<"[2] - Conditional Statements";
    cout << endl <<"[3] - Loops";
    cout << endl <<"[4] - Arrays";
    cout << endl <<"[5] - Functions";
    cout << endl <<"[6] - Structures";
    cout << endl <<"[7] - Pointers";
    cout << endl <<"[8] - Quit";

    cout << endl <<"Enter your choice: ";
    while (true){
        if (cin >> selection && selection >= 1 && selection <= 8){
            break;
        }
        else{
            cout << "invalid input. please enter a number from 1 to 8: ";
            cin.clear();
            cin.ignore();
        }
    }
    switch (selection)
    {
    case 1:{ // basic io
    int x; string y; char con;
    io:
    cout << endl << endl << "BASIC IO FUNCTIONS";
    cout << endl << "==================";
    cout << endl << "In C++, basic input/output (I/O) operations are primarily \nhandled through streams provided by the iostream library.";
    cout << endl;
    cout << endl << "Input Int & String";

    cout << endl << "enter an integer: ";
    cin >> x;
    cout << "enter a string: ";
    cin >> y;

    cout << endl << "Value of the integer: " << x;
    cout << endl << "Value of the String: " << y;
    cout << endl << "Do you want to continue? (y/n) ";
    if (cin >> con && con == 'y' || con == 'Y'){
        goto io;
    } else{
        break;
    }

    }

    case 2:{ // conditional statements
    char x, con;
    cons:
    cout << endl << endl << "CONDITIONAL STATEMENTS";
    cout << endl << "==================";
    cout << endl << "Conditional statements in C++ are control structures that enable a program to make decisions and execute different blocks of code based on whether a specified condition evaluates to \ntrue or false. They are essential for implementing decision-making logic and controlling the flow of program execution.";
    cout << endl;
    cout << endl << "vowel checker";

    cout << endl << "enter a letter: ";
    if (cin >> x){
        x = tolower(x);
        if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u'){
            cout << "The value " << x << " is a vowel!";
        }
        else{
            cout << "The value " << x << "is not a vowel!";
        }
        cout << endl << "Do you want to continue? (y/n) ";
        if (cin >> con && con == 'y' || con == 'Y'){
            goto cons;
    } else{
        break;
    }
    }
        }

    case 3: // loops
    int x1, x2, higher, lower; char con;
    loop:
    cout << endl << endl << "LOOPS";
    cout << endl << "==================";
    cout << endl << "Loops in C++ are control flow statements that enable the repeated execution of a block of code based on a specified condition. \nThey are fundamental for automating repetitive tasks and iterating over collections of data.";
    
    cout << endl;
    cout << endl << "number counter loop";

    cout << endl << "enter first number: ";
    cin >> x1;
    cout << endl << "enter second number: ";
    cin >> x2;

    if (x1 < x2){
        higher = x2;
        lower = x1;
    } else{
        higher = x1;
        lower = x2;
    }

    cout << endl << "number counter:";
    for (int i = lower; i <= higher; ++i){
        cout << i << " ";
    }
    cout << endl << "Do you want to continue? (y/n) ";
        if (cin >> con && con == 'y' || con == 'Y'){
            goto loop;
    } else{
        break;
    }
    case 4:{ // arrays
    int x1, size; char con;
    array:
    cout << endl << endl << "ARRAYS";
    cout << endl << "==================";
    cout << endl << "Arrays in C++ are a fundamental data structure used to store a collection of elements of the same data type in contiguous memory locations. \nThey provide a way to manage and organize multiple values under a single variable name. ";
    
    cout << endl;
    cout << endl << "array storer";
    cout << endl << "enter array size: ";
    cin >> size;
    cout << endl << "enter array elements: ";

    int arr[size];
    for (int i = 0; i < size; ++i){
        cin >> arr[i];
    }

    cout << endl << "array elements:";
    for (int i = 0; i < size; ++i){
        cout << arr[i] << " ";
    }
    cout << endl << "Do you want to continue? (y/n) ";
        if (cin >> con && con == 'y' || con == 'Y'){
            goto array;
    } else{
        break;
    }
    }
    case 5: // functions
    cout << endl << endl << "FUNCTIONS";
    cout << endl << "==================";
    cout << endl << "In C++, a function is a named block of code designed to perform a specific task. \nFunctions are fundamental to modular programming, promoting code reusability and organization.";

    cout << endl;
    cout << endl << "arithmetic operation function";
    cout << endl << "[A] - Addition";
    cout << endl << "[S] - Subtraction";
    cout << endl << "[M] - Multiplication";
    cout << endl << "[D] - Division";


        break;

    case 6: // structures
        
        break;

    case 7: // pointers
        
        break;

    case 8: // quit 
        
        break;
    
    default: // unknown input
        break;
    }
    return 0;
}