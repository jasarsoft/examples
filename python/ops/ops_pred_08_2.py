tajniBroj = 54
broj = 0

while tajniBroj != broj:
    broj = int(input("Pogodite tajni broj: "))

    if tajniBroj == broj:
        print("Pogodatk!")
    elif tajniBroj < broj:
        print("Tajni broj je manji od tog broja.")
    else:
        print("Tajni broj je veci od tog broja.")

print("Kraj programa")
