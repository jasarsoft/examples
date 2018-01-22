import random
import ops_pred_21_stavka

def Racun(radnja, adresa, mjesto, datum, vrijeme, kasir):
    return {
        'radnja'    : radnja,
        'adresa'    : adresa,
        'mjesto'    : mjesto,
        'datum'     : datum,
        'vrijeme'   : vrijeme,
        'kasir'     : kasir,
        'transakcija' : int(random.random() * 1000000),
        'stavka'    : []
        }

def dodajStavku(racun, stavka):
    racun['stavka'].append(stavka)

def separator(sirinaPapira):
    print("= " * (sirinaPapira//2))

def prikaziRacun(racun, sirinaPapira):
    print(("{0:^" + str(sirinaPapira) + "s}").format(racun['radnja']))
    print(("{0:^" + str(sirinaPapira) + "s}").format(racun['adresa'] + ", " + racun['mjesto']))
    separator(sirinaPapira)
    print("Datum:   " + racun['datum'])
    print("Vrijeme: " + racun['vrijeme'])
    separator(sirinaPapira)
    suma = 0
    for s in racun['stavka']:
        ops_pred_21_stavka.stampajStavku(s, sirinaPapira)
        suma += s['cijena']
    separator(sirinaPapira)
    porez = suma * 0.2
    cijena = suma - porez
    mjestaZaOznaku = sirinaPapira - 13    
    print(("{0:" + str(mjestaZaOznaku) + "s} {1:12.2f}").format("Ukupna cijena: ", cijena))
    print(("{0:" + str(mjestaZaOznaku) + "s} {1:12.2f}").format("Porez: ", porez))
    print(("{0:" + str(mjestaZaOznaku) + "s} {1:12.2f}").format("Iznos za uplatu: ", suma))
    separator(sirinaPapira)
    print("Kasir: " + racun['kasir'])
    print("Broj transakcije: " + str(racun['transakcija']))
    separator(sirinaPapira)
