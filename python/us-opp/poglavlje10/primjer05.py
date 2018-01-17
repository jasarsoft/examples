#program za konverziju valuta

""" Racunanje faktora konverzije iz jedne u drugu valutu

    Koeficijent konverzije sa sajta: http://fixer.io
"""

import urllib.request
import json
import sys

listaValuta = ["AUD", "BGN", "BRL", "CAD", "CHF", "CYN",\
               "CZK", "DKK", "EUR", "GBP", "HKD", "HRK",\
               "HUF", "IDR", "ILS", "INR", "JPY", "KRW",\
               "MXN", "MYR", "NOR", "NZD", "PHP", "PLN",\
               "RON", "RUB", "SEK", "SGD", "THB", "TRY",\
               "USD", "ZAR"]

#funkcija prezuma ik orisit podatake kao string
def getInfo(izValute, uValutu):
    URL = "https://api.fixer.io/latest?base=" + izValute

    #odgovor servera konvertuje se u rjecnik
    odgovor = urllib.request.urlopen(URL).read()
    recnik = json.loads(odgovor)

    #izdvajanje djela stringa koji sadrzi vrijednost
    recnik = recnik["rates"]
    faktor = recnik[uValutu]

    return float(faktor)

def ucitajValutu(pitanje):
    while True:
        valuta = input(pitanje)
        valuta = valuta.upper() #oznaa u velika slova
        if valuta == "":
            sys.exti()
        if valuta in listaValuta:
            break
        else:
            print("Nazalost ", valuta, " nije u listi.")

    return valuta

print("Program racuna koeficijent konverzije")
print("izmedju dvije od navedenih valuta:")
skracenice = " ".join(listaValuta) #string svih skracenica
print(skracenice)

print()
izValute = ucitajValutu("Iz koje valute iz liste? ")
uValutu = ucitajValutu("U koju valutu iz liste? ")
faktorKonverzije = getInfo(izValute, uValutu)
print()
print("Koeficijent za konverziju ", izValute, " u ", uValutu, " je: ", \
      faktorKonverzije)
