class Robot:
    '''Predstavlja robota sa imenom.'''

    #varijabla klase, broji kolicinu robota
    populacija = 0

    def __init__(self, ime):
        '''Inicijalizacija podataka'''
        self.ime = ime
        print("(Incijaliizujem {0})".format(self.ime))

        #kada je kreirana licnost robota
        #poveca se populacija
        Robot.populacija += 1

    def __del__(self):
        '''Umirem'''
        print("{0} je unisten!".format(self.ime))

        Robot.populacija -= 1

        if Robot.populacija == 0:
            print("{0} je bio posljednji.".format(self.ime))
        else:
            print("Funkcionalno je jos {0:d} robota".format(Robot.populacija))

    def kaziZdravo(self):
        '''Robot vas pozdravlja
            Da oni mogu i to!'''

        print("Pozdravljam vas, gospodine mozete me zvati {0}".format(self.ime))

    def koliko():
        '''Prikazuje trenutnu populaciju'''
        print("Imamo {0:d} robota".format(Robot.populacija))

    koliko = staticmethod(koliko)

droid1 = Robot("R2-D2")
droid1.kaziZdravo()
Robot.koliko()

droid2 = Robot("C-3P0")
droid2.kaziZdravo()
Robot.koliko()

print("\nRoboti mogu da rade nesto ovdje.\n")

print("Roboti su zavrsili svoj rad. Hadje da ih unistimo.")
del droid1
del droid2

Robot.koliko()
