from KrugIzvedeniGeometrijskiObjekt import Krug
from PravougaonikIzvedeniGeometrijskiObjekt import Pravougaonik

#prikaza svojstava geometrijskog objekta
def prikaziObjekt(g):
    print(g.__str__())

#poredjenje povrsine dva geometrijska objekta
def isIstaPovrsina(g1, g2):
    return g1.getPovrsina() == g2.getPovrsina()

#prikaz svojstva kruga i pravouganika
k = Krug(4)
p = Pravougaonik(2, 5)
prikaziObjekt(k)
prikaziObjekt(p)
print("Da li su krug i pravougaonik iste povrsine? ", isIstaPovrsina(k, p))
