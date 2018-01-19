#Fibonacijev niz

def fibonaci(n):
    if n == 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonaci(n-1) + fibonaci(n-2)

rezultat = fibonaci(0)
print("fibonaci(0) = ", rezultat)
rezultat = fibonaci(1)
print("fibonaci(1) = ", rezultat)

# <- fibonaci(2-1) + fibonaci(2-2)
# <- 1 + 0
rezultat = fibonaci(2) # 1
print("fibonaci(2) = ", rezultat)

# <- fibonaci(3-1) + fibonaci(3-2)
# <- fibonaci(2-1) + fibonaci(2-2) + 1
# <- 1 + 0 + 1
rezultat = fibonaci(3)
print("fibonaci(3) = ", rezultat)

rezultat = fibonaci(4)
print("fibonaci(4) = ", rezultat)

rezultat = fibonaci(27)
print("fibonaci(27) = ", rezultat)
print()

for i in range(0, 11):
    print("fibonaci(", i, ") = ", fibonaci(i))

