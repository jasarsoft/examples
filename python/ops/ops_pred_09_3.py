def c2f(tempC):
    return 1.8 * tempC + 32

def f2c(tempF):
    return (tempF - 32) / 1.8

def uzmiIzbor():
    print("Izaberite 1 da konvertujete *C u *F")
    print("Izaberite 2 da konvertujete *F u *C")
    print("Izaberite 0 da ugasite program")

    return int(input("Izaberite sta zelite: "))

def c2fKonverzija():
    tempC = float(input("Unesite temperaturu u *C: "))
    tempF = c2f(tempC)
    print("Ta temperatura u *F je " + str(tempF))

def f2cKonverzija():
    tempF = float(input("Unesite temperaturu u *F: "))
    tempC = f2c(tempF)
    print("Ta temperatura u *C je " + str(tempC))

while True:
    izbor = uzmiIzbor()
    
    if izbor == 1:
        c2fKonverzija()
    elif izbor == 2:
        f2cKonverzija()
    elif izbor == 0:
        print("Kraj programa")
        break


