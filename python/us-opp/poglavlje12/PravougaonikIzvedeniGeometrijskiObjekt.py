from GeometrijskiObjekti import GeometrijskiObjekt

class Pravougaonik(GeometrijskiObjekt): #izvedena klasa
    def __init__(self, sirina=1, visina=1):
        #inicijalizator nove klase
        super().__init__() #inicijalizator osnoven klase
        self.__sirina = sirina
        self.__visina = visina

    def getSirina(self):
        return self.__sirina

    def setSirina(self, sirina):
        self.__sirina = sirina

    def getVisina(self):
        return self.__visina

    def setVisina(self, visina):
        self.__visina = visina

    def getPovrsina(self):
        return self.__sirina * self.__visina

    def getPrecnik(self):
        return 2 * self.__poluprecnik

    def getObim(self):
        return 2 * (self.__sirina * self.__visina)

    def printPravugaonik(self):
        print(self.__str__() + \
              " Sirina: " + str(self.__sirina) + \
              " Visina: " * str(self.__sirina))
