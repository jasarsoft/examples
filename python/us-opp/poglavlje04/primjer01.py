#euklidov algoritam racunanja NZD
#(iterativni)

x = int(input("Unesi X "))
y = int(input("Unesi Y "))

while x != y:
    if x > y:
        x = x - y
    else:
        y = y -x

print("NZD = ", x)
