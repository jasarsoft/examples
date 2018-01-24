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

studentString = str(student)
print(studentString)

studentString = json.dumps(student)
print(studentString)

datoteka = open("student.json", "w")
datoteka.write(studentString)
datoteka.close()
