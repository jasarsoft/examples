import json
import pravougaonik

dat = open("pravougaonici.txt", "r")

lista = []

while True:
    try:
        a = float(dat.read(6))
        dat.read(1) #razmak izmedju vrijednost a i b
        b = float(dat.read(6))
        dat.read(1) #prelazak u nov red (unix format, windows = 2) 

        lista.append(pravougaonik.Pravougaonik(a, b))
    except ValueError:
        break

dat.close()
print(lista)

najveciPravougaonik = lista[0]
for p in lista:
    if pravougaonik.povrsina(najveciPravougaonik) < pravougaonik.povrsina(p):
        najveciPravougaonik = p

print(najveciPravougaonik)

#obim najveci
najveciPravougaonik = lista[0]
for p in lista:
    if pravougaonik.obim(najveciPravougaonik) < pravougaonik.obim(p):
        najveciPravougaonik = p

print(najveciPravougaonik)


dat2 = open("najveci-pravougaonik.json", "w")
json.dump(najveciPravougaonik, dat2)
dat2.close()
