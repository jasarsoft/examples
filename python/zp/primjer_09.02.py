def prikaziMaks(a, b):
    if a > b:
        print(a, " je maksimalno")
    elif a == b:
        print(a, " je jednako sa ", b)
    else:
        print(b, " je maksimalno")

prikaziMaks(3, 4) #direktno saljemo funkciji konstatne vrijednost

x = 5
y = 7

prikaziMaks(x, y) #saljemo varijable funkciji
