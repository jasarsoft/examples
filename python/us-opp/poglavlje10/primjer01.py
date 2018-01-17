#otvranja fajla i citanje svih podataka
f = open("brojevi.txt", "r") #lista brojava
s = f.read()

#podjela string s  na djelove i konverzija s eval()
brojevi = [eval(x) for x in s.split()]
for broj in brojevi:            #obilazak liste brojeva
    print(broj, end = " ")  #prikaz u istom redu

f.close() #zatvaranje fajla
