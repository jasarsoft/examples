import json

student = {
    "ime"   : "Milan",
    "prezime"   : "Tair",
    "indeks"    : 2008213514,
    "ispiti"    : [
        {
            "predmet"   : "Programiranje 1",
            "datum"     : "2008-01-05",
            "ocjena"    : 10
            },
        {
            "predmet"   : "Informatika",
            "datum"     : "2008-01-05",
            "ocjena"    : 10
            }
        ]
}

datoteka = open("student.json", "w")
json.dump(student, datoteka)
datoteka.close()
