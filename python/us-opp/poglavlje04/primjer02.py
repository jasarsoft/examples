#program za pogadjanje slucajnog broja

import random

MAX_POKUSAJA = 5    # najveci broj pogadjanja
MAX_BROJ     = 20   # najveci slucajni broj

# uvodno obavjestenje
print("Program za pogadjanje slucajnog broja " \
      "izmedju 1 i ", MAX_BROJ, ".")
print("Dozvoljeno je ", MAX_POKUSAJA, " pokusaja.")

# generisanje slucajnog broja
broj = random.randrange(1, MAX_BROJ + 1)

brojPokusaja = 0  # inicijalizacija brojaca
while True:         # beskonacna petlja
    # unos pogadjanja
    pokusaj = int(input('\nPogodite slucajni broj: '))
    brojPokusaja = brojPokusaja + 1 #brojac pokusaja

    # ako je broj pogodjen, cestitka i prekid petlje
    if pokusaj == broj:
        print("Cestitamo, pogodili ste broj!")
        print("Broj pokusaja: ", brojPokusaja)
        break
    elif pokusaj < broj:
        print("Suvise mali broj.") #broj premali
    else:
        print("Suvise velik broj.") #broj prevelik

    # ako je dostignut najveci broj pokusaja, prekid
    if brojPokusaja == MAX_POKUSAJA:
        print("Nazalost, niste pogodili u ", \
              MAX_POKUSAJA, " pokusaja.")
        print("Slucajni broj je bio: ", broj)
        break

print("Hvala na igri.")
