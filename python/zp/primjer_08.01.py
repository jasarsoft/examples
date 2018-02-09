broj = 23
pogadjanje = int(input('Pogodi broj: '))

if pogadjanje == broj:
    print('Cestitamo pogdio si broj.') #novi blok pocinje ovdje
    print('(Ali nisi osvojio nikavu nagradu!)') #novi blok se zavrsava ovdje
elif pogadjanje < broj:
    print('Ne, on je malo veci nego taj.') #jos jedan blok
    #mozete uraditi sta vam je volja u ovom bloku
else:
    print('Ne, on je malo manji nego taj.')
    #da bi se izvrsio ovaj blok mora je biti pogadjanje > broj.

print('''Gotovo :)''') #ovaj red ce se uvijek izvrsavati poslije if provjere jer je u glavnom bloku
