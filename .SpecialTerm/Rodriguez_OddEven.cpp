// PROGRAMMED BY: RODRIGUEZ, ROVIC M. BIT33
#include <iostream>
#include <vector>
#include <bits/stdc++.h>
using namespace std;


int main(){

int arr[10];
int i = 0;
int sumEven = 0, sumOdd = 0;


cout << "Enter 12 elements: \n";
    for (int i = 0; i < 12; i++){
        cin >> arr[i];
    }

    for (int i = 0; i < 12; i++){
        if (i % 2 == 0){
            sumEven += arr[i];
        }
        else{
            sumOdd += arr[i];
        }
    }

    cout << "Sum of even-indexed cells: " << sumEven << endl;
    cout << "Sum of odd-indexed cells: " << sumOdd << endl;

    double average = (sumEven + sumOdd) / 2.0;
    cout << setprecision(1) << fixed << "Average: " << average << endl;

return 0;
}