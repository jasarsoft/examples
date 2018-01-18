# Indeks Tjelesne Mase

"""
    Modul IndeksTM

    Klasa za racunanje indeksa i odredjivanja statusa tjelesne mase osobe

"""

class IndeksTM:
    #inicijalizator
    def __init__(self, ime, starost, tezina, visina):
        self.__ime = ime
        self.__starost = starost
        self.__tezina = tezina
        self.__visina = visina

    def getIndeksTM(self): #indeks tjelesne mase
        ind = self.__tezina / ((self.__visina/100)**2)
        return round(ind * 100)/100

    def getStatus(self):
        ind = self.getIndeksTM()
        if ind < 18.5:
            return "Nedovoljna tezina"
        elif ind < 25:
            return "Normalna tezina"
        elif ind < 30:
            return "Povecana tezina"
        else:
            return "Gojaznost"

    def getIme(self):
        return self.__ime       #skrivena promjenjljiva

    def getStarost(self):
        return self.__starost

    def getTezina(self):
        return self.__visina

    
    
