lista = [ 2, 4, 6, 10, 16]

print(lista)

print(lista[2]) #6

lista[1] = 3
print(lista) #[2, 3, 6, 10, 16]

lista = [ 2, 4, 6, 10, 16, 26, 42]
print(lista[0:3]) #[2, 4, 6]
print(lista[:3]) #[2, 4, 6]

print(lista[2:5]) #[6, 10, 16]

print(lista[4:]) #[16, 26, 42]

print(lista[1:-1]) #[4, 6, 10, 16, 26]

print(lista[-2:]) #[26, 42]

print(lista[-3:]) #[16, 26, 42]


lista = [2, 4, 7, 9, 11, 2, 223]

for vrijednost in lista:
    print(vrijednost * vrijednost)

#brisanje cetvrtog elementa
print(lista)
del lista[3]
print(lista)

#dodavanje vrijednsot
lista.append(200)
print(lista)

#ubacivanje u tacno odredjenu poziciju
lista.insert(2, 5)
print(lista)

#brisanje konkretne vrijednosti
lista.remove(11) #brisanje vrijednosti 11
print(lista)

#brisanje samo prve vrijednosti
lista.insert(1, 11)
lista.insert(3, 11)
lista.insert(5, 11)
print(lista)
lista.remove(11)

#brisanje svih vrijednosti 11
print(lista)
while 11 in lista:
    lista.remove(11)
print(lista)

#okretanje liste
lista.reverse()
print(lista)

#sortiranje lista
print(lista)
lista.sort()
print(lista)

#rjecnik
student = {}

student["ime"] = "Milan"
student["prezime"] = "Tair"
student["indeks"] = 2008212514

print(student)
#ispis vrijednosti imena
print("Ime studenta je " + student["ime"])

student["indeks"] = 2012
print(student)

def fib(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fib(n-1) + fib(n-2)

rezultat = fib(10)
print(rezultat)

fibVrijednosti = { 0: 0, 1: 1}

#fibVrijednosti[0] = 0
#fibVrijednosti[1] = 1

def fib2(n):
    if n in fibVrijednosti:
        return fibVrijednosti[n]
    else:
        rezultat = fib2(n-1) + fib2(n-2)
        fibVrijednosti[n] = rezultat
        return rezultat

print(fib2(100))


