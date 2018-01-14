# Python 3.5 - Uvod u programiranje
# Predavanje 06 - Singidunum

v1 = float(input("v1: "))
v2 = float(input("v2: "))

l1 = 2*v1*60 + 2*(v1+2)*60  + 2*3*(v1+2)*60 + 2*(3*(v1+2)-2)*60
l2 = 2*60*v2 + 2*60*(v2+1) + 2*60*((v2+1)*2) + 2*60*((v2+1)*2-1)

print("Auto 1 ce preci put od " + str(l1) + " metara.")
print("Auto 2 ce preci put od " + str(l2) + " metara.")

if l1 < l2:
    print("Auto 2 je presao veci put od auta 1.")
elif l1 == l2:
    print("Auto 1 i auto 2 su presli isti put.")
else:
    print("Auto 1 je presao veci put od auta 2.")

print("Kraj")
