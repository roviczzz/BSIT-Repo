#include <iostream>
#include <iomanip>
#include <string>

int main() {
    std::string name;
    char type;
    double bill, discount = 0, vat = 0, total, payment, change;

    std::cout << std::fixed << std::setprecision(2);

    std::cout << "Customer name: ";
    std::getline(std::cin, name);

    std::cout << "Total bill (₱): ";
    std::cin >> bill;

    std::cout << "Customer type (R = Regular, M = Member, S = Senior): ";
    std::cin >> type;
    type = toupper(type);

    if (type == 'M') {
        if (bill >= 2000) discount = bill * 0.15;
        else if (bill >= 1000) discount = bill * 0.10;
        else if (bill >= 500) discount = bill * 0.05;
    } else if (type == 'S') {
        discount = bill * 0.12;
    }

    bill -= discount;

    if (type != 'S') vat = bill * 0.12;

    total = bill + vat;

    std::cout << "Payment (₱): ";
    std::cin >> payment;

    change = payment - total;

    std::cout << "\n--- Receipt ---\n";
    std::cout << "Name: " << name << "\n";
    std::cout << "Discount: ₱" << discount << "\n";
    std::cout << "VAT: ₱" << vat << "\n";
    std::cout << "Total: ₱" << total << "\n";
    std::cout << "Payment: ₱" << payment << "\n";
    std::cout << "Change: ₱" << change << "\n";

    return 0;
}