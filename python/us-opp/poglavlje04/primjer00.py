Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> broj = 10
>>> while broj > 0:
	print("Broj = ", i)
	broj = broj - 3

Traceback (most recent call last):
  File "<pyshell#4>", line 2, in <module>
    print("Broj = ", i)
NameError: name 'i' is not defined
>>> while broj > 0:
	print("Broj = ", broj)
	broj = broj -3

	
Broj =  10
Broj =  7
Broj =  4
Broj =  1
>>> zbir = 0
>>> broj = 0
>>> while broj < 20:
	broj = broj + 1
	zbir = zbir + broj
	if zbir >= 100:
		break #skok izvan petlje
print("Vrijednost promjenjljive broj je ", broj)
SyntaxError: invalid syntax
>>> while broj < 20:
	broj = broj + 1
	zbir = zbir + broj
	if zbir >= 100:
		break #skok izvan petlje

	
>>> print("Vrijednost promjenjljive broj je ", broj)
Vrijednost promjenjljive broj je  14
>>> print("Zbir je ", zbir)
Zbir je  105
>>> zbir = 0
>>> broj = 0
>>> while broj < 20:
	broj = broj + 1
	if broj == 10 or broj == 11:
		continue #skok na kraj tekuce iteracije
	zbir = zbir + broj

>>> print("Vrijednost promjenjljive broj je ", broj)
Vrijednost promjenjljive broj je  20
>>> print("Zbir je ", zbir)
Zbir je  189
>>> n = int(input("Unesite cijeli broj >= 2: "))
Unesite cijeli broj >= 2: 10
>>> djelilac = 2
>>> while djelilac <= n:
	if n % djelilac == 0:
		break
	djelilac = djelilac + 1

	
>>> print("Najmanji djelilac broja", n, " je ", djelilac)
Najmanji djelilac broja 10  je  2
>>> n = int(input("Unesi cijeli broj >= 2: "))
Unesi cijeli broj >= 2: 22
>>> nadjen = False
>>> djelilac = 2
>>> while djelilac <= n and not nadjen:
	if n % djelilac == 0:
		nadjen = True
	else:
		djelilac = djelilac + 1

	
>>> print("Najmanji djelilac broja ", n, " je ", djelilac)
Najmanji djelilac broja  22  je  2
>>> 
