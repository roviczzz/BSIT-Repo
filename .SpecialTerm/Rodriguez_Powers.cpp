// PROGRAMMED BY: RODRIGUEZ, ROVIC M. BIT33
#include <iostream>
#include <cmath>
#include <vector>
using namespace std;

int main() {

    int i = 9;
    int a = 0;
    int b, c, d, e;
    vector<int> sqr;
    vector<int> cbc;
    vector<int> qtc;
    vector<int> qic;

        do {
        a++;
        b = a * a;
        sqr.push_back(b);
    }
    while (a <= i);
    
    i = 9;
    a = 0;
    
    do {
        a++;
        c = a * a * a;
        cbc.push_back(c);
    }
    while (a <= i);

    i = 9;
    a = 0;
    
    do {
        a++;
        d = a * a * a * a;
        qtc.push_back(d);
    }
    while (a <= i);

    i = 9;
    a = 0;
    
    do {
        a++;
        e = a * a * a * a * a;
        qic.push_back(e);
    }
    while (a <= i);


    cout << "\n";
    cout << "Number \t Square \t Cubic \t Quartic \t Quintic\n";
    cout << "1 \t " << sqr.at(1-1) << "\t\t " << cbc.at(1-1) << "\t " << qtc.at(1-1) << "\t\t " << qic.at(1-1) << "\n";
    cout << "2 \t " << sqr.at(2-1) << "\t\t " << cbc.at(2-1) << "\t " << qtc.at(2-1) << "\t\t " << qic.at(2-1) << "\n";
    cout << "3 \t " << sqr.at(3-1) << "\t\t " << cbc.at(3-1) << "\t " << qtc.at(3-1) << "\t\t " << qic.at(3-1) << "\n";
    cout << "4 \t " << sqr.at(4-1) << "\t\t " << cbc.at(4-1) << "\t " << qtc.at(4-1) << "\t\t " << qic.at(4-1) << "\n";
    cout << "5 \t " << sqr.at(5-1) << "\t\t " << cbc.at(5-1) << "\t " << qtc.at(5-1) << "\t\t " << qic.at(5-1) << "\n";
    cout << "6 \t " << sqr.at(6-1) << "\t\t " << cbc.at(6-1) << "\t " << qtc.at(6-1) << "\t\t " << qic.at(6-1) << "\n";
    cout << "7 \t " << sqr.at(7-1) << "\t\t " << cbc.at(7-1) << "\t " << qtc.at(7-1) << "\t\t " << qic.at(7-1) << "\n";
    cout << "8 \t " << sqr.at(8-1) << "\t\t " << cbc.at(8-1) << "\t " << qtc.at(8-1) << "\t\t " << qic.at(8-1) << "\n";
    cout << "9 \t " << sqr.at(9-1) << "\t\t " << cbc.at(9-1) << "\t " << qtc.at(9-1) << "\t\t " << qic.at(9-1) << "\n";
    cout << "10 \t " << sqr.at(10-1) << "\t\t " << cbc.at(10-1) << "\t " << qtc.at(10-1) << "\t\t " << qic.at(10-1) << "\n";


    return 0;
}