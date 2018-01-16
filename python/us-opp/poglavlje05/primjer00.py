Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def maksimum(n1, n2):
	if n1 > n2:
		rezultat = n1
	else:
		rezultat = n2
	return rezultat

>>> veci = maksimum(10, 20)
>>> veci
20
>>> def zbir(n1, n2)
SyntaxError: invalid syntax
>>> def zbir(n1, n2):
	n = 0
	for i in range(n1, n2+1):
		n = n + 1
	return n

>>> print("Zbir brojeva od 1 do 11 je ", zbir(1, 10))
Zbir brojeva od 1 do 11 je  10
>>> def zbir(n1, n2):
	n = 0
	for i in range(n1, n2+1):
		n = n + i
	return n

>>> print("Zbir brojeva od 1 do 11 je ", zbir(1, 10))
Zbir brojeva od 1 do 11 je  55
>>> def f(p1, p2, p3)
SyntaxError: invalid syntax
>>> def f(p1, p2, p3):
	return p1 + p2 + p3

>>> f(1, 12, 400)
413
>>> f(p3=400, p1=1, p2=12)
413
>>> def povecaj(x):
	x = x + 1

	
>>> brojac = 1
>>> povecaj(brojac)
>>> brojac
1
>>> def f1():
	a = 2
	def f2():
		a = 3
		print(a)
	f2()
	print(a)
a = 1
SyntaxError: invalid syntax
>>> def f1():
	a = 2
	def f2():
		a = 3
		print(a)
	f2()
	print(a)

	
>>> a = 1
>>> f1()
3
2
>>> print(a)
1
>>> def f1():
	global a = 2
	def f2():
		global a = 3
		print(a)
	f2()
	print(a)
	
SyntaxError: invalid syntax
>>> def f1():
	a = 2
	def f2():
		a = 3
		print(a)
	f2()
	print(a)

	
>>> global a
>>> def f1():
	a = 2
	def f2():
		a = 3
		print(a)
	f2()
	print(a)

	
>>> f1()
3
2
>>> def f1():
	global a = 2
	def f2():
		global a = 3
		print(a)
	f2()
	print(a)
	
SyntaxError: invalid syntax
>>> f1()
3
2
>>> def f(x): return x**2-1

>>> f = lambda x: x**2-1
>>> print(f(100))
9999
>>> 
