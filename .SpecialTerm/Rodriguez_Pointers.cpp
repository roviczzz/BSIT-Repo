#include <iostream>
using namespace std;


int main(){
    cout << "Input 3 integers: ";

    int arr[3];
    for (int i = 0; i < 3; ++i){
        cin >> arr[i];
    }

    for (int i = 0; i < 3; ++i){
        int *p = &arr[i];
        cout << endl << "integer " << (i+1) << " value is: " << *p;
        cout << endl << "integer " << (i+1) << " address is: " << p;
        cout << endl;}


    return 0;
}