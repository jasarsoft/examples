Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> import os
>>> os.chdir("C:\\Users\\jasarsoft\\Documents\\GitHub\\examples\\python\\us-opp\\poglavlje09\\")
SyntaxError: multiple statements found while compiling a single statement
>>> import os
>>> os.chdir("C:\\Users\\jasarsoft\\Documents\\GitHub\\examples\\python\\us-opp\\poglavlje09\\")
>>> form simple import funkcija1
SyntaxError: invalid syntax
>>> from simple import funkcija1
modul 'simple' napunjen
>>> funkcija1
<function funkcija1 at 0x02D23F60>
>>> funkcija1()
'funkcija1' je pozvana
>>> funkcija2()
Traceback (most recent call last):
  File "<pyshell#7>", line 1, in <module>
    funkcija2()
NameError: name 'funkcija2' is not defined
>>> import slike.bmp
Traceback (most recent call last):
  File "<pyshell#8>", line 1, in <module>
    import slike.bmp
ModuleNotFoundError: No module named 'slike'
>>> import Slike.Bmp
Traceback (most recent call last):
  File "<pyshell#9>", line 1, in <module>
    import Slike.Bmp
ModuleNotFoundError: No module named 'Slike'
>>> 
