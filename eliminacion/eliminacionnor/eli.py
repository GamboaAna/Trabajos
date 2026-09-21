inputArr = [11, 21, 31, 41, 51, 61]
print("Antes de la eliminacion, el array es: ")
for j in range(len(inputArr)):
    print(inputArr[j], end=" ")

del inputArr[0]

print("\nDespues de la eliminacion, el array es: ")
for j in range(len(inputArr)):
    print(inputArr[j], end=" ")