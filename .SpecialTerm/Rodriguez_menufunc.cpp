# include <iostream>
# include <cctype>
using namespace std;

void VowelsCounter(); void LeapYearFinder(); void SortMe(); char toLowerChar(char ch);
int userSelect;

int main(){
    cout << endl << "=== Functions in C++ ===";
    cout << endl << "[1] VowelsCounter()";
    cout << endl << "[2] LeapYearFinder()";
    cout << endl << "[3] SortMe()";
    cout << endl;
    cin >> userSelect;
    
    while (userSelect < 1 || userSelect > 3) {
    cout << "Invalid input. Please select between [1] and [3]: ";
    cin >> userSelect;
}

    switch (userSelect) {
        case 1:
            VowelsCounter();
            break;
        case 2:
            LeapYearFinder();
            break;
        case 3:
            SortMe();
            break;
    }

    return 0;
}

char toLowerChar(char ch) {
    if (ch >= 'A' && ch <= 'Z') return ch + 32;
    return ch;
}

void VowelsCounter() {
    char vowelString[200];
    int vowelCount = 0;

    cout << endl << "VowelsCounter() - a function that counts for the number of vowels in an input string.";
    cout << endl << "Enter a string: ";

    cin.ignore();
    cin.getline(vowelString, 200);

    for (int i = 0; vowelString[i] != '\0'; i++) {
        char ch = toLowerChar(vowelString[i]);
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') {
            vowelCount++;
        }
    }

    cout << "Number of vowels in \"" << vowelString << "\": " << vowelCount << endl;
}

void LeapYearFinder() {
    int leapInt;
    cout << endl << "LeapYearFinder() - a function that determines whether an input year is a leap year or not.";
    cout << endl << "Input a year: ";
    cin >> leapInt;

    bool isLeapYear = (leapInt % 4 == 0 && leapInt % 100 != 0) || (leapInt % 400 == 0);
    if (isLeapYear) {
        cout << leapInt << " is a leap year!" << endl;
    } else {
        cout << leapInt << " is not a leap year!" << endl;
    }
}

void SortMe() {
    int arr[5];

    cout << endl << "SortMe() - a function that sorts 5 input numbers ascending.";
    cout << endl << "Enter 5 numbers:";

    for (int i = 0; i < 5; i++) {
        cout << "\nNumber " << (i + 1) << ": ";
        cin >> arr[i];
    }

    for (int i = 0; i < 4; i++) {
        for (int j = 0; j < 4 - i; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    cout << "Sorted Form: ";
    for (int i = 0; i < 5; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;
}
