import math

from GeometrijskiObjekti import GeometrijskiObjekt

class Krug(GeometrijskiObjekt): #izvedena klasa
    def __init__(self, poluprecnik):
        #inicijalizato nove klase
        super().__init__() #inicijalizacija osnovne klase
        self.__poluprecnik = poluprecnik

    def getPoluprecnik(self):
        return self.__poluprecnik

    def setPoluprecnik(self, poluprecnik):
        self.__radius = poluprecnik

    def getPovrsina(self):
        return self.__poluprecnik ** 2 * math.pi

    def getPrecnik(self):
        return 2 * self.__poluprecnik

    def getObim(self):
        return 2 * self.__poluprecnik * math.pi

    def printKrug(self):
        print(self.__str__() + " Poluprecnik: " + str(self.__poluprecnik))
