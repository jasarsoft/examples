""" Program pronalazi najkraci put izmedju dva cvora u zadanom grafu.

    U ovom skolskom primjeru grafje definisan unaprijed unesenom
    matricom duzina lukova (adjacency matrix). Za pronalazenje
    najkraceg puta korisit se Dijkstrin algoritam.
"""

INF = float("inf")

def dijkstra(graf, od):
    #Dijsktrin algoritam koji prolazi najkrace puteve u grafu
    #od zadanog cvora do svih ostalih
    cvorovi = [i for i in range(len(graf))]

    posjeceni = [od]
    put = {od:{od:[]}}
    cvorovi.remove(od)
    rastojanja_cvorova = {od:0}
    preth = sled = od

    while cvorovi:
        rastojanja = INF
        for v in posjeceni:
            for d in cvorovi:
                novo_rastojanje = graf[od][v]+graf[v][d]
                if novo_rastojanje < rastojanja:
                    rastojanja = novo_rastojanje
                    sled = d
                    preth = v
                    graf[od][d] = novo_rastojanje
                    
        put[od][sled] = [i for i in put[od][preth]]
        put[od][sled].append(sled)

        rastojanja_cvorova[sled] = rastojanja

        posjeceni.append(sled)
        cvorovi.remove(sled)

    return rastojanja_cvorova, put

#Testni primjer grafa
graf = [[0, 3, 4, INF, INF],
        [3, 0, INF,  2, INF],
        [4, INF, 0, 7, 2.5],
        [INF, 2, 7, 0, 1],
        [INF, INF, 2.5, 1, 0]]

print("Program pronalazi najkraci put izmedju dva cvora")
print("u grafu koji je definisan matricom duzina lukova")
print("(adjecency matrix):")
print("          (0)         --              --")
print("       4 /   \ 3      | 0  3  4  -  -  |")
print("        /     \       | 3  0  -  2  -  |")
print("     (2)      (1)     | 4  -  0  7 2.5 |")
print("      | \ 7   /       | -  2  7  0  1  |")
print("      |  \   /        | -  - 2.5 1  0  |")
print("  2.5 |   \ / 2       --              --")
print("     (4)--(3)                           ")
print("         1                              ")

#najkraci put izmedju dva zadana cvora
od = int(input("Unesit pocetni cvor putanje (0..4): "))
do = int(input("Unesi krajnji cvor putanje (0..4): "))

#pronalazanje najkracih puteva do svih ostalih cvorova
rastojanja, put = dijkstra(graf, od)

print("\nNajkraci put izmedju cvorova ", od, " i " , do, \
      "duzine ", rastojanja[do], " je: \n", put[od][do])
