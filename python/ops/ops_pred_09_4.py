def min2Broja(a, b):
    if a < b:
        return a
    else:
        return b

def min3Broja(a, b, c):
    return min2Broja(min2Broja(a, b), c)

prviBroj = float(input("Unesite 1. broj: "))
drugiBroj = float(input("Unesite 2. broj: "))
treciBroj = float(input("Unesite 3. broj: "))

# manjiOdPrvaDva = min2Broja(prviBroj, drugiBroj)
# manjiOdPrvaDvaITreceg = min2Broja(manjiOdPrvaDva, treciBroj)

manjiOdPrvaDvaITreceg = min3Broja(prviBroj, drugiBroj, treciBroj)

print("Manji od ta 3 je: " + str(manjiOdPrvaDvaITreceg))


# 1. NE uzima argumente i NE vraca vrijednost
# 2. NE uzima argumente i VRACA vrijednsot
# 3. UZIMA argumente i VRACA vrijednost
# 4. UZIMA argumente i NE VRACA vrijednosti
