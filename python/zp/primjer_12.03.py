import os
import time

#fajlovi i folderi koje zelimo da backupujemo su specificirani u listi
izvor = ['C:\\py', '"C:\\Documents and Settings\xinjure\\Desktop\\"']
#primjetite da smo koristili duple navodnike unutar stringa, zbog imena koje sadrzi razmake

#backup ce biti sacuvan u glavnom backup direktoriju
ciljni_dir = "D:\\Resto" #zapamtite da promjeite ovo, unesite lokaciju koja vama odgovara na vasem racunaru

#3. Fajlovi se backupju u zip fajl
#trenutni datum je ime poddirektorija u glavnom direkotriju
danas = ciljani_dir + os.sep + time.strftime("%Y%m%d")
#trenutno vrijeme je ime zip arhive
sada = time.strftime("%H%M%S")

#trazi od korisnika da unese komentar koji se primjeni u izmenu zip arhive
komentar = input("Prilozie komantera backupa --> ")
if len(komantar) == 0: #provjerava da li je komantar unesen
    cilj = danas + os.sep + sada + ".zip"
else:
    cilj = danas + os.sep + sada + "_" + komentar.replace(" ", "_") + ".zip"

#kreiranje poddirektorijuma ukoliko on ne postoji
if not os.path.exists(danas):
    os.mkdir(danas) #kreira direktorijium
    print("Upjesno smo kreirali direktorijum", danas)

#koristimo zip komandu da posaljemo fajlove u zip arhivu
zip_komanda = "zip -qr {0} {1}".format(cilj, " ".join(izvor))

#pokrece backup
if os.system(zip_komanda) == 0:
    print("Uspjeno smo izvrsili backupove u ", cilj)
else:
    print("Backup nije uspjeo!")

