#include <iostream>
using namespace std;

struct student {
    string studname, studcourse;
    char gender;
    int studno;
    float grades[5];
    float avg = 0;
};

int main(){
    student Stu[3];

    for (int i = 0; i < 3; i++){
        int index = i;

        cout << endl << "=== STUDENT " << i+1 << " ===";
        cout << endl << "Student Name: ";

        getline(cin, Stu[i].studname);
        cin.clear();

        cout << "Student Number: ";
        cin >> Stu[index].studno;

        do{
            cout << "Gender: ";
            cin >> Stu[index].gender;
            Stu[i].gender = toupper(Stu[i].gender);

            if (Stu[index].gender != 'M' && Stu[index].gender != 'F'){
                cout << endl << "Invalid Input. Please type M or F \n";
                cin.clear();
            }

        } while (Stu[index].gender != 'M' && Stu[index].gender != 'F');


        cout << "Course: ";
        cin >> Stu[index].studcourse;

        cout << "Grades: ";
        for (int i = 0; i < 5; i++){
            cin >> Stu[index].grades[i];
            Stu[index].avg += Stu[index].grades[i];
        }
        Stu[index].avg /= 5;
        cin.ignore();
        }

        cout << endl << "Student Database Output Form:";
        cout << endl << "==============================";

        cout << endl << "StudentName \t" << "StudNo \t" << "Gender \t" "Course \t" "AveGrade \t";
        for (int i = 0; i < 3; i++){
                cout << endl << Stu[i].studname << "\t\t" << Stu[i].studno << "\t" << Stu[i].gender << "\t" << Stu[i].studcourse << "\t" << Stu[i].avg;
        }

    return 0;
}

