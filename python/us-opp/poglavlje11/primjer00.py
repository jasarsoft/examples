Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> n = int(input("Unesite cijeli broj > 0: "))
Unesite cijeli broj > 0: 4
>>> for i in range(1, n+1):
	for j in range(1, i + 1):
		print(i * j)

		
1
2
4
3
6
9
4
8
12
16
>>> #funkcija za pronalazenje elemenata u listi
>>> def linearSearch(lista, element):
	for i in range(len(lista)):
		if element == lista[i]:
			return i
	return -1

>>> #funkcija za pronalazenje elementa sortiranje liste
>>> def binarySearch(lista, element):
	low = 0
	high = len(lista) - 1
	while high >= low:
		mid = (low + high) // 2
		if element < lista[mid]:
			high = mid - 1
		elif element == lista[mid]:
			return mid
		else:
			low = mid + 1

			
>>> def binarySearch(lista, element):
	low = 0
	high = len(lista) - 1
	while high >= low:
		mid = (low + high) // 2
		if element < lista[mid]:
			high = mid - 1
		elif element == lista[mid]:
			return mid
		else:
			low = mid + 1
	return -1 #element nije pronadjen

>>> 
