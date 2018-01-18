#klasa GeometrijskiObjekt

class GeometrijskiObjekt:
    def __init__(self, boja = "plava", obojen=True):
        #inicijalizator
        self.__boja = boja
        self.__obojen = obojen

    def getBoja(self):
        return self.__boja

    def setBoja(self, boja):
        self.__boja = boja

    def isObojen(self):
        return self.__obojen

    def setObojen(self, obojen):
        self.__obojen = obojen

    def __str__(self):
        return "boja: " + self.__boja + ", obojen: " + str(self.__obojen)
