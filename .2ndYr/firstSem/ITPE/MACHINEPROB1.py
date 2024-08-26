size = int(input("Enter size : "))
n = input("Enter numbers : ").split()
positive, negative = 0, 0
num = 0
divisible = []
Sum = 0

for i in range(0, size, 1):
    n[i] = int(n[i])
    if n[i] == 0:
        break
    if n[i] > 0:
        positive += 1
    else:
        negative += 1
        
for i in range(0, size, 1):
    n[i] = int(n[i])
    if n[i]%3==0:
        divisible.append(n[i])
      
Sum = sum(n)

print("Positive Numbers :", positive)
print("Negative Numbers :", negative)
print("Divisible Numbers :", divisible)
print("Sum of all Numbers :", Sum)

