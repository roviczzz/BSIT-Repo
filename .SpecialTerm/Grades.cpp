#include <iostream>
 using namespace std;

int main(){
string StudentName;
float prelim, midterm, final, average;

cout << "Enter Student Name: \n";
cin >> StudentName;
cout << "Prelim Grade: \n";
cin >> prelim;
cout << "Midterm Grade: \n";
cin >> midterm;
cout << "Final Grade: \n";
cin >> final;
cout << "Average = " << (prelim+midterm+final)/3 << "\n";

return 0;
}

