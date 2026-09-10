TwoDimensionalArray = [
    [1,2,3],
    [4,5,6],
    [7,8,9]
]

print("Los elementos del array por columnas son: ")
num_columnas = len(TwoDimensionalArray[0])

for col in range(num_columnas):
    for row in TwoDimensionalArray:
        print(row[col], end=" ")
    print()