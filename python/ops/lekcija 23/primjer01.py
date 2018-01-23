datoteka = open("podaci.txt", "w")
datoteka.write("Moja prva datoteka.\n")
datoteka.flush()
datoteka.close()

#dodavanje novog tekst
datoteka = open("podaci.txt", "a")
datoteka.write("Jos noviji sadrzaj...\n")
datoteka.close()

#citanje sadrzaja
datoteka = open("podaci.txt", "r")
text = datoteka.read()
print(text)
datoteka.close()

#citanje samo 4 karaktera
datoteka = open("podaci.txt", "r")
text = datoteka.read(4)
print(text)
datoteka.close()

#nastavak citanja
datoteka = open("podaci.txt", "r")
text = datoteka.read(4)
text = datoteka.read(4)
print(text)
datoteka.close()

#citanje veceg broja karaktera od sadrzaja datoteke
datoteka = open("podaci.txt", "r")
text = datoteka.read(500)
print(text)
datoteka.close()

#citanje red po red
datoteka = open("podaci.txt", "r")
text = datoteka.readline()
print(text)
datoteka.close()

#drugi nacin citanja red po red
datoteka = open("podaci.txt", "r")
for red in datoteka:
    print("Red teksta je: " + red)

datoteka.close()

#spremanje formatirani podata
datoteka = open("podaci.txt", "w")
ime = "Milan"
prezime = "Tair"
indeks = 2008213514

datoteka.write("{0:40s}{1:40s}{2:10d}".format(ime, prezime, indeks))
datoteka.close()

#citanje formatirani podataka
datoteka = open("podaci.txt", "r")
ime     = datoteka.read(40).strip() #ukloni bjeline
prezime = datoteka.read(40).strip()
indeks  = int(datoteka.read(10))

print("Ime:     " + ime)
print("Prezime: " + prezime)
print("Indeks:  " + str(indeks))

datoteka.close()
