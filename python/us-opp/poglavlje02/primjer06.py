""" Racunanje broja dana izmedju dva datuma
    po Gregorijanskom kalendaru (od oktobra 1582):
    1. ucitati datum1 i datum2 (dan, mjesec, godina)
    2. prilagoditi brojanje mjeseci
        m1 = (mjesec1+9) % 12 i m2 = (mjesec2+9) % 12
    3. prilagoditi brojanje godina
        g1 = godina1 - m1//10 i g2 = godina2 - m2//10
    4. izracunati redne brojeve dane n1 i n2:
        n = 365*g+g//4-g1//100+g1//400+(m*306+5)//10+dan-1
    5. broj dana je n = n2 - n1
"""
#unos prvog datuma
print("Unesite prvi datum")
dan1    = int(input("   dan: "))
mjesec1 = int(input("   mjesec: "))
godina1 = int(input("   godina: "))

#unos drugog datuma
print("Unesite drugi datum")
dan2    = int(input("   dan: "))
mjesec2 = int(input("   mjesec: "))
godina2 = int(input("   godina: "))

#prilagodjavanje brojanja mjeseci (mart je 01) i godina
#(u skladu sa brojanjem mjeseci)
m1 = (mjesec1 + 9) % 12
m2 = (mjesec2 + 9) % 12
g1 = godina1 - m1 // 10
g2 = godina2 - m2 // 10

#racunanje rednih brojeva dana
n1 = 365 * g1 + g1 // 4 - g1 // 100 + g1 // 400 + \
     (m1 * 306 + 5) // 10 + dan1 - 1
n2 = 365 * g2 + g2 // 4 - g2 // 100 + g2 // 400 + \
     (m2 * 306 + 5) // 10 + dan2 - 1

#racunanje broja dana izmedju dva datuma i ispis
n = n2 - n1
print("Broj dana izmedju ", dan1, mjesec1, godina1, " i ", \
      dan2, mjesec2, godina2, " je ", n)
