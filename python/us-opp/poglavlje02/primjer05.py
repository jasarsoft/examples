#program za odredjivanje prestupne godine

#unos godine
godina = int(input("Unesi godinu: "))

#odredjivanje da li je godina prestupna
prestupna = (godina % 4 == 0 and godina % 100 != 0) \
            or (godina % 400 == 0)

#prikaz rezultata
if prestupna:
    print("Godina ", godina, " je prestupna!")
else:
    print("Godina ", godina, " nije prestupna!")

