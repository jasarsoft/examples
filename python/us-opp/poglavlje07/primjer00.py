Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> 'rekao je "naravno"'
'rekao je "naravno"'
>>> "rekao je 'naravno'"
"rekao je 'naravno'"
>>> 'rekao je \' naravno\''
"rekao je ' naravno'"
>>> for ch in 'Monty Python':
	print(ch)

M
o
n
t
y
 
P
y
t
h
o
n
>>> s = 'Monty Python'
>>> for i in range(len(s)):
	print(s[i])

	
M
o
n
t
y
 
P
y
t
h
o
n
>>> s = "Pithon"
>>> s = s[0] + "y" + s[2:]
>>> s
'Python'
>>> a = [10, 20, 30, 40]
>>> a
[10, 20, 30, 40]
>>> b = ['kruska', 'jabuka', 'banana', 2.0]
>>> b
['kruska', 'jabuka', 'banana', 2.0]
>>> c = ["kruska", 1, "jabuka", 2.0]
>>> c
['kruska', 1, 'jabuka', 2.0]
>>> lista = [10, 20, 30, 40, 60, 90]
>>> for n in lista:
	print(n)

	
10
20
30
40
60
90
>>> n = 0
>>> while n < len(lista):
	print(lista[n])
	n = n + 1

	
10
20
30
40
60
90
>>> lista = [10, 30, 90, 40, 50, 80]
>>> 
>>> podataka = 40
>>> pronadjen = False
>>> i = 0
>>> while k < len(lista) and not pronadjen:
	if lista[i] == podatak:
		pronadjen = True
	else:
		i = i + 1
	if pronadjen:
		print("Podatak je pronadjen")
	else:
		print("Podatak nije pronadjen")

		
Traceback (most recent call last):
  File "<pyshell#42>", line 1, in <module>
    while k < len(lista) and not pronadjen:
NameError: name 'k' is not defined
>>> while i< len(lista) and not pronadjen:
	if lista[i] == podatak:
		pronadjen = True
	else:
		i = i + 1
	if pronadjen:
		print("Podatak je pronadjen")
	else:
		print("Podatak nije pronadjen")

		
Traceback (most recent call last):
  File "<pyshell#44>", line 2, in <module>
    if lista[i] == podatak:
NameError: name 'podatak' is not defined
>>> podatak = 40
>>> while i< len(lista) and not pronadjen:
	if lista[i] == podatak:
		pronadjen = True
	else:
		i = i + 1
	if pronadjen:
		print("Podatak je pronadjen")
	else:
		print("Podatak nije pronadjen")

		
Podatak nije pronadjen
Podatak nije pronadjen
Podatak nije pronadjen
Podatak je pronadjen
>>> lista1 = [10, 20, 30, 40]
>>> lista2 = lista1
>>> lista1[0] = 5
>>> lista1
[5, 20, 30, 40]
>>> lista2
[5, 20, 30, 40]
>>> lista2 = lista1.copy()
>>> lista1[0] = 10
>>> lista1
[10, 20, 30, 40]
>>> lista2
[5, 20, 30, 40]
>>> stek = [3, 4, 5]
>>> stek.append(6)
>>> stek.append(7)
>>> stek
[3, 4, 5, 6, 7]
>>> stek.pop()
7
>>> stek
[3, 4, 5, 6]
>>> [x**3 for x in [1, 2, 3]]
[1, 8, 27]
>>> [x**3 for x in range(5)]
[0, 1, 8, 27, 64]
>>> lista = [-1, 1, -2, 2, -3, 3, -4, 4]
>>> [x for x in lista if x >= 0]
[1, 2, 3, 4]
>>> #pronalazenje svih pojava samoglasnika u tekstu
>>> samoglasnici = ('a', 'e', 'i', 'o', 'u')
>>> text = "Programiranje"
>>> 
KeyboardInterrupt
>>> [ch for ch in tekst if ch in samoglasnici]
Traceback (most recent call last):
  File "<pyshell#70>", line 1, in <module>
    [ch for ch in tekst if ch in samoglasnici]
NameError: name 'tekst' is not defined
>>> [ch for ch in text if ch in samoglasnici]
['o', 'a', 'i', 'a', 'e']
>>> #unija elemenata dvije lista:
>>> [(x, y) for x in [1,2,3] for y in [3, 1, 4] if x != y]
[(1, 3), (1, 4), (2, 3), (2, 1), (2, 4), (3, 1), (3, 4)]
>>> matrica = [[1,2,3], [4,5,6], [7,8,9]]
>>> matrica
[[1, 2, 3], [4, 5, 6], [7, 8, 9]]
>>> a = (1,2,3,4)
>>> a
(1, 2, 3, 4)
>>> a[1] = 1
Traceback (most recent call last):
  File "<pyshell#78>", line 1, in <module>
    a[1] = 1
TypeError: 'tuple' object does not support item assignment
>>> 
