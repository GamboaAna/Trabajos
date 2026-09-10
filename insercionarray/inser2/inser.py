inputArr = [11, 21, 31, 41, 51, 61] 
ele = 52 
print("Antes de la inserción, el array es: ") 
for j in range(len(inputArr)): print(inputArr[j], end=" ") 
inputArr.insert(5, ele) 
print("\nDespués de la inserción, el array es: ") 
for j in range(len(inputArr)): 
    print(inputArr[j], end=" ")