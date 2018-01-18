import math

class Krug:
    def __init__(self, poluprecnik = 1):
        self.poluprecnik = poluprecnik
    def getObim(self):
        return 2 * self.poluprecnik * math.pi
    def getPovrsina(self):
        return self.poluprecnik **2 * math.pi
    def setPoluprecnik(self, poluprecnik):
        self.poluprecnik = poluprecnik

prom_krug = Krug(20)
print(prom_krug.poluprecnik)
print(prom_krug.getObim())
prom_krug.setPoluprecnik(3)
print(prom_krug.poluprecnik)

