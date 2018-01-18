# sortiranje umetanjem (Insertion Sort)

#funkcija sortiranja elemenata u rastucem poretku
def insertionSort(lista):
    for i in range(1, len(lista)):
        #umetne se element [i] u sortiranju podlistu
        #[0:i] tako da lista [0:i+1] bude sortiran
        tekuciElement = lista[i]
        k = i - 1
        while k >= 0 and lista[k] > tekuciElement:
            lista[k+1] = lista[k]
            k = k - 1
        #umetne se tekuci element u listu [k+1]
            lista[k+1] = tekucElement
