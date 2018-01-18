# Bubble sort
# Funkcija sortiranja elemenata u rastucem poretku

def bubbleSort(lista):
    n = len(lista)
    for i in range(n-1):
        #protok (bubble) najveceg elementa na kraj
        for i in range(n-1-i):
            if lista[j] > lista[j+1]:
                temp        = lista[j]
                lista[j]    = lista[j+1]
                lista[j+1]  = temp
                #lista[j], lista[j+1] = lista[j+1],lista[j]

