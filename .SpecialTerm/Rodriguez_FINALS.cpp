#include <iostream>
#include <string>
#include <cctype>

using namespace std;

string devType, manufacturer, model, serial, cpu, ramSize, storage;
string itemCode, location;
char state;

struct InventoryItem {
    string productName;
    string category;
    double weightKg;
    string supplier;
    int stockCount;
    string code;
    int quantity;
};

void inputDetails() {
    cout << "Enter Item Code: ";
    getline(cin, itemCode);
    cout << "Enter Storage Location: ";
    getline(cin, location);
    cout << "Details recorded.\n\n";
}

void showDetails() {
    cout << "\nItem Code: " << itemCode << "\nLocation: " << location << "\n\n";
}

int main() {
    int selection;

main_menu:
    cout << "\nCOMPUTER INVENTORY MANAGEMENT SYSTEM";
    cout << "\n===========================\n";
    cout << "[1] - Device Specifications Entry\n";
    cout << "[2] - Status Validation\n";
    cout << "[3] - Inventory Processing\n";
    cout << "[4] - Inventory Data Storage\n";
    cout << "[5] - Core Inventory Operations\n";
    cout << "[6] - Inventory Data Models\n";
    cout << "[7] - Dynamic Data Handling\n";
    cout << "[8] - Exit\n";

    cout << "\nEnter your choice (1-8): ";
    while (!(cin >> selection) || selection < 1 || selection > 8) {
        cout << "Invalid input. Enter a number 1-8: ";
        cin.clear();
        cin.ignore(10000, '\n');
    }
    cin.ignore(10000, '\n'); 

    switch (selection) {
        case 1: { // basic io
            char con;
            string devTypeInput, manufacturerInput, modelInput, serialInput, cpuInput, ramSizeInput, storageInput;

        io:
            cout << "\nDevice Specifications\n======================\n";

            cout << "Enter Device Type (laptop/desktop/server/etc): ";
            getline(cin, devTypeInput);
            cout << "Enter Manufacturer: ";
            getline(cin, manufacturerInput);
            cout << "Enter Model: ";
            getline(cin, modelInput);
            cout << "Enter Serial Number: ";
            getline(cin, serialInput);
            cout << "Enter CPU Type: ";
            getline(cin, cpuInput);
            cout << "Enter RAM Size: ";
            getline(cin, ramSizeInput);
            cout << "Enter Storage Capacity: ";
            getline(cin, storageInput);

            cout << "\n=== DEVICE SPECIFICATION REVIEW ===\n";
            cout << "Device Type: " << devTypeInput << "\n";
            cout << "Manufacturer: " << manufacturerInput << "\n";
            cout << "Model: " << modelInput << "\n";
            cout << "Serial Number: " << serialInput << "\n";
            cout << "CPU Type: " << cpuInput << "\n";
            cout << "RAM Size: " << ramSizeInput << "\n";
            cout << "Storage Capacity: " << storageInput << "\n";

            cout << "Is this correct? (y/n): ";
            cin >> con;
            cin.ignore(10000, '\n');
            if (tolower(con) == 'n') goto io;

            devType = devTypeInput; manufacturer = manufacturerInput; model = modelInput;
            serial = serialInput; cpu = cpuInput; ramSize = ramSizeInput; storage = storageInput;
            break;
        }

        case 2: { // conditional
            char con;
        cons:
            cout << "\nSELECT DEVICE STATUS\n=====================\n";
            cout << "[A] - Active\n[R] - Reserved\n[D] - Decommissioned\n";

            cout << "Enter status (A/R/D): ";
            while (!(cin >> state)) {
                cout << "Invalid input. Enter A, R, or D: ";
                cin.clear();
                cin.ignore(10000, '\n');
            }
            cin.ignore(10000, '\n');
            state = tolower(state);

            if (state == 'a') cout << "Device marked as active.\n";
            else if (state == 'r') cout << "Device marked as reserved for maintenance.\n";
            else if (state == 'd') cout << "Device marked for decommission.\n";
            else {
                cout << "Invalid choice.\n";
                goto cons;
            }

            cout << "Is this correct? (y/n): ";
            cin >> con;
            cin.ignore(10000, '\n');
            if (tolower(con) == 'n') goto cons;

            break;
        }

        case 3: { // loop
            char choice;
            char cont;

        loops:
            cout << "\nINVENTORY FIELD UPDATE\n======================\n";
            cout << "Current device info:\n";
            cout << "1. Device Type:    " << devType << "\n";
            cout << "2. Manufacturer:   " << manufacturer << "\n";
            cout << "3. Model:          " << model << "\n";
            cout << "4. Serial Number:  " << serial << "\n";
            cout << "5. CPU Type:       " << cpu << "\n";
            cout << "6. RAM Size:       " << ramSize << "\n";
            cout << "7. Storage:        " << storage << "\n";

            cout << "Select field number to update (1-7) or 0 to quit: ";
            cin >> choice;
            cin.ignore(10000, '\n');

            string input;
            switch (choice) {
                case '1':
                    cout << "Enter new Device Type: ";
                    getline(cin, input);
                    if (!input.empty()) devType = input;
                    break;
                case '2':
                    cout << "Enter new Manufacturer: ";
                    getline(cin, input);
                    if (!input.empty()) manufacturer = input;
                    break;
                case '3':
                    cout << "Enter new Model: ";
                    getline(cin, input);
                    if (!input.empty()) model = input;
                    break;
                case '4':
                    cout << "Enter new Serial Number: ";
                    getline(cin, input);
                    if (!input.empty()) serial = input;
                    break;
                case '5':
                    cout << "Enter new CPU Type: ";
                    getline(cin, input);
                    if (!input.empty()) cpu = input;
                    break;
                case '6':
                    cout << "Enter new RAM Size: ";
                    getline(cin, input);
                    if (!input.empty()) ramSize = input;
                    break;
                case '7':
                    cout << "Enter new Storage: ";
                    getline(cin, input);
                    if (!input.empty()) storage = input;
                    break;
                case '0':
                    cout << "Exiting update.\n";
                    break;
                default:
                    cout << "Invalid choice. Choose 1-7 or 0 to quit.\n";
                    break;
            }

            if (choice != '0') {
                cout << "Update another field? (y/n): ";
                cin >> cont;
                cin.ignore(10000, '\n');
                if (tolower(cont) == 'y') goto loops;
            }
            break;
        }

        case 4: { // arrays
            char cont;
            do {
                int size;
                cout << "\nINVENTORY STORAGE ARRAY\n";
                cout << "=======================\n";
                cout << "Enter number of inventory items: ";
                cin >> size;
                cin.ignore(10000, '\n');

                string* serialNumbers = new string[size];
                int* quantities = new int[size];

                for (int i = 0; i < size; ++i) {
                    cout << "Enter serial number for item " << (i + 1) << ": ";
                    getline(cin, serialNumbers[i]);
                    cout << "Enter quantity for item " << (i + 1) << ": ";
                    cin >> quantities[i];
                    cin.ignore(10000, '\n');
                }

                cout << "\nStored Inventory Items:\n";
                for (int i = 0; i < size; ++i) {
                    cout << "Item " << (i + 1) << ": Serial Number = " << serialNumbers[i]
                         << ", Quantity = " << quantities[i] << "\n";
                }

                delete[] serialNumbers;
                delete[] quantities;

                cout << "\nDo you want to enter more inventory? (y/n): ";
                cin >> cont;
                cin.ignore(10000, '\n');
            } while (tolower(cont) == 'y');
            break;
        }

        case 5: { // functions
            cout << "\nINVENTORY ITEM MANAGEMENT\n";
            cout << "=========================\n";
            int choice;

            do {
                cout << "1. Input Details\n2. Show Details\n3. Exit\nChoice: ";
                cin >> choice;
                cin.ignore(10000, '\n');

                if (choice == 1) inputDetails();
                else if (choice == 2) showDetails();
                else if (choice != 3) cout << "Invalid choice.\n";

            } while (choice != 3);

            cout << "Exiting core inventory operations.\n";
            break;
        }

        case 6: { // structures
            char con;
            InventoryItem item;

        dataModelInput:
            cout << "\nINVENTORY DATA MODEL\n=====================\n";

            cout << "Enter product name: ";
            getline(cin, item.productName);

            cout << "Enter product category: ";
            getline(cin, item.category);

            cout << "Enter weight in kilograms: ";
            cin >> item.weightKg;
            cin.ignore(10000, '\n');

            cout << "Enter supplier name: ";
            getline(cin, item.supplier);

            cout << "Enter stock count: ";
            cin >> item.stockCount;
            cin.ignore(10000, '\n');

            cout << "\nProduct Details:\n";
            cout << "Name: " << item.productName << "\n";
            cout << "Category: " << item.category << "\n";
            cout << "Weight: " << item.weightKg << " kg\n";
            cout << "Supplier: " << item.supplier << "\n";
            cout << "Stock Count: " << item.stockCount << "\n";

            cout << "Is this correct? (y/n): ";
            cin >> con;
            cin.ignore(10000, '\n');

            if (tolower(con) == 'n') goto dataModelInput;

            break;
        }

        case 7: { // pointers
            char con;

        dynDataEntry:
            cout << "\nINVENTORY ITEM ENTRY\n====================\n";

            InventoryItem* pItem = new InventoryItem;

            cout << "Enter item code: ";
            getline(cin, pItem->code);

            cout << "Enter quantity: ";
            cin >> pItem->quantity;
            cin.ignore(10000, '\n');

            cout << "\nItem Info:\n";
            cout << "Code: " << pItem->code << "\n";
            cout << "Quantity: " << pItem->quantity << "\n";
            cout << "Memory address of item: " << pItem << "\n";

            delete pItem;
            pItem = nullptr;

            cout << "Is this correct? (y/n): ";
            cin >> con;
            cin.ignore(10000, '\n');

            if (tolower(con) == 'n') goto dynDataEntry;

            break;
        }

        case 8: // quit
            cout << "\nCOMPUTER INVENTORY MANAGEMENT SYSTEM\n";
            cout << "Developed by: Rodriguez, Rovic M. | BIT33\n";
            cout << "A submission for ITWB344\n";
            return 0;

        default:
            cout << "Unknown selection.\n";
            break;
    }
    goto main_menu;
}
