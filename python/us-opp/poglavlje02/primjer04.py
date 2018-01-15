#program racuna indeks tjelesne mase i daje opisnu ocjenu

#unos tjelsne tezine u kg
tezina = float(input("Unesite tjelesnu tezinu (kg): "))

#unos visine u cm
visina = float(input("Unesite visinu (cm): "))

#racunanje indeksa tjelsene mase
indeks_tm = tezina / ((visina/100) ** 2)

#prikaz rezultata
print("Indeks tjelsne mase je ", indeks_tm)

if indeks_tm < 18.5:
    print("Nedovoljna tezina")
elif indeks_tm < 25:
    print("Normalna tezina")
elif indeks_tm < 30:
    print("Povecana tezina")
else:
    print("Gojaznost")
