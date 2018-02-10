print("Jednostavno dodavanje vrijednosti")
listakupovine = ['jabuka', 'mango', 'sargarepa', 'banana']
mojalista = listakupovine #mojalista je samo drugo ime koje se odnosi na isti objekat(listakupovine)

del listakupovine[0] #kupili smo prvu stvar pa je brisemo iz liste
print('listakupovine je', listakupovine)
print("mojalista je", mojalista)
#obratite paznju na obje (i listakupovine i mojalista) prikazuju isiti rezultat
#bez objekta 'jabuka' cime potvrdjujemo da one referisu na isti objekat

print("Kopiranje pomocu punog isjecenja")
mojalista = listakupovine[:] #pravimo kopiju tako sto isecamo sve objekte iz jedne liste

del mojalista[0] #uklanjamo prvi objekat
print("listakupovine je", listakupovine)
print("mojalista je", mojalista)
#sada primjetite da su liste razlicite
