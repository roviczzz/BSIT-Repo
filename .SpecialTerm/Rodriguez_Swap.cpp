// PROGRAMMED BY: RODRIGUEZ, ROVIC M. BIT33
#include <iostream>
#include <vector>
using namespace std;

int main(){
int arrA[10];
int arrB[10];
int arrTemp[10];
int a, b, sum;

cout << "Enter elements for array A: \n";
    for (int i = 0; i < 10; i++){
        cin >> arrA[i];
    }

cout << "Enter elements for array B: \n";
    for (int i = 0; i < 10; i++){
        cin >> arrB[i];
    }
        cout << endl;

    for(int i = 0; i < 10; i++){
        arrTemp[i] = arrA[i];
        arrA[i] = arrB[i];
        arrB[i] = arrTemp[i];
    }

cout << "New content of array A: \n";
    for (int i = 0; i < 10; i++){
        cout << arrA[i] << "\t";
    }
    cout << endl;

cout << "New content of array B: \n";
    for (int i = 0; i < 10; i++){
        cout << arrB[i] << "\t";
    }
    cout << endl;

    cout << "Array Sum: \n";
    for (int i = 0, a = 0, b = 0, c = 0; i < 10; i++){
        sum += arrA[i];
        sum += arrB[i];
    }
    cout << sum << endl;

    return 0;
}