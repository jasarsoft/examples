# 'ab' je skracenica za 'a'-address 'b'-book
ab = {'Pandimenzionalni'    :'pd@ma.cme',
      'mega'                :'mno@hoo.moo',
      'giga'                :'kokos@kokoda.lom',
      'troler'              :'gong@pong.pet'}

print("Trolova adresa je", ab['troler'])

#brisanje para kljuc-vrijednost
del ab['troler']

print("\nImamo {0} kontakata u adresaru\n".format(len(ab)))

for ime, adresa in ab.items():
    print("Kontaktiraj {0} na {1}".format(ime, adresa))

#dodavanje para kljuc-vrijednost
ab['Genije'] = 'papara@lebac.voda'

if 'Genije' in ab:
    print("\nAdresa genija je", ab['Genije'])
