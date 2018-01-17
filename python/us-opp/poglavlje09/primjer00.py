Python 3.6.4 (v3.6.4:d48eceb, Dec 19 2017, 06:04:45) [MSC v.1900 32 bit (Intel)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> def brojProstihBrojeva(od, do):
	""" Vraca broj prostih brojeva izmedju dva zadana broja.

	    Vraca kod -1 ako je vrijednsot 'od' veca od vrijednsoti 'do'
	"""

	
>>> def ucitaj_godinu():
	"""Vraca cijeli broj izmedju 1800 i 2099,
	   ukljuceno ili -1, """"
	
SyntaxError: EOL while scanning string literal
>>> def ucitaj_godinu():
	"""Vraca cijeli broj izmedju 1800 i 2099,
	   ukljuceno ili -1, """

	
>>> def prestupna_godina(godina):
	""" Vraca True ako je unesena godina prestupna
	    inace vraca vrijednsot False."""

	
>>> def dan_u_nedelji_prvog_januara(godina, prestupna):
	""" Vraca dan u nedelji za 1. jaunar zadane godine.

	    Godina mora biit izmedju 1800 i 2099,
	    a funkcija prestupna_godina() mora biti True
	    ako je godina prestupna, inace je False.
	"""

	
>>> #modul simple
>>> import os
>>> os.chdir("C:\\Users\\jasarsoft\\Documents\\GitHub\\examples\\python\\us-opp\\poglavlje09\\")
>>> import simple
modul 'simple' napunjen
>>> simple.funkcija2()
'funkcija2' je pozvana
>>> from simple import *
>>> funkcija2()
'funkcija2' je pozvana
>>> form simple import funkcija1
SyntaxError: invalid syntax
>>> from simple import funkcija1
>>> funkcija1()
'funkcija1' je pozvana
>>> funkcija2()
'funkcija2' je pozvana
>>> simple.funkcija2()
'funkcija2' je pozvana
>>> 
