def Kvadar(visina, sirina, duzina):
    return {
        'sirina': sirina,
        'visina': visina,
        'duzina': duzina
    }

def provjeraKvadra(kvadar):
    if type(kvadar) == dict:
        potrebnaPolja = ['visina', 'sirina', 'duzina']
        for polje in potrebnaPolja:
            if polje not in kvadar.keys():
                print("Kvadar mora da ima kljuc " + polje)
                return 0
        return 1
    else:
        return 0

def zapremina(kvadar):
    if provjeraKvadra(kvadar) == 0:
        return 0

    return kvadar['visina'] * kvadar['sirina'] * kvadar['duzina']

def povrsina(kvadar):
    if provjeraKvadra(kvadar) == 0:
        return 0

    return 2 * (kvadar['sirina'] * kvadar['visina'] +
                kvadar['sirina'] * kvadar['duzina'] +
                kvadar['duzina'] * kvadar['visina'])

