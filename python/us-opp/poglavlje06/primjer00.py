Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def odbrojavanje(n):
	print(n)
	if n > 1:
		odbrojavanje(n-1)

		
>>> odbrojvanje(10)
Traceback (most recent call last):
  File "<pyshell#5>", line 1, in <module>
    odbrojvanje(10)
NameError: name 'odbrojvanje' is not defined
>>> odbrojavanje(10)
10
9
8
7
6
5
4
3
2
1
>>> def broj_unaprijed(n1, n2)
SyntaxError: invalid syntax
>>> def broj_unaprijed(n1, n2):
	if n2 > n1:
		broj_unaprijed(n1, n2-1)
		print(n1)
	else:
		print(n2)

		
>>> broj_unaprijed(2, 5)
2
2
2
2
>>> def broj_unaprijed(n1, n2):
	if n2 > n1:
		broj_unaprijed(n1, n2-1)
		print(n2)
	else:
		print(n2)

		
>>> broj_unaprijed(2, 5)
2
3
4
5
>>> def broj_unazad(n1, n2):
	if n2 > n1:
		print(n2)
		broj_unazad(n1, n2-1)
	else:
		print(n2)

		
>>> broj_unazad(5, 2)
2
>>> broj_unazad(2, 5)
5
4
3
2
>>> def faktorijel(n):
	if n == 0:
		return 1
	else:
		retunr n*faktorijel(n-1)
		
SyntaxError: invalid syntax
>>> 
>>> def faktorijel(n):
	if n == 0:
		return 1
	else:
		return n*faktorijel(n-1)

	
>>> faktorijel(9)
362880
>>> def faktorijel(n):
	f = 1
	for i in range(1, n + 1):
		f = f * i

		
>>> def faktorijel(n):
	f = 1
	for i in range(1, n + 1):
		f = f * i
	return f

>>> faktorijel(10)
3628800
>>> def faktorijel(n, rezultat = 1):
	if n == 0:
		return rezultat
	else:
		return faktorijel(n-1, n*rezultat)

	
>>> faktorijel(5)
120
>>> 
