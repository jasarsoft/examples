n = (40, -5, 'Milan', 11)

print(n)
print(n[1:]) #prikaz sve do kraja
print(n[1:-1]) #prikaz sve do posljednjeg

#posebna vrsta n-torke (imenovane n-torke)
import collections

#fukcija
Student = collections.namedtuple('Student', 'ime, prezime, indeks, prosjek')

s1 = Student('Milan', 'Tair', 2008213514, 9.5)
s4 = Student('Pera', 'Peric', 2010213514, 9.5)
print(s1)
print(s1.indeks) #ispis samo indeks objekta

s2 = {
        'ime': 'Milan',
        'prezime': 'Tair',
        'indeks': 2008213514,
        'prosjek': 9.5
}

s3 = {
        'ime': 'Pera',
        'prezime': 'Peric',
        'index': 2010213514,
        'prosjek': 9.5
}

print(s2['indeks'])
# print(s3['indeks']) #greska
print(s4.indeks)

print(s4._asdict()['indeks']) #mogucnost sa imenom indeks
