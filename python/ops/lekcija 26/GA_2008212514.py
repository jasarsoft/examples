import json
import industrijski_robot

print("Milan Tair, 2008213514, 13.01.2017.")


lista = industrijski_robot.load("ulaz.dat")

suma = 0
for ir in lista:
    suma += industrijski_robot.efikasnost(ir)

srvr = suma / len(lista)

lista2 = []

for ir in lista:
    if industrijski_robot.efikasnost(ir) >= 0.5 * srvr and industrijski_robot.efikasnost(ir) <= 1.5 * srvr:
           lista2.append(ir)

imeDatoteke = "lista_{0:d}_{1:d}.json".format(len(lista), len(lista2))

dat = open(imeDatoteke, "w")

json.dump(lista2, dat)
dat.close()

