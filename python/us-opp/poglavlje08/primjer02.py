#Geografija

#povrsina najvecih zemalja svijeta (km2)
drzave = {
    "Rusija"    : 16377742,
    "Kanada"    : 9093507,
    "Kina"      : 9569901,
    "USA"       : 9158960,
    "Brazil"    : 8460415,
    "Australija": 7682300,
    "Indija"    : 2973193,
    "Argentina" : 2736690,
    "Kazahstan" : 2699700,
    "Alzir"     : 238741,
    "Kongo"     : 2267048,
    "Saud.Arab" : 2149690,
    "Meksiko"   : 1943945,
    "Indonezija": 1811569,
    "Libija"    : 1759540,
    "Iran"      : 1531595,
    "Mongolija" : 1553556,
    "Peru"      : 1279996,
    "Cad"       : 1259200,
    "Niger"     : 1266700,
    "Angola"    : 1246700,
    "Mali"      : 1220190,
    "JuzAfr.Rep": 1214470,
    "Kolumbija" : 1038700,
    "Srbija"    : 881361 }

kraj = False
while not kraj:
    nazivDrzave = input("Unesite naziv drzave: ")
    if nazivDrzave == "":
        kraj = True
    else:
        if nazivDrzave in drzave:
            povrsina = drzave[nazivDrzave]
            print("Povrsina ", nazivDrzave, " je ", povrsina, " (km2)")
        else:
            print("Nazalost nemamo informaciju o ", nazivDrzave)
        print()
