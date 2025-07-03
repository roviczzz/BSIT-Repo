#include <iostream>
using namespace std;

int main(){
    int arr[4][4];
    int diagonalSum = 0, upperSum = 0, lowerSum = 0;

    for (int row = 0; row < 4; row++) {
        cout << "Enter values for Row " << row + 1 << " (4 numbers separated by space): ";
        for (int col = 0; col < 4; col++) {
            cin >> arr[row][col];
        }
    }

    for (int row = 0; row < 4; row++) {
        for (int col = 0; col < 4; col++) {
            if (row == col) {
                diagonalSum += arr[row][col];
            } else if (row < col) {
                upperSum += arr[row][col];
            } else if (row > col) {
                lowerSum += arr[row][col];
            }
        }
    }

    cout << "\nSum of diagonal elements: " << diagonalSum << "\n";
    cout << "Sum of upper triangular elements: " << upperSum << "\n";
    cout << "Sum of lower triangular elements: " << lowerSum << "\n";

    return 0;
}