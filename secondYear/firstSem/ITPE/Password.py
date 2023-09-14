import re

str = input("Enter password : ")

valid = False
lowercase = re.search('[a-z]', str)
uppercase = re.search('[A-Z]', str)
numbers = re.search('[0-9]', str)
symbols = re.search('[$#@&]', str)

while(valid == False):
    if len(str) < 8:
        print('Minimum of 8 characters')
        break
    elif not lowercase:
        print('Need 1 lowercase')
        break
    elif not uppercase:
        print('Need 1 uppercase')
        break
    elif not numbers:
        print('Need 1 number')
        break
    elif not symbols:
        print('Need 1 symbol')
        break
    else:
        print("Valid Password")
        valid = True
        break
