# Author: Rovic M. Rodriguez | BIT21
class Client:
    def __init__(self, name, age, gender, status):
        self._name = name
        self._age = age
        self._gender = gender
        self._status = status
        

class maleStorage(Client):
    def __init__(self, name, age, gender, status):
        super().__init__(name, age, gender, status)
    
    def message(self):
            print(self._name, self._age, self._gender, self._status)
    
class femaleStorage(Client):
    def __init__(self, name, age, gender, status):
        super().__init__(name, age, gender, status)
    
    def message(self):
            print(self._name, self._age, self._gender, self._status)

mList = []
fList = []

while(True):
    inName = input("Enter name: ")
    inAge = int(input("Enter age: "))
    inGender = input("Enter Gender [Male/Female]: ")
    inStatus = input("Enter status: ")
    
    if(inGender == "Male"):
        male = maleStorage(inName, inAge, inGender, inStatus)
        mList.append(male)

    elif(inGender == "Female"):
        female = femaleStorage(inName, inAge, inGender, inStatus)
        fList.append(female)
        
    print("Male Customer: ")
    for maleStorage in mList:
        maleStorage.message()
    
    print("Hi Sir welcome to our program application exhibit")
    print("Information and data are saving to male storage area")
    print("")
    
    
    print("Female Customer: ")
    for femaleStorage in fList:
        femaleStorage.message()
    
    print("Hi Madam welcome to our program application exhibit")
    print("Information and data are saving to female storage area")
    print("")
        
    
    Input = input("Do you want to add another entry? [Y/N] ")
    if(Input == "Y"):
        continue
    else:
        break
    
    

            
