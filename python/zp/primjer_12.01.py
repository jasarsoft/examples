import os
import time

#1. Fajlovi i folder koje zelim da back-up-ujemo e specifirani u list
izvor = ['C:\\py', '"C:\\Documents and Settings\\Pure\\Desktop\\v0.0\\"']
#Primjetite da smo koristili duple navodnike unutar stringa, zbog imena koji sadrzi razmake

#2. Bakup ce biti sacuvan u glavnom backup direktoriju
ciljani_dir = 'D:\\Resto' #Zapamtite da promjenito ovo, unesite lokaciju koja vam odgovoara na vasem racunalu

#3. Fajlov se backup-uju u zip fajl
#4. Ime zip arhive je trenutni datum i vrijeme
cilj = ciljani_dir + os.sep + time.strftime("%Y%m%d%H%M%S") + '.zip'

#5 Koristimo zip komandu da posaljemo fajlove uzip arhivu
zip_komanda = "zip -qr {0} {1}".format(cilj, ' '.join(izvor))

#pokrece bakup
if os.system(zip_komanda) == 0:
    print("Uspjesno smo izvrsili bakup u ", cilj)
else:
    print("Backup nije uspio!")

