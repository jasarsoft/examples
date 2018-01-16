# funkcija racunanja Fibonacijevog broja za zadani index
def fib(n):
    if n == 0: #priv nivo
        return 0
    elif n == 1: #prvi nivo
        return 1
    else: #rekurzivni pozivi
        return fib(n-1) + fib(n-2)

n = int(input("Unesite indeks za Fibonacijev broj: "))

#racunanje i prikaza Fibonacijevog broja
print("Fibonacijev broj za indekx ", n, " je ", fib(n))
