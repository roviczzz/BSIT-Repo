#include <iostream>
using namespace std;

int main() {
    int size;
    cout << "Enter how many values: ";
    cin >> size;

    int* arr = new int[size];
    cout << "Enter the " << size << " values: ";
    for (int i = 0; i < size; ++i) {
        cin >> arr[i];
    }

    int* maxPtr = &arr[0];
    for (int i = 1; i < size; ++i) {
        if (arr[i] > *maxPtr) {
            maxPtr = &arr[i];
        }
    }

    cout << endl << "Maximum Value is: " << *maxPtr << endl;
    return 0;
}
