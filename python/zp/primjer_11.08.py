ime = "Swaroop" #ovo je prvi string objekt

print(ime)
if ime.startswith("Swa"):
    print("Da, string pocinje sa 'Swa'")

if 'a' in ime:
    print("Da, string u sebi ima slovo 'a'")

if ime.find('war') != -1:
    print("Da, string sadrzi slove 'war'")

razmak = '_*_'
mojalista = ['brazil', 'rusija', 'indija', 'kina']
print(razmak.join(mojalista))
