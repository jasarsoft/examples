#Eratostenovo sito (Sieve of Eratosthenes)

from math import sqrt, ceil

def sito(n):
    #vraca listu svih prosti brojeva manji od n
    brojevi = [False, False]+[i for i in range(2,n)]
    for k in range(2, ceil(sqrt(n))):
        if brojevi[k] is not False:
            prosej(k, brojevi)

    return samo_prosti(brojevi)

def prosej(k, lista):
    #uklanja iz lsite brojeve djeljive s k
    for i in range(2*k, len(lista), k):
        lista[i] = False

def samo_prosti(lista):
    #izdvaja listu prosti brojeva
    prosti = []
    for i in lista:
        if i is not False:
            prosti.append(i)

    return prosti

print("Spisak svih prosti brojeva manji od n")
n = int(input("Unesite n: "))
print("Prosti brojevi manji od ", n, " su:\n", sito(n))
