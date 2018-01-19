#kolekcija deque

import collections

d = collections.deque()
print(d)
d.append(30)
d.append(20)
d.append(5)
d.append(11)
d.append(50)

print(d)
d.appendleft(10) #dodavanje lijevo
print(d)
posljednjaVrijednost = d.pop() #izacivanje vrijednosti sa svrha
print(posljednjaVrijednost)
print(d)

vrijednost = d.popleft()
print(vrijednost)
print(d)

#prosirenje
d.extend([20, 66, -4, 10])
posljednjaVrijednost = d.pop()
print(posljednjaVrijednost)
print(d)

#okretanje
d.reverse()
print(d)

#izmjesanje
d.rotate()
print(d)

#birsanje svih elemenata
#d.clear()

m = d #referenca
print(m)

m[3] = 1000
print(m)
print(d)

#kopija deque
m = d.copy()
m[3] = 10
print(m)
print(d)


