import os
import time

#1. Fajlovi i folder koje zelimo da backupujemo se specificirani u listi
izvor = ['C:\\py', '"C:\\Documents and Settings\\xinjure\\Desktop\\v0.0\\"']
#Primjetite da smo koristi duple navodnike unutar stringa, zbog imena koje sadrze razmake

#2. Bakcup ce biti sacuvan u glavni backup direktoriji
ciljni_dir = "D:\\Resto" #zapamtite da promjenite ovo, unesite lokaciju koja vam odgovoara na vasem racunaru

#3. Fajlovi se backu-uj u zip fajl
#4. Trenutni datum je ime poddirektorija u glavnom direktoriju
danas = ciljni_dir + os.sep + time.strftime("%Y%m%d")
#Trenutno vrijeme je ime zip arhive
sada = time.strftime("%H%M%S")

#kreirranje poddirektorijuma ukoliko on ne postoji
if not os.path.exists(danas):
    os.mkdir(danas) #kreira direktoriji
    print("Uspjesno smo kreirali direktoriji", danas)

#ime zip arhive
cilj = danas + os.sep + sada + ".zip"

#5. koristimo zip komandu da posaljemo fajlove u zip arhivu
zip_komanda = "zip -qr {0} {1}".format(cilj, " ".join(izvor))

#pokrece backup
if os.system(zip_komanda) == 0:
    print("Uspjeno smo izvrsili backup u ", cilj)
else:
    print("Backu nije uspjeo!")

