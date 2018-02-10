zoo = ("piton", "slon", "pingvin") #zapamtite da su zagrade opcionalne
print("Broj zivotinja u zoo vrtu je ", len(zoo))

novi_zoo = "majmun", "kamila", zoo
print("Broj kaveza u novom zoo vrtu je", len(novi_zoo))
print("Sve zivotinje u novom zoo vrtu su", novi_zoo)
print("Zivotinje koje su donete iz starog zoo vrta su", novi_zoo[2])
print("Posljenja zivotinja doneta iz starog zoo vrta je", novi_zoo[2][2])
print("Broj zivotinja u novom zoo vrtu je", len(novi_zoo)-1+len(novi_zoo[2]))
