Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> matrica = [[1,2,3], [4,5,6],[7,8,9]]
>>> matrica
[[1, 2, 3], [4, 5, 6], [7, 8, 9]]
>>> matrica[1][2]
6
>>> matrica[0][1] = 44
>>> matrica
[[1, 44, 3], [4, 5, 6], [7, 8, 9]]
>>> matrica = [[1, 2, 3, 4, 5],
	       [6, 7, 0, 0, 0],
	       [0, 1, 0, 0, 0],
	       [1, 0, 0, 0, 8],
	       [0, 0, 9, 0, 3]]
>>> a = matrica[0][4]
>>> a
5
>>> a = matrica[1]
>>> a
[6, 7, 0, 0, 0]
>>> matrica = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
>>> suma = 0
>>> for red in matrica:
	for element in red:
		suma = suma + element

		
>>> print("Zbir elemenata matrice = ", suma)
Zbir elemenata matrice =  45
>>> matA = [[1, 2], [4, 5], [7, 8], [4, 5]]
>>> matB = [[1, 2, 3], [4, 5, 6]]
>>> for i in range(len(matA)): #petlja po redoviama A
	for j in range(len(matB[0])): #petlja po kolonama B
		for k in range(len(matB)): #petlja po redovima B
			matC[i][j] = matC[i][j] + matA[i][k] * matB[k][j]

			
Traceback (most recent call last):
  File "<pyshell#27>", line 4, in <module>
    matC[i][j] = matC[i][j] + matA[i][k] * matB[k][j]
NameError: name 'matC' is not defined
>>> matC = [[0, 0, 0], [0, 0, 0], [0, 0, 0], [0, 0, 0]]
>>> for i in range(len(matA)): #petlja po redoviama A
	for j in range(len(matB[0])): #petlja po kolonama B
		for k in range(len(matB)): #petlja po redovima B
			matC[i][j] = matC[i][j] + matA[i][k] * matB[k][j]

			
>>> matC
[[9, 12, 15], [24, 33, 42], [39, 54, 69], [24, 33, 42]]
>>> 
 RESTART: C:/Users/jasarsoft/Documents/GitHub/examples/python/us-opp/poglavlje08/primjer01.py 
Najbliza tacka tacki  [2, 2]  je  [1, 1]  udaljena  1.4142135623730951
>>> kuca = {"boja" : "bez",
	    "stil" : "pedesetih",
	    "brojSoba" : 4,
	    "imaGrazu" : True,
	    "imaAlarm" : False,
	    "kucniBroj" : 123,
	    "ulica" : "Tresnjina",
	    "grad" : "Beograd",
	    "cjena" : 125000}
>>> kuca["cijena"]
Traceback (most recent call last):
  File "<pyshell#41>", line 1, in <module>
    kuca["cijena"]
KeyError: 'cijena'
>>> kuca["cjena"]
125000
>>> gradovi = {"Beograd" : 1659440,
	       "Novi Sad" : 341625,
	       "Nis" : 373404,
	       "Kragujevac" : 179417}
>>> for grad in gradovi
SyntaxError: invalid syntax
>>> for grad in gradovi:
	print(grad)

	
Beograd
Novi Sad
Nis
Kragujevac
>>> for grad in gradovi:
	print(grad, gradovi[grad])

	
Beograd 1659440
Novi Sad 341625
Nis 373404
Kragujevac 179417
>>> vars()
{'__name__': '__main__', '__doc__': None, '__package__': None, '__loader__': <class '_frozen_importlib.BuiltinImporter'>, '__spec__': None, '__annotations__': {}, '__builtins__': <module 'builtins' (built-in)>, '__file__': 'C:/Users/jasarsoft/Documents/GitHub/examples/python/us-opp/poglavlje08/primjer01.py', 'math': <module 'math' (built-in)>, 'euklid': <function euklid at 0x002F9CD8>, 'tacke': [[-1, 3], [-1, -1], [1, 1], [2, 0.5], [2, -1], [3, 3], [4, 2], [4, -0.5]], 'zadana': [2, 2], 'najbliza': [1, 1], 'mind': 1.4142135623730951, 'i': 7, 'd': 3.2015621187164243, 'kuca': {'boja': 'bez', 'stil': 'pedesetih', 'brojSoba': 4, 'imaGrazu': True, 'imaAlarm': False, 'kucniBroj': 123, 'ulica': 'Tresnjina', 'grad': 'Beograd', 'cjena': 125000}, 'gradovi': {'Beograd': 1659440, 'Novi Sad': 341625, 'Nis': 373404, 'Kragujevac': 179417}, 'grad': 'Kragujevac'}
>>> a = b = 123
>>> vars()
{'__name__': '__main__', '__doc__': None, '__package__': None, '__loader__': <class '_frozen_importlib.BuiltinImporter'>, '__spec__': None, '__annotations__': {}, '__builtins__': <module 'builtins' (built-in)>, '__file__': 'C:/Users/jasarsoft/Documents/GitHub/examples/python/us-opp/poglavlje08/primjer01.py', 'math': <module 'math' (built-in)>, 'euklid': <function euklid at 0x002F9CD8>, 'tacke': [[-1, 3], [-1, -1], [1, 1], [2, 0.5], [2, -1], [3, 3], [4, 2], [4, -0.5]], 'zadana': [2, 2], 'najbliza': [1, 1], 'mind': 1.4142135623730951, 'i': 7, 'd': 3.2015621187164243, 'kuca': {'boja': 'bez', 'stil': 'pedesetih', 'brojSoba': 4, 'imaGrazu': True, 'imaAlarm': False, 'kucniBroj': 123, 'ulica': 'Tresnjina', 'grad': 'Beograd', 'cjena': 125000}, 'gradovi': {'Beograd': 1659440, 'Novi Sad': 341625, 'Nis': 373404, 'Kragujevac': 179417}, 'grad': 'Kragujevac', 'a': 123, 'b': 123}
>>> imena = vars()
>>> imena["a"]
123
>>> 
