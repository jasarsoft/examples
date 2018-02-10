#ovo je moj spisak za kupovinu
spisakkupovine = ['jabuka', 'mango', 'sergarepa', 'banana']

print("Ja imam", len(spisakkupovine), "stavi da kupim.")

print("Te stvari su:", end=" ")
for stvar in spisakkupovine:
    print(stvar, end=", ")

print("\nJa takodje trebam da kupim i pirinac.")
spisakkupovine.append("pirinac")
print("Moj spisak za kupuovinu je sad", spisakkupovine)

print("Sada cu da sortiram moj spisak.")
spisakkupovine.sort()
print("Sortirana lista je", spisakkupovine)

print("Prva stvar koju cu kupit je", spisakkupovine[0])
starastvar = spisakkupovine[0]

del spisakkupovine[0]
print("Kupio sam", starastvar)
print("MOj spisak za kupovinu je sada", spisakkupovine)
