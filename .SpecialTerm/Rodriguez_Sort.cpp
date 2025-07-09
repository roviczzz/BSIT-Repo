//PROGRAMMED BY: RODRIGUEZ, ROVIC M. BIT33
#include <iostream>
using namespace std;

void sortASC(int arr[], int size);
void sortDSC(int arr[], int size);

int main(){
    int size = 0, input;
    char order, prompt;

    reiterate:
    cout << "Enter how many numbers you want to input: ";
    cin >> size;
    cout << "\n";
    cout << "Enter " << size << " numbers: \n";

    int arr[size];
    for(int i = 0, j=0; i < size; i++){
        j = j+1;
        cout << "Number " << j << ": ";
        cin >> arr[i];

    }
    cout << endl;

    prompt:
    cout << "Sort in ascending or descending? (A/D): ";
    cin >> order;
    cout << "\n";
    order = tolower(order);

    if (order == 'a'){
        cout << "Sorted in Ascending Order: \n";
        sortASC(arr, size);
        for (int element : arr){
            cout << element << " ";
        }

        cout << "\nDo You want to enter another set of numbers? (Y/N): ";
        cin >> prompt;
        prompt = tolower(prompt);
        cout << "\n";
            if (prompt == 'y'){
            cout << "------------------------------------------------------\n";
            goto reiterate;
        }
        else{
            return 0;
        }   
    }
    else if (order == 'd'){
        sortDSC(arr, size);
        for (int element : arr){
            cout << element << " ";
        }

        cout << "\nDo You want to enter another set of numbers? (Y/N): ";
        cin >> prompt;
        prompt = tolower(prompt);
        cout << "\n";
            if (prompt == 'y'){
            cout << "------------------------------------------------------\n";
            goto reiterate;
        }
        else{
            return 0;
        }
    }
    else {
        cout << "invalid input. please try again \n";
        goto prompt;
    }

    return 0;
}

void sortASC(int arr[], int size){
    int temp;
    for (int i = 0; i < size - 1; i++){
        for (int j = 0; j < size - i - 1; j++){
            if (arr[j] > arr[j + 1]){
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }   
    }
}

void sortDSC(int arr[], int size){
    int temp;
    for (int i = 0; i < size - 1; i++){
        for (int j = 0; j < size - i - 1; j++){
            if (arr[j] < arr[j + 1]){
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }   
    }
}