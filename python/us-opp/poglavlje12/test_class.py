from KrugIzvedeniGeometrijskiObjekt import Krug
from PravougaonikIzvedeniGeometrijskiObjekt import Pravougaonik

krug = Krug(12.5)
print("Krug ", krug)
print("Poluprecnik = ", krug.getPoluprecnik())
print("Povrisna = ", krug.getPovrsina())
print("Obim = ", krug.getObim())

pravugaonik = Pravugaonik(10, 20)
print("\nPravugaonik ", pravugaonik)
print("Povrisna = ", pravugaonik.getPovrsina())
print("Obim = ", pravugaonik.getObim())
