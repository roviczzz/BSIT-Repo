//PROGRAMMED BY: RODRIGUEZ, ROVIC M. BIT33
#include <iostream>
#include <iomanip>
using namespace std;

int main() {

    cout << "x";
    for (int j = 1; j <= 12; ++j){
        cout << "\t" << j;
    }

    cout << endl;

    for (int i = 1; i <= 12; ++i){
        cout << ""<< i;
        for (int j = 1; j <= 12; ++j){
            cout << "\t" << i * j;
        }
        cout << endl;
    }

    return 0;
}