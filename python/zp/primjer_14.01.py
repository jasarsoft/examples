def obrnut(tekst):
    return tekst[::-1]

def da_li_je_palindrom(tekst):
    return tekst == obrnut(tekst)

nesto = input("Ukucja tekst: ")
if(da_li_je_palindrom(nesto)):
    print("Da, to je palindrom")
else:
    print("Ne to nije palindrom")
