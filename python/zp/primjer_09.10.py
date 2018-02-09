#DocStrings

def prikazMaksimuma(x, y):
    '''Prikazuje vecu vrijednost dva broja.

        Ta dva broja moraju biti integer(cijeli brojevi)'''

    x = int(x) #konvertuje u integer, ukoliko je moguce
    y = int(y)

    if x > y:
        print(x, " je maksimu")
    else:
        print(y, " je maksimu")

prikazMaksimuma(3, 5)
print(prikazMaksimuma.__doc__)
