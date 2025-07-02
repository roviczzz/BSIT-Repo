#include <iostream>
#include <cmath>
 using namespace std;

int main(){

cout << "Powers of Two\n";
for (int a = 1; a < 8; a++){
    if (a == 1){
        cout << a << " ";
    }
    cout << pow(2, a) << " ";
}
return 0;
}

