class IzuzetakZaKratkiUnos(Exception):
    '''Klasa definisana od strane korisnila.'''
    def __init__(self, duzina, najmanje):
        Exception.__init__(self)
        self.duzina = duzina
        self.najmanje = najmanje

try:
    tekst = input("Ukucaj nesto --> ")
    if len(tekst) < 3:
        raise IzuzetakZaKratkiUnos(len(tekst), 3)
    #neki drugi rad moze biti definisan na ovom mjestu
except EOFError:
    print("Zasto si mi uradio EOF?")
except IzuzetakZaKratkiUnos as ex:
    print("IzuzetakZaKratkiUnos: Unos je {0} karaktera dug, ocekivano je najmanje {1}"\
          .format(ex.duzina, ex.najmanje))
else:
    print("Nijedan exception nije podignut.")
