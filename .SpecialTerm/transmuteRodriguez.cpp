// Programmed by: RODRIGUEZ, ROVIC M. | BIT33
#include <iostream>
 using namespace std;

int main(){
string studentName;
float grade, est;



cout << "\nType Student Name: ";
cin >> studentName;
retry:
cout << "\nType Student Grade: ";
cin >> grade;


    if (grade <= 100 && grade >= 99){
        cout << "Your grade is 4.00";
        }

    else if (grade <= 98 && grade >= 96){
        cout << "Your grade is 3.75";
        }

    else if (grade <= 95 && grade >= 93){
        cout << "Your grade is 3.50";
        }

    else if (grade <= 92 && grade >= 91){
        cout << "Your grade is 3.25";
        }

    else if (grade <= 90 && grade >= 89){
        cout << "Your grade is 3.00";
        }

    else if (grade <= 88 && grade >= 87){
        cout << "Your grade is 2.75";
        }

    else if (grade <= 86 && grade >= 85){
        cout << "Your grade is 2.50";
        }
    else if (grade <= 84 && grade >= 83){
        cout << "Your grade is 2.25";
        }
    else if (grade <= 82 && grade >= 81){
        cout << "Your grade is 2.00";
        }
    else if (grade <= 80 && grade >= 79){
        cout << "Your grade is 1.75";
        }
    else if (grade <= 78 && grade >= 77){
        cout << "Your grade is 1.50";
        }
    else if (grade <= 76 && grade >= 75){
        cout << "Your grade is 1.25";
        }
    else if (grade <= 74 && grade >= 70){
        cout << "Your grade is 1.00";
        }
    else if (grade < 70){
        cout << "Your grade is 0.00";
        }
    else if (grade > 100){
        cout << "Invalid Grade.";
        goto retry;
        }
    else {
        cout << "Your grade is 0.00";
    }

return 0;
}

