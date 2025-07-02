#include <iostream>
using namespace std;

int main() {
    cout << "Loop Design\n";
    int n = 7;
    for (int row = n; row >= 1; row -= 2) {
        int spaces = (n - row) / 2;
        for (int s = 0; s < spaces; ++s) {
            cout << "\t";
        }
        for (int col = 0; col < row; ++col) {
            cout << "&\t";
        }
        cout << endl;
    }
    return 0;
}