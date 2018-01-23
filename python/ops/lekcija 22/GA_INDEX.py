import mobilni_telefon
import ekran_telefona

print("Milan Tair, 2008213514, 10.11.2016.")

broj = int(input("Koliko telefona zelite da unesete? "))
telefoni = []

if broj > 0:
    for i in range(broj):
        proizvodjac = str(input("Unesite ime proizvodjaca: "))
        model = str(input("Unesite ime modela telefona: "))
        godina = int(input("Unesite godinu proizvodnje: "))
        memorijaRAM = float(input("Unesite kolicinu RAM u MB: "))
        memorijaDisk = float(input("Unesite kapacitet skladisat u MB: "))
        sirina = float(input("Unesite sirina ekrana: "))
        visina = float(input("Unesite visinu ekrana: "))

        ekran = ekran_telefona.EkranTelefona(sirina, visina)
        
        telefon = mobilni_telefon.MobilniTelefon(
            proizvodjac, model, godina, memorijaRAM, memorijaDisk, ekran
            )

        telefoni.append(telefon)

    for j in range(broj - 1):
        for i in range(broj - 1):
            if mobilni_telefon.ocjenaPodobnosti(telefoni[i]) < mobilni_telefon.ocjenaPodobnosti(telefoni[i+1]):
                temp = telefoni[i]
                telefoni[i] = telefoni[i+1]
                telefoni[i+1] = temp

    najbolji = telefoni[0]

    print("{0:20s}{1:17s}{2:20s}{3:19s}"
          .format(
              "Proizvodjac:", najbolji['proizvodjac'],
              "Model:", najbolji['model']
              )
          )

    print("{0:24s}{1:13d}    {2:20s}{3:16.2f} PP"
          .format(
              "Godina proizvodnje:", najbolji['godina'],
              "Ocjena podobnosti:", mobilni_telefon.ocjenaPodobnosti(najbolji)
              )
          )

    print("{0:24s}{1:5.2f} x {2:5.2f} in {3:20s}{4:16.2f} in"
          .format(
              "Sirina i visina ekrana:",
                  najbolji['ekran']['sirina'],
                  najbolji['ekran']['visina'],
              "Dijagonala ekrana:", ekran_telefona.dijagonala(najbolji['ekran'])
              )
          )

    print("{0:24s}{1:13.2f} MB {2:20s}{3:16.2f} MB"
          .format(
              "Kolicina RAM memorije", najbolji['memorijaRAM'],
              "Kolicina skladista:", najbolji['memorijaDisk']
              )
          )
    
else:
    print("Niste unijeli ispravan broj!")
