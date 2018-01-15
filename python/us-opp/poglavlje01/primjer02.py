# Racunanje vremena putovanja za zadatu brzinu u udaljenost
# Petar Petrovic, 02.10.2017.

brzina = input("Unesite brzin (km/h): ")
brzina = int(brzina)

udaljenost = input("Unesite udaljenost (km): ")
udaljenost = float(udaljenost)

vrijeme = udaljenost/brzina

print("Uz brzinu ", brzina, "km/h, potrebno je ")
print(vrijeme, " sati putovanja da se predje ", udaljenost, "km.")
input("\nPritisni taster Enter za kraj")
