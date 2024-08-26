condition = input('Would you like to continue? ')

if condition == 'no':
    print('Exiting')
    exit()

elif condition == 'n':
    print('Exiting')
    exit()

elif condition == 'yes':
    print('Continuing ...')
    print('Complete!')

elif condition == 'y':
    print('Continuing ...')
    print('Complete!')


else:
    condition = input('Please try again and respond with yes or no ')
