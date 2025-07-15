#include <iostream>
using namespace std;

struct student {
    string studname, studcourse;
    char gender;
    int studno;
    double grades[5];
    double avg = 0;
};

void stuOne(student&); void stuTwo(student&); void stuThree(student&);

int main(){
    student Student1, Student2, Student3;
    
    cout << endl << "Student Database";

    stuOne(Student1);
    stuTwo(Student2);
    stuThree(Student3);

    cout << endl << "Student Database Output Form:";
    cout << endl << "==============================";

    cout << endl << "StudentName \t" << "StudNo \t" << "Gender \t" "Course \t" "AveGrade \t";
    
    cout << endl << Student1.studname << "\t\t" << Student1.studno << "\t" << Student1.gender << "\t" << Student1.studcourse << "\t" << Student1.avg;
    cout << endl << Student2.studname << "\t\t" << Student2.studno << "\t" << Student2.gender << "\t" << Student2.studcourse << "\t" << Student2.avg;
    cout << endl << Student3.studname << "\t\t" << Student3.studno << "\t" << Student3.gender << "\t" << Student3.studcourse << "\t" << Student3.avg;


}

void stuOne(student& studentOne){
    cout << endl << "=== STUDENT 1 ===";
    cout << endl << "Student Name: ";
    getline(cin, studentOne.studname);

    cout << "Student Number: ";
    cin >> studentOne.studno;

    do{
        cout << "Gender: ";
        cin >> studentOne.gender;
        studentOne.gender = toupper(studentOne.gender);

        if (studentOne.gender != 'M' && studentOne.gender != 'F'){
            cout << endl << "Invalid Input. Please type M or F \n";
        }

    } while (studentOne.gender != 'M' && studentOne.gender != 'F');


    cout << "Course: ";
    cin >> studentOne.studcourse;

    cout << "Grades: ";
    for (int i = 0; i < 5; i++){
        cin >> studentOne.grades[i];
        studentOne.avg += studentOne.grades[i];
    }
    studentOne.avg /= 5;
}

void stuTwo(student& studentTwo){
    cout << endl << "=== STUDENT 2 ===";
    cout << endl << "Student Name: ";
    getline(cin, studentTwo.studname);

    cout << "Student Number: ";
    cin >> studentTwo.studno;

    do{
        cout << "Gender: ";
        cin >> studentTwo.gender;
        studentTwo.gender = toupper(studentTwo.gender);

        if (studentTwo.gender != 'M' && studentTwo.gender != 'F'){
            cout << endl << "Invalid Input. Please type M or F \n";
        }

    } while (studentTwo.gender != 'M' && studentTwo.gender != 'F');

    cout << "Course: ";
    cin >> studentTwo.studcourse;

    cout << "Grades: ";
    for (int i = 0; i < 5; i++){
        cin >> studentTwo.grades[i];
        studentTwo.avg += studentTwo.grades[i];
    }
    studentTwo.avg /= 5;
}

void stuThree(student& studentThree){
    cout << endl << "=== STUDENT 3 ===";
    cout << endl << "Student Name: ";
    getline(cin, studentThree.studname);


    cout << "Student Number: ";
    cin >> studentThree.studno;

    do{
        cout << "Gender: ";
        cin >> studentThree.gender;
        studentThree.gender = toupper(studentThree.gender);

        if (studentThree.gender != 'M' && studentThree.gender != 'F'){
            cout << endl << "Invalid Input. Please type M or F \n";
        }

    } while (studentThree.gender != 'M' && studentThree.gender != 'F');

    cout << "Course: ";
    cin >> studentThree.studcourse;

    cout << "Grades: ";
    for (int i = 0; i < 5; i++){
        cin >> studentThree.grades[i];
        studentThree.avg += studentThree.grades[i];
    }
    studentThree.avg /= 5;
}

