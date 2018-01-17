import random

SLIKE_VJESALA = ('''

  +---+
  |   |
      |
      |
      |
      |
========''', '''

  +---+
  |   |
  O   |
      |
      |
      |
========''','''

  +---+
  |   |
  O   |
  |   |
      |
      |
========''','''

  +---+
  |   |
  O   |
 /|\  |
      |
      |
========''','''

  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
========''','''

  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========''')

RIJECI = ("ajkula",   "babun",    "curka",    "dabar",    "foka",\
        "gavran",   "golub",    "guska",    "guster",   "jaguar",\
        "jarac",    "jastreb",  "jelen",    "kamila",   "kit",\
        "kobra",    "kojo",     "labud",    "lama",     "lasica",\
        "lav",      "lisica",   "los",      "losos",    "macka",\
        "magarac",  "majmun",   "mazga",    "medvjed",  "mis",\
        "mrav",     "mula",     "nosorog",  "orao",     "ovan",\
        "ovca",     "pacov",    "panda",    "papagaj",  "pas",\
        "patka",    "pauk",     "piton",    "roda",     "sismis",\
        "skoljka",  "sova",     "tigar",    "tvor",     "vidra",\
        "vrana",    "vuk",      "zaba",     "zebra",    "zec",\
        "zmija")

def Inicijalizacija():

    #inicijalizacija globalnih promjenjljivih
    global pogresnaSlova, ispravnaSlova, nepoznataRijec
    pogresnaSlova = ""
    ispravnaSlova = ""

    #slucajni broj [0..broj rijeci]
    indeks = random.randint(0 , len(RIJECI)-1)
    nepoznataRijec = RIJECI[indeks]
    return

def prikaziVjesala():

    #prikaza odgovarajuce slike na osnvu broja pogresnih pogadjanja
    print(SLIKE_VJESALA[len(pogresnaSlova)])
    print()
    print("Pogresna slova: ", end=" ")
    for slovo in pogresnaSlova:
        print(slovo, end= " ")

    print()
    praznine = "_" * len(nepoznataRijec)

    #zamjena praznina ispravno pogodjenim slovima
    for i in range(len(nepoznataRijec)):
        if nepoznataRijec[i] in ispravnaSlova:
            praznine = praznine[:i] + nepoznataRijec[i] + praznine[i+1:]
    #prikaz tajne rijec s praznim mjestom izmedju slova
    for slovo in praznine:
        print(slovo, end=" ")
    print()
    return

def unosSlova(dosadasnjaPogadjanja):
    #funkcija vraca slova koja je korisnik unio
    #i provjerava da je uneseno samo jedno slovo i nista drugo
    while True:
        print("Pogodite slovo.")
        pogadjanje = input()
        pogadjanje = pogadjanje.lower()
        if len(pogadjanje) != 1:
            print("Molimo vas unestie jedno slov.")
        elif pogadjanje in dosadasnjaPogadjanja:
            print("Vec ste naveli ovo slovo, izaberite drugo.")
        elif pogadjanje not in "abcdefghijklmnopqrstuvwxyzčćžšđ":
            print("Molimo vas unesite malo SLOVO.")
        else:
            return pogadjanje

print("--------------------------------")
print("IGRA POGADJANJA RIJECI 'VJESALA'")
Inicijalizacija()

krajIgre = False
while not krajIgre:
    prikaziVjesala()
    #igrac treba da unese (pogodi) jedno slovo nepoznate rijeci
    pogadjanje = unosSlova(pogresnaSlova + ispravnaSlova)

    if pogadjanje in nepoznataRijec:
        ispravnaSlova = ispravnaSlova + pogadjanje
        #provjera da li je igrac vec pobjedio
        pronadjenaSvaSlova = True
        for i in range(len(nepoznataRijec)):
            if nepoznataRijec[i] not in ispravnaSlova:
                pronadjenaSvaSlova = False
                break
        if pronadjenaSvaSlova:
            print("\nDa! Tajna rijec je bila '" + nepoznataRijec + "'! Pobjedili ste")
            krajIgre = True
    else:
        pogresnaSlova = pogresnaSlova + pogadjanje
        #provjera da li je igrac pogadjao
        #prevelik broj puta i izgubio
        if len(pogresnaSlova) == len(SLIKE_VJESALA) - 1:
            prikaziVjesala()
            print("\nPrekoracili ste dozvoljeni broj pogadjanja poslije " +
                  str(len(pogresnaSlova)) + " pogresnih i " +
                  str(len(ispravnaSlova)) + " ispravnih pogadjanja.\n" +
                  "Rijec je bila '" + nepoznataRijec + "'")
            krajIgre = True
    #ako je igra zavrsena pitajte igraca da li zeli da igra pnovo
    if krajIgre == True:
        odg = input("\nZelite li da igrate ponovo?(d/n)")
        if odg != "n":
            Inicijalizacija()
            krajIgre = False

