word=input("Enter word: ")

for i in range(len(word)):
    if word[i] == 'a' or i == 'A':
        continue
    reword = word.replace('a', '')
print("Inputted word: ", word)
print("Word without 'a': ", reword)
print("Reversed word: ", word[::-1])