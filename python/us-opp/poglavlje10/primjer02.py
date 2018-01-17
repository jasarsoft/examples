import random

#otvaranje fajla radi upisa podataka
f = open("brojevi.txt", "w")

#zapis deset pseudoslucajnih brojeva na fajl
for i in range(10):
    broj = random.randint(0, 9)    #slucajnni broj 0..9
    f.write(str(broj)+" ")  #zapis string broj+ " "

f.close() #zatvaranje fajla
