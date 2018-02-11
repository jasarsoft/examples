pjesma = '''\
Programiranje je zabava
Kada je posao gotov
ako zelis da ti posao bude razbirbriga
korisit Python!
'''

f = open("pjesma.txt", "w") #otvara fajl sa w-pisanje
f.write(pjesma) #upisuje tekst u fajl
f.close() #zatvara fajl

f = open("pjesma.txt") #ako nismo naveli podazumjevno je r-citanje fajla
while True:
    linija = f.readline()
    if len(linija) == 0: #duzina od 0 znaci da smo dostigli EOF- kraj fajla
        break
    print(linija, end = " ")

f.close() #zavra fajl
