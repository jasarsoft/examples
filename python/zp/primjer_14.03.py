import pickle

#ime fajla u kom zelimo da cuvamo objekat
fajllistekupovine = "listakupovine.data"
#lista stvar za kupovinu
listakupovine = ['jabuka', 'manog', 'sargarepa']

#sacuvaj u fajl
f = open(fajllistekupovine, "wb")
pickle.dump(listakupovine, f) #stavlja objekat u fajl
f.close()

del listakupovine #unistava listakupovine promjenljivu

#ucitava nazad iz fajla
f = open(fajllistekupovine, "rb")
sacuvanalista = pickle.load(f) #ucitava objekat iz fajla
print(sacuvanalista)
