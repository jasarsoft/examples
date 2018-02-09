def total(inicijal=5, *brojevi, ekstra_broj):
    brojanje = inicijal
    print("inicijal = ", inicijal)
    for broj in brojevi:
        brojanje += broj
        print("broj = ", broj)
        print("brojanje = ", brojanje)
    brojanje += ekstra_broj
    print("extra broj = ", ekstra_broj)
    print(brojanje)

total(10, 1, 2, 3, ekstra_broj=50)
#total(10, 1, 2, 3) #izacuje gresku jer nismo naveli vrijednost za argument "ekstra_broj"

