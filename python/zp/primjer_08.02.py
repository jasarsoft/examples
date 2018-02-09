broj = 23
radim = True

while radim:
    pogodi = int(input('Pogodi broj: '))

    if pogodi == broj:
        print('Cestitam, pogodio si.')
        radim = False #ovo ce prekinuti while petlju i preci na neki red poslije nje
    elif pogodi < broj:
        print('Ne broj je malo veci od tvog.')
    else:
        print('Ne broj ej malo manji od tvog.')
else:
    print('While petlja je gotova.')
    #ovdje mozete da radite sta vam volja

print("Kraj")
