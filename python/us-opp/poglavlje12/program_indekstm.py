"""
    Program racuna indeks tjelesne mase osobe
    i stampa status (normalna, povecana, ...)

"""

from indeks_tm import IndeksTM

#unos imena, starosti, tjelesne tezine ivisine osobe
ime = input("Unesite ime i prezime osobe: ")
starost = int(input("Unesite starost osobe(godina): "))
tezina = float(input("Unestie tjelesnu tezinu (kg): "))
visina = float(input("Unesite visinu (cm): "))

#kreiranje objekta klase IndeksTM
indeks = IndeksTM(ime, starost, tezina, visina)

#racunanje indeksa tjelesne mase i ispisa razultata
print("Indeks tjelesne mase za ", indeks.getIme(), \
      " je ", indeks.getIndeksTM(), indeks.getStatus())
