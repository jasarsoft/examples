#funkcija sortiranja elemenata u rastucem poretku

def selectionSort(lista):
    for i in range(len(lista) - 1):
        #pronadje se najmanji element u [i:len(lista)]
        tekuciMin = lista[i]
        tekuciMinInd = i
        for j in range(i + 1, len(lista)): #selekcija
            if tekuciMin > lista[j]:
                tekuciMin = lista[j]
                tekuciMinInf = j
        #zamjene se elementi [i] i [tekuciMinInd] po potrebi
        if tekuciMinInd != i:
            lista[tekuciMinInd] = lista[i]
            lista[i] = tekuciMin
