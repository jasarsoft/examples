#Index pojmova

""" Kreiranje lista pojmova u tekstualnom fajlu

    Gradi se i prikazuje lista rijeci od kojih se sastoji
    tekst u zadanom fajlu. Za svaku rijec prikazuju se
    brojevi svih linija teksta u kojima se rijec pominje.
"""
import sys

num         = 0     #globalni brojac linija
word_count  = 0     #globalni brojac rijeci

def treeInsert(s, w, n):
    if s == []: #inicijalizacija stabla(priv put)
        s.append([])  #za lijevu granu
        s.append([])
        s[0] = (w, [n])
    else:
        while True:
            if w == s[0][0] : #rijec vec postoji u stablu
                if not n in s[0][1]:
                    s[0][1].insert(len(s[0][1]), n)
                return
            elif w < s[0][0]: #spada u lijevo podstablo
                if s[1] == []: #rijec ne postoji, insert
                    s[1] = [(w, [n]), [], []]
                else:
                    s = s[1] # na lijevi
            elif w > s[0][0]: #spada u desno podstablo
                if s[2] == []:  #rijec ne postoji, insert
                    s[2] = [(w, [n]), [], []]
                else:
                    s = s[2] #u desno podstablo

def inorderTraverstal(s):
    global word_count
    if (s[1] != []):
        inorderTraverstal(s[1])
    word_count += 1
    sys.stdout.write(("%4i" % word_count)+ " "+s[0][0])
    for i in range(0, 17 - len(s[0][0])):
        sys.stdout.write(" ")
    for i in s[0][1]:
        sys.stdout.write(str(i) + " ")
    sys.stdout.write("\n")
    if (s[2] != []):
        inorderTraversal(s[2])

def binaryTree(filename):
    global num
    f = open(filename, "r", encoding="utf-8") #pritup fajlu
    r = []
    for line in f:
        num += 1
        wp = line.split()
        for w in wp:
            w = w.strip(".,;?!-\n").lower()
            if len(w) > 0:
                treeInsert(r, w, num)
    return r

tekst = input("Unesite ime fajla s tekstom: ")
stablo = binaryTree(tekst)

print("Binary linija teksta fajla '{}'={:d}".format(tekst, num))
print("Indeks pojmova: ")
print("         Rijec                linije")
inorderTraversal(stablo)
