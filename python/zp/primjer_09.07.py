#varargs parametri

def total(inicijal = 5, *brojevi, **kljucnerijeci):
    brojanje = inicijal
    print(inicijal)
    for broj in brojevi:
        brojanje += broj
        print("broj = ", broj)
        print("brojanje = ", brojanje)
    for rec in kljucnerijeci:
        brojanje +=kljucnerijeci[rec]
        print("kljucnerijeci = ", kljucnerijeci[rec])
    return brojanje

print(total(10, 1, 2, 3, povrce = 50, voce = 100))
