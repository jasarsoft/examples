#Faktorijel

# 1! = 1
# 2! = 1 * 2
# 3! = 1 * 2 * 3
#    = 3 * 2 * 1
# 4! = 4 * 3 * 2 * 1

# n+1 = 4 -> n = 4 -1 -> n = 3
# 4! = 3! * 4
#    = 4 * 3!
# 4! = 4 * (2! * 3)
#    = 4 * (3 * 2!)
# 4! = 4 * 3 * 2 * 1!
# 4! = 4 * 3 * 2 * 1 * 0!
# 4! = 4 * 3 * 2 * 1 * 1

# n! = n * (n - 1)!
#faktorijel(n) = n * faktorijel(n-1)

def faktorijel(n):
    if n == 0:
        return 1
    else:
        return n * faktorijel(n-1)

returltat = faktorijel(5)
print(returltat)
