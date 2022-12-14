import os
import sys

Selection1 = 0 # Unit Selection 1
Number1 = 0    # Degree of Number
Selection2 = 0 # Unit Selection 2
Answer = 0     # Final Answer

# Loop statements to avoid string values and invalid selection
while Selection1 != 1 or 2 or 3:
    try:
        print('')
        print('Temperature Converter | Group 10')
        print('Type the Number that corresponds to the first unit to convert from: ')

        print('1. Kelvin')
        print('2. Celsius')
        print('3. Fahrenheit')
        print('')
        print('')
        Selection1 = int(input('Input: '))

        if Selection1 == 1:
            print('First Unit: Kelvin')
            print('')
            break
        elif Selection1 == 2:
            print('First Unit: Celsius')
            print('')
            break
        elif Selection1 == 3:
            print('First Unit: Fahrenheit')
            print('')
            break

        else:
            print('')
            print('None of the input was valid. Select numbers ranging from 1-3')
            print('')
            continue

    except ValueError:
        print('')
        print("Please input integer only...")
        print('')
        continue

# Asking for number input for the first unit's number/ measurement
while Number1 >= 0 <= 0:
    try:
        print('')
        print('Type the number in first unit form')
        Number1 = int(input('Input: '))
        break

    except ValueError:
        print('')
        print("Please input integer only...")
        print('')
        continue

# # Asking for the number that corresponds to an unused unit and would be used for the conversion
while Selection2 != 1 or 2 or 3: 
        print('')
        print('Type the number that would be used for the conversion to second temperature unit')

        print('1. Kelvin')
        print('2. Celsius')
        print('3. Fahrenheit')
        print('')
        print('')
        
        Selection2 = int(input('Input: '))
        if Selection2 == 1 and Selection1 == 1:
            print('Your first unit and second unit were the same...')
            print('Please choose another unit.')
            print('')
            continue
        elif Selection2 == 2 and Selection1 == 2:
                print('Your first unit and second unit were the same...')
                print('Please choose another unit.')
                print('')
                continue
        elif Selection2 == 3 and Selection1 == 3:
                print('Your first unit and second unit were the same...')
                print('Please choose another unit.')
                print('')
                continue

            # Start of Conversion: Kelvin to unit
        elif Selection1 == 1 and Selection2 == 2:
                Answer = Number1 - 273.15
                f_answer = str(Answer)
                print(f_answer + '°C was the converted temperature.')
                break

        elif Selection1 == 1 and Selection2 == 3:
                Answer = (Number1 - 273.15) * 9/5 + 32
                f_answer = str(Answer)
                print(f_answer + '°F was the converted temperature.')
                break

            # Start of Conversion: Celcius to unit
        elif Selection1 == 2 and Selection2 == 1:
                Answer = Number1 + 273.15
                f_answer = str(Answer)
                print(f_answer + 'K was the converted temperature.')
                break

        elif Selection1 == 2 and Selection2 == 3:
                Answer = (Number1 * 9/5) + 32
                f_answer = str(Answer)
                print(f_answer + '°F was the converted temperature.')
                break

            # Start of Conversion: Fahrenheit to unit
        elif Selection1 == 3 and Selection2 == 1:
                Answer = (Number1 - 32) * 5/9 + 273.15
                f_answer = str(Answer)
                print(f_answer + 'K was the converted temperature.')
                break

        elif Selection1 == 3 and Selection2 == 2:
                Answer = (Number1 - 32) * 5/9
                f_answer = str(Answer)
                print(f_answer + '°C was the converted temperature.')
                break

        else:
                print('')
                print('None of the input was valid. Select numbers ranging from 1-3')
                print('')
                continue


        # Attempt of Restarting the program or to exit
def restart_program():
    python = sys.executable
    os.execl(sys.executable, sys.executable, *sys.argv)

Term = ''
while Term != 'y' or 'n':
    print('')
    print("Would you like to restart? [y/n]")
    Term = str(input())

    if Term == 'y':
        restart_program()

    if Term == 'n': 
        print('The program will be closed...')
        sys.exit()

    else:
        print('')
        continue