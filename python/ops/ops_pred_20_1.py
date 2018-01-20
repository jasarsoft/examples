v1 = 134.85623

lista = [
    134.85623,
    123.42122,
    100.30002,
     99.12,
   1003.23123,
      6.56
]

print("Vrijednost v1 je " + str(v1))

for s in lista:
    print("Vrijesdnost je " + str(s))

for s in lista:
    print("Vrijednost je {0:12.2f}".format(s))


lista = [
    100,
    30,
    1,
    40
]
print()
for s in lista:
    print("Vrijednost je {0:12d}".format(s))

print()
korisnici = [
    {
        'ime'       : 'Milan',
        'prezime'   : 'Tair'
        },
    {
        'ime'       : 'Tijana',
        'prezime'   : 'Milosevic'
        },
    {
        'ime'       : 'Boris',
        'prezime'   : 'Zoric'
        },
    {
        'ime'       : 'Miroslav',
        'prezime'   : 'Dacic'
        }
]
print("\nLista")
redniBroj = 1
for korisnik in korisnici:
    print("{0:5d}. {1:20s} {2:20s}".format(redniBroj, korisnik['ime'], korisnik['prezime']))
    redniBroj += 1

#poravnanje po sredini
print("\n - Poravnanje po sredini")
redniBroj = 1
for korisnik in korisnici:
    print("{0:5d}. {1:^20s} {2:^20s}".format(redniBroj, korisnik['ime'], korisnik['prezime']))
    redniBroj += 1

#poravnanje na desno (>)
print("\n - Provananje na desno ")
redniBroj = 1
for korisnik in korisnici:
    print("{0:5d}. {1:>20s} {2:>20s}".format(redniBroj, korisnik['ime'], korisnik['prezime']))
    redniBroj += 1

#poravnanje brojava desno (defaultno lijevo)
print(" - Poravnanje brojava desno")
redniBroj = 1
for korisnik in korisnici:
    print("{0:<5d}. {1:20s} {2:20s}".format(redniBroj, korisnik['ime'], korisnik['prezime']))
    redniBroj += 1

