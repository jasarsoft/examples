tajniBroj = 54

for i in range(10):
    broj = int(input("Pogodite tajni broj: "))

    if broj == tajniBroj:
        print("Pogodatk")
        break
    else:
        print("Niste pogodili")

        if broj < tajniBroj:
            print("Tajni broj je veci od tog broja koji ste upisali")
        else:
            print("Tajni broj je manji od tog broja koji ste upisali")

print("Kraj igre")
