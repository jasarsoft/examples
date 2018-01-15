#program racuna indeks tjelesne mase osobe

#unos tjelesne tezine u kg
tezina = float(input("Unesite tjelesnu tezinu (kg): "))

#unos visine u cm
visina = float(input("Unesite visinu (cm): "))

#racunanje indeksa tjelesne mase
indeks_tm = tezina / ((visina/100) ** 2)

#prikaz rezultata
print("Indeks tjelesne mase je ", indeks_tm)
