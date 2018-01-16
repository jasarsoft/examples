def brojDana (dan, mjesec, godina):
    # prilagodjavanje brojanja mjeseci i godina
    m = (mjesec + 9) % 12
    g = godina - m // 10

    # racunuanje rednih brojeva dana
    n = 365 * g + g // 4 - g // 100 + g // 400 + (m * 306 + 5) // 10 + dan - 1
    return n

# unos prvog datuma
print("Unesite prvi datum")
dan1     = int(input("  dan: "))
mjesec1  = int(input("  mjesec: "))
godina1  = int(input("  godina: "))

# unos drugog datuma
print("Unesite drugi datum")
dan2    = int(input("   dan: "))
mjesec2 = int(input("   mjesec: "))
godina2 = int(input("   godina: "))

# racunanje broja dana izmedju dva datuma i ispis rezultata
print("Broj dana izmedju ", dan1, mjesec1, godina1, " i ", \
      dan2, mjesec2, godina2, " je ", \
      brojDana(dan2, mjesec2, godina2) - \
      brojDana(dan1, mjesec1, godina1))
