class ClanoviSkole:
    '''Predstavlja bilo kojeg clana skole'''
    def __init__(self, ime, godine):
        self.ime = ime
        self.godine = godine
        print("(Inicijalizujem ClanoveSkole: {0})".format(self.ime))

    def kazi(self):
        '''Kaze moje detalje'''
        print("Ime: {0}, Godine: {1}".format(self.ime, self.godine), end=" ")

class Ucitelj(ClanoviSkole):
    '''Predstavlja ucitelja'''
    def __init__(self, ime, godine, zarada):
        ClanoviSkole.__init__(self, ime, godine)
        self.zarada = zarada
        print("(Inicijalizujem Ucitelj: {0})".format(self.ime))

    def kazi(self):
        ClanoviSkole.kazi(self)
        print("Zarada: {0:d}".format(self.zarada))

class Student(ClanoviSkole):
    '''Predstavlja ucenike'''
    def __init__(self, ime, godine, oznaka):
        ClanoviSkole.__init__(self, ime, godine)
        self.oznaka = oznaka
        print("(Inicijalizujem Student: {0}".format(self.ime))

    def kazi(self):
        ClanoviSkole.kazi(self)
        print("Oznaka: {0:d}".format(self.oznaka))

u = Ucitelj("Gdja. Blabetala", 40, 30000)
s = Student("Swaroop", 25, 75)

print() #prikazuje praznu liniju

clanovi = [u, s]
for clan in clanovi:
    clan.kazi() #radi kako za Ucitelje tako i za Studente
    
