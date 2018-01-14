# Python 3.5 - Uvod u programiranje
# Predavanje 05 - Singidunum

import math

aX = float(input("Unesite X koordinatu tacke Ax: "))
aY = float(input("Unesite X koordinatu tacke Ay: "))
bX = float(input("Unesite X koordinatu tacke Bx: "))
bY = float(input("Unesite X koordinatu tacke By: "))
cX = float(input("Unesite X koordinatu tacke Cx: "))
cY = float(input("Unesite X koordinatu tacke Cy: "))

if aX < bX and aY > bY:
    print("Tacka A je lijevo gore u odnosu na tacku B, pa program moze da nastavi")

    if aX < cX < bX and aY > cY > bY:
        print("Tacka C jeste unutar pravouganika uokvirenog tackama A i B")

        lenAC = math.hypot(aX - cX, aY - cY)
        lenBC = math.hypot(bX - cX, bY - cY)

        if lenAC < lenBC:
            print("Tacka C je bliza tacki A")
        elif lenAC == lenBC:
            print("Tacka C je podjednako udaljena od tacke A i B")
        else:
            print("Tacka C je bliza tacki B")
        
    else:
        print("Tacka C nije unutar pravuganokika uokvirenog tackama A i B i program ne moze da nastavi")
        
else:
    print("Program ne moze da nastavi, jer tacka A nije lijevo u odnosu na B.")
    
