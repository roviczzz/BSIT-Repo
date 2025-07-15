# include <iostream>
using namespace std;

struct Employee {
string employeeName, employeeNum;
char gender;
double hrsWorked, ratePerHour, overtime, sss, pagIbig, philHealth, grosspay, totalDeductions, tax, netpay;
};

void compGrosspay(Employee& emp); void compTotalDeductions(Employee& emp); void compNetpay(Employee& emp); void compTax(Employee& emp);


int main(){
    Employee Employee1;
    cout << "=== Employee Info ===";
    cout << endl << "Employee Name (ex. John Smith): ";
    getline(cin, Employee1.employeeName);
    cout << endl << "Employee Number (ex. M-456): ";
    getline(cin, Employee1.employeeNum);
    cout << endl << "Employee Gender: (F/M) ";
    cin >> Employee1.gender; Employee1.gender = tolower(Employee1.gender);
    while(Employee1.gender != 'f' && Employee1.gender != 'm'){
        cout << "Invalid input. Please type F or M ";
        cin >> Employee1.gender;
        Employee1.gender = tolower(Employee1.gender);
        cin.clear();
    }

    cout << endl << "Hours Worked (ex. 45): ";
    cin >> Employee1.hrsWorked;
    cout << endl << "Rate per Hour (ex. 356.45): ";
    cin >> Employee1.ratePerHour;
    cout << endl << "*Income Tax: ";
    
    compGrosspay(Employee1);
    compTax(Employee1);
    
    cout << endl << endl << "SSS (ex. 1500): ";
    cin >> Employee1.sss;
    cout << endl << "PAG-IBIG (ex. 500): ";
    cin >> Employee1.pagIbig;
    cout << endl << "PhilHealth (ex. 2300): ";
    cin >> Employee1.philHealth;
    cout << endl << "Overtime (ex. 1000): ";
    cin >> Employee1.overtime;
    cout << endl << "*NET PAY: ";
    
    compTotalDeductions(Employee1);
    compNetpay(Employee1);
    
    cout << endl << "===============";

return 0;
}

void compGrosspay(Employee& emp){
    emp.grosspay = emp.hrsWorked * emp.ratePerHour;
}

void compTotalDeductions(Employee& emp){
    emp.totalDeductions = emp.sss + emp.pagIbig + emp.philHealth;
}

void compTax(Employee& emp){
    emp.tax = emp.grosspay * .20;
    cout << emp.tax;
}

void compNetpay(Employee& emp){
    emp.netpay = emp.grosspay + emp.overtime - (emp.totalDeductions + emp.tax);
    cout << emp.netpay;
}