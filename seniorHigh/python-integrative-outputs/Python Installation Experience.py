# Simple Calculator

numb1 = int(input('Insert Number 1: '))
op = input('Insert Operator: ')
numb2 = int(input('Insert Number 2: '))

if op == '+':
    print(numb1 + numb2)
elif op == '-':
    print(numb1 - numb2)
elif op == '*':
    print(numb1 * numb2)
elif op == '/':
    print(numb1 / numb2)
else:
    print('none')