iznos = int(input("Unesite iznos: "))

zaIsplatuOd5000 = 0
zaIsplatuOd2000 = 0
zaIsplatuOd1000 = 0
zaIsplatuOd500 = 0
zaIsplatuOd200 = 0
zaIsplatuOd100 = 0
zaIsplatuOd50 = 0
zaIsplatuOd20 = 0
zaIsplatuOd10 = 0
zaIsplatuOd5 = 0
zaIsplatuOd2 = 0
zaIsplatuOd1 = 0

while iznos >= 5000:
    iznos -= 5000
    zaIsplatuOd5000 += 1

while iznos >= 2000:
    iznos -= 2000
    zaIsplatuOd2000 += 1

while iznos >= 1000:
    iznos -= 1000
    zaIsplatuOd1000 += 1

while iznos >= 500:
    iznos -= 500
    zaIsplatuOd500 += 1

while iznos >= 200:
    iznos -= 200
    zaIsplatuOd200 += 1

while iznos >= 100:
    iznos -= 100
    zaIsplatuOd100 += 1

while iznos >= 50:
    iznos -= 50
    zaIsplatuOd50 += 1

while iznos >= 20:
    iznos -= 20
    zaIsplatuOd20 += 1

while iznos >= 10:
    iznos -= 10
    zaIsplatuOd10 += 1

while iznos >= 5:
    iznos -= 5
    zaIsplatuOd5 += 1

while iznos >= 2:
    iznos -= 2
    zaIsplatuOd2 += 1

while iznos >= 1:
    iznos -= 1
    zaIsplatuOd1 += 1

if zaIsplatuOd5000 > 0:
    print("Treba isplatiti od 5000 din x " + str(zaIsplatuOd5000))

if zaIsplatuOd2000 > 0:
    print("Treba isplatiti od 2000 din x " + str(zaIsplatuOd2000))

if zaIsplatuOd1000 > 0:
    print("Treba isplatiti od 1000 din x " + str(zaIsplatuOd1000))

if zaIsplatuOd500 > 0:
    print("Treba isplatiti od 500 din x " + str(zaIsplatuOd500))

if zaIsplatuOd200 > 0:
    print("Treba isplatiti od 200 din x " + str(zaIsplatuOd200))

if zaIsplatuOd100 > 0:
    print("Treba isplatiti od 100 din x " + str(zaIsplatuOd100))

if zaIsplatuOd50 > 0:
    print("Treba isplatiti od 50 din x " + str(zaIsplatuOd50))

if zaIsplatuOd20 > 0:
    print("Treba isplatiti od 20 din x " + str(zaIsplatuOd20))

if zaIsplatuOd10 > 0:
    print("Treba isplatiti od 10 din x " + str(zaIsplatuOd10))

if zaIsplatuOd5 > 0:
    print("Treba isplatiti od 5 din x " + str(zaIsplatuOd5))

if zaIsplatuOd2 > 0:
    print("Treba isplatiti od 2 din x " + str(zaIsplatuOd2))

if zaIsplatuOd1 > 0:
    print("Treba isplatiti od 1 din x " + str(zaIsplatuOd1))






#  0: 6430
#  1: 6430 >= 5000 ? True
# 1a: 6430 -= 5000 -> 1430
# 1b: od 5000 += 1
#  2: 1430 >= 5000 ? False
#  3: 1430 >= 2000 ? False
#  4: 1430 >= 1000 ? True
# 4a: 1430 -= 1000 -> 430
# 4b: od 1000 += 1
#  5: 430 >= 1000 ? False
#  6: 430 >=  500 ? False
#  7: 430 >=  200 ? True
# 7a: 430 -=  200 -> 230
# 7b: od 200 += 1
#  8: 230 >=  200 ? True
# 8a: 230 -=  200 -> 30
# 8b: od 200 += 1
#  9:  30 >=  200 ? False
# 10:  30 >=  100 ? False
# 11:  30 >=   50 ? False
# 12:  30 >=   20 ? True
#12a:  30 -=   20 -> 10
#12b: od 20 += 1
# 13:  10 >=   20 ? False
# 14:  10 >=   10 ? True
#14a:  10 -=   10 -> 0
#14b: od 10 += 1
