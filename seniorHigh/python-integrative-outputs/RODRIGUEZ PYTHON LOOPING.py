import random

value = 2
count = 0
guess = 0

while guess != value:
    count += 1
    guess = input('Test your luck by typing "flip" to flip heads! ')
    if guess == 'flip':
        guess = random.randint(0,3)
        guess = int(guess)
        print('You rolled TAILS, type "flip" to try again! ')

else:
    print(f'You finally flipped HEADS in {count} tries!')