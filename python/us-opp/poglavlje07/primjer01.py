import datetime

#inicijalizacija strukture podataka
astroloske_zivotinje = \
    ('pacov', 'vo', 'tigar', 'zec', 'zmaj', 'zmija',
     'konj', 'koza', 'majmun', 'petao', 'pas', 'svinja')

pacov   = 'iskren, vrijedan, osjetljiv, intelektualac, drazeljubiv'
vo      = 'pouzdan, metodican, skroman, rodjeni vodja, strpljiv'
tigar   = 'nepredvidljiv, buntovan, strastven, smeo, implusivan'
zec     = 'dobar drug, dobar, tih, oprezan, umetnicki'
zmaj    = 'jak, samouvjeren, ponosan, odlucan, odan'
zmija   = 'dubokouman, kreativan, odgovoran, miran, usmjeren'
konj    = 'veseo, dovitljiv, perceptivan, pricljiv, otvoren'
koza    = 'iskren, simpatican, stidljiv, velikodusan, pazljiv'
majmun  = 'motivator, radoznao, fleksibilan, inovativan, rjesava probleme'
pjetao  = 'organizovan, samouvjeren, odlucan, perfekcionista, revnostan'
pas     = 'posten, nepretenciozan, idealista, moralista, lezeran'
svinja  = 'miroljubiv, vredan, poveljiv, pun razumjevanja, zamisljen'

osobine = (pacov, vo, tigar, zec, zmaj, zmija, konj, koza, majmun, pjetao, pas, svinja)

#odredjivanje znaka i ispis rezultata

#pozdravna poruka
print("Program na osnovu godine rodjenja pronalazi znak osobe",
      "iz kineskog horoskopa i prikazuje njene licneosobine\n")

#pronalazenje tekuce godine
tekuca_godina = datetime.date.today().year

kraj = False
while not kraj:
    #unos datuma rodjenja
    godina_rodjenja = 0
    while godina_rodjenja < 1900 or \
          godina_rodjenja > tekuca_godina:
        godina_rodjenja = int(input("Unesite datum rodjenja osobe (gggg): "))

    #prikaz rezultata
    broj_ciklusa = (godina_rodjenja - 1900) % 12
    print("Vas znak u kineskom horoskopu je", \
          astroloske_zivotinje[broj_ciklusa], "\n")
    print("Vase licne osobine su...")
    print(osobine[broj_ciklusa])

    #uslovni kraj programa
    odgovor = \
            input("\nDa li zelite znak jos neke osobe?(d/n): ")
    if odgovor == "n":
        kraj = True
