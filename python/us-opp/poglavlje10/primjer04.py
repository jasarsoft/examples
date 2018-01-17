""" Program koji razlicita slova broji u tkestualnom
    fajlu i prikazuje rezultat.

    Broja se samo slova is ASCII podskupa bez obzira
    da li su velika ili mala.
"""

#brojanje razlicitih slova u sturngu (ASCII podskup)
def brojacSlova(linija, brojac):
    for ch in linija:
        if ch.isalpha():
            brojac[ord(ch) - ord("a")] = \
                brojac[ord(ch) - ord("a")] + 1

filename = input("Unesite naziv fajla: ").strip()
infile = open(filename, "r") #otvara fajl za citanje

brojac = 26 * [0] #inicijalizacija brojaca slova

for linija in infile:
    #poziv funkcije brojacSlova za svaku liniju
    brojacSlova(linija.lower(), brojac)

#prikaz rezultata
for i in range(len(brojac)):
    if brojac[i] != 0:
        print(chr(ord("a") + i) + " se pojavljuje "
              + str(brojac[i])
              + (" put " if brojac[i] == 1 else " puta"))

infile.close() #zatvaranje fajla
