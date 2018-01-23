import math

def EkranTelefona(sirina, visina):
    return {
        'sirina'    : sirina,
        'visina'    : visina
        }

def dijagonala(e):
    if type(e) != dict:
        return -1

    for kljuc in e.keys():
        if kljuc not in ['sirina', 'visina']:
            return -1

    return math.hypot(e['sirina'], e['visina'])
